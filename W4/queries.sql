
-- #5 challenge
SELECT FirstName, Address FROM Customer WHERE Country = 'Brazil' ORDER BY FirstName DESC;
SELECT LastName AS 'its my last name', FirstName AS fn FROM Customer WHERE Company IS null;

-- get everyone grouped by country.
SELECT FirstName, Count(FirstName) As HowMany FROM Customer Group BY FirstName ORDER BY FirstName;

--
select FirstName FROM Customer ORDER BY FirstName;

--
SELECT FirstName, Address, Country FROM Customer Group BY Country ORDER BY FirstName DESC;

-- Display the artists who have more than 1 song
SELECT TOP 5 A.Name AS Name, COUNT(T.TrackId) AS NumSongs 
FROM [dbo].[Artist] A 
Left Join [dbo].[Album] Alb ON A.ArtistId = Alb.ArtistId
Left Join [dbo].[Track] T ON Alb.AlbumId = T.AlbumId
GROUP BY A.Name 
HAVING COUNT(T.TrackId) > 1
ORDER BY Name;

-- show top 1000 Customers starting with the highest id number
SELECT TOP (1000) * FROM [dbo].[Customer] Order by CustomerId desc;

--create a subquery to get the number of items in the table.
INSERT INTO Customer (CustomerId, FirstName, LastName,Email) VALUES ((SELECT MAX(CustomerId) FROM [dbo].[Customer])+1,'mmmmm', 'nnnnn','mark@mark.com');

-- get a customer by first and last names
SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer] WHERE FirstName = 'James Alan' AND LastName = 'Moore'; 

SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer];

-- get the average of 3 decimal args
-- (Scalar) Functions return a single value
CREATE FUNCTION GetMyAverage(@grade1 decimal(5,2), @grade2 decimal(5,2), @grade3 decimal(5,2))
RETURNS decimal(5,2)
AS
BEGIN
	DECLARE @avg decimal(5,2);	
	SELECT @avg = (@grade1 +@grade2+@grade3)/3;
	RETURN @avg;
END

SELECT dbo.GetMyAverage(100.00, 12.32, 47.62) AS AveragedValue;

-- CHINOOK - Table-Value Function - Get a selected number of artists and their numebr of tracks.
-- TVFs return a whole table as the result
CREATE FUNCTION GetNumOfArtistsAndTheirNumTracks(@tops INT)
RETURNS TABLE
AS
RETURN
	(SELECT TOP (@tops) A.Name AS Name, COUNT(T.TrackId) AS NumSongs 
	FROM [dbo].[Artist] A 
	Left Join [dbo].[Album] Alb ON A.ArtistId = Alb.ArtistId
	Left Join [dbo].[Track] T ON Alb.AlbumId = T.AlbumId
	GROUP BY A.Name 
	HAVING COUNT(T.TrackId) > 1
	ORDER BY Name);

SELECT * FROM GetNumOfArtistsAndTheirNumTracks(10);


-- TVFs return all the distinct support rep ids
CREATE FUNCTION GetDistinctSupportReps()
RETURNS TABLE
AS
RETURN
	(SELECT TOP(100) C.SupportRepId As ID, E.FirstName AS Fname, E.LastName AS Lname 
	FROM [dbo].[Customer] C
	LEFT JOIN [dbo].[Employee] E ON C.SupportRepId = E.EmployeeId
	WHERE C.SupportRepId > 0
	ORDER BY C.SupportRepId);

SELECT * FROM GetDistinctSupportReps();
DROP FUNCTION GetDistinctSupportReps


--Stored Prodecure - Get a number of support reps and their names
CREATE PROCEDURE GetSupportReps(@howMany INT)
AS
	SELECT TOP(@howMany) C.SupportRepId As ID, E.FirstName AS Fname, E.LastName AS Lname 
	FROM [dbo].[Customer] C
	LEFT JOIN [dbo].[Employee] E ON C.SupportRepId = E.EmployeeId
	WHERE C.SupportRepId > 0
	ORDER BY C.SupportRepId;

EXEC GetSupportReps 10;
DROP Procedure GetSupportReps

-- CHINOOK - Create a stored procedure that gets the Employees with a substring of the param string in their title.
CREATE PROCEDURE GetEmployeesWithTitleSubString(@contains NVARCHAR(10), @howmany INT OUTPUT)
AS
	SELECT FirstName AS Fname, LastName AS Lname, Title
	FROM [dbo].[Employee]
	WHERE Title LIKE CONCAT('%',@contains,'%');
  --you can have multiple SELECT statements in a procedure.
	SELECT @howmany = COUNT(*) FROM [dbo].[Employee]
	WHERE Title LIKE CONCAT('%',@contains,'%');

-- run these three lines together so that @res is created to be used in the EXEC and SELECT statements below it.
DECLARE @res INT;
EXEC GetEmployeesWithTitleSubString 'Sales', @res OUTPUT;
Select @res AS HowManyRows;

DROP Procedure GetEmployeesWithTitleSubString;

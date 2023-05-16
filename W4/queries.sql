SELECT TOP (1000) * FROM [dbo].[Customer]

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

-- show all Customers starting with the highest id number
SELECT TOP (1000) * FROM [dbo].[Customer] Order by CustomerId desc;

--create a subquery to get the number of items in the table.
INSERT INTO Customer (CustomerId, FirstName, LastName,Email) VALUES ((SELECT MAX(CustomerId) FROM [dbo].[Customer])+1,'mmmmm', 'nnnnn','mark@mark.com');

-- get a customer by first and last names
SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer] WHERE FirstName = 'James Alan' AND LastName = 'Moore'; 

SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer];
using System.Text.Json;
using System;

namespace RpsGame1;
class Program
{
    static void Main(string[] args)
    {
        // Person p = new Person();
        // p.Fname = "Mark";
        // //p.age = 43;

        // Person p1 = new Person(42, "Mark", "Moore");// you can set a readonly property in the constructor, but not again afterwards.
        // // Console.WriteLine($"Hello. I'm Mark and I'm {p1.age} years old.");

        // List<Person> lp = new List<Person>();
        // lp.Add(p);
        // lp.Add(p1);
        // foreach (Person pp in lp)
        // {
        //     Console.WriteLine($"The persons name is {pp.Fname} {pp.Lname} who is {pp.age} years old.");
        // }

        Random rand = new Random();
        Console.WriteLine($"Hey there. Please enter your first name followed by you last name followed by your age.");
        string? names = Console.ReadLine();
        Person comp = new Person("Inac", "atharvard", 77);

        // divide the string delimited by a space
        string[] personDataArr = names!.Split(' ');
        int winsUser = 0;
        int winsComputer = 0;
        int ties = 0;
        Choices userChoiceEnum;

        // create the game classe.
        List<Game> games = new List<Game>();
        Game game = new Game();

        // start the rounds
        do
        {
            // TODO create a try/catch to catch this exception
            try
            {
                Console.WriteLine($"Thanks {personDataArr[0]} {personDataArr[1]}. Please enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"There was an exception => {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The general exceptions was caught. it's inner exception is {ex.InnerException}");
            }

            // get the users choice
            string? userChoice = null;
            int wrong = 0;
            do
            {
                if (wrong > 0)
                {
                    Console.WriteLine($"Hey, {personDataArr[0]}. Please follow instructions. I said enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
                }
                userChoice = Console.ReadLine()!.ToUpper();// what happens if the string is null?
                wrong++;
            } while (!userChoice!.Equals("R") && !userChoice.Equals("P") && !userChoice.Equals("S"));

            // convert the users choice to a Choices Type Enum (Enumerable)
            if (userChoice.Equals("R"))
            {
                userChoiceEnum = 0;
                Console.WriteLine($"The users choice R is => {userChoiceEnum}");
            }
            else if (userChoice.Equals("P"))
            {
                userChoiceEnum = (Choices)1;
                Console.WriteLine($"The users choice P is => {userChoiceEnum}");
            }
            else
            {
                userChoiceEnum = (Choices)2;
                Console.WriteLine($"The users choice S is => {userChoiceEnum}");
            }

            // the while-loop version of the above loop.
            // while (!userChoice!.Equals("R") && !userChoice.Equals("P") && !userChoice.Equals("S"))
            // {
            //     if (wrong > 0)
            //     {
            //         Console.WriteLine($"Hey, {namesArr[0]}. Please follow instructions. I said enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
            //     }
            //     userChoice = Console.ReadLine()!.ToUpper();// what happens if the string is null?
            //     wrong++;
            // } 

            Choices compChoiceEnum = (Choices)rand.Next(Choices.GetNames(typeof(Choices)).Length);
            // Console.Write($"\tThe computers choice is {compChoiceEnum}");

            // create the player and game Person objects
            //int personAge = 0;
            bool successfulAgeConversion = Int32.TryParse(personDataArr[2], out int personAge);
            Person? player = null;
            if (successfulAgeConversion)
            {
                player = new Person(personDataArr[0], personDataArr[1], personAge);
            }


            // compare the results with the computers hard-coded choice.
            if ((userChoiceEnum == Choices.ROCK && compChoiceEnum == Choices.PAPER)
            || (userChoiceEnum == Choices.PAPER && compChoiceEnum == Choices.SCISSORS)
            || (userChoiceEnum == Choices.SCISSORS && compChoiceEnum == Choices.ROCK))
            {// computer wins
                Console.WriteLine($"Doh! {personDataArr[0]}, bruh... The computer won");
                winsComputer++;
                Round r = new Round(comp, player!);
                // r.RoundWinner = comp;
                // r.RoundLoser = player!;
                r.RoundLoserChoice = userChoiceEnum;
                r.RoundWinnerChoice = compChoiceEnum;
                game.Rounds.Add(r);
            }
            else if ((userChoiceEnum == Choices.PAPER && compChoiceEnum == Choices.ROCK)
            || (userChoiceEnum == Choices.SCISSORS && compChoiceEnum == Choices.PAPER)
            || (userChoiceEnum == Choices.ROCK && compChoiceEnum == Choices.SCISSORS))
            {// user wins
                Console.WriteLine($"YAAAAS!!! {personDataArr[0]}, bruh... The user won");
                winsUser++;
                Round r = new Round(player!, comp);
                // r.RoundWinner = player!;
                // r.RoundLoser = comp;
                r.RoundLoserChoice = compChoiceEnum;
                r.RoundWinnerChoice = userChoiceEnum;
                game.Rounds.Add(r);
            }
            else
            {// tie
                Console.WriteLine($"Close!! {personDataArr[0]}, bruh... It was a tie.");
                ties++;
                Round r = new Round(new Person() { Fname = "tie" }, new Person() { Fname = "tie" });
                r.RoundLoserChoice = userChoiceEnum;
                r.RoundWinnerChoice = compChoiceEnum;
                game.Rounds.Add(r);
            }

        } while (winsComputer < 2 && winsUser < 2);


        Console.WriteLine($"Looks like the computer won {winsComputer} rounds, You won {winsUser} rounds, and there were {ties} ties.");
        /* refactor this code so that the game continues looping till one player gets 2 wins.
        print out the number of rounds and how many wins each palyer had adn how many ties total. 
        */
        int roundNum = 1;
        foreach (Round r in game.Rounds)
        {
            Console.WriteLine($"The winner of round {roundNum} was {r.RoundWinner.Fname} with a choice of {r.RoundWinnerChoice}");
            roundNum++;
        }

        // give a switch statement for a menu
        Console.WriteLine($" Congratulations, {personDataArr[0]}, You completed a game. Would you like to save it? YES or NO");
        string? savebool = Console.ReadLine();

        switch (savebool)
        {
            case "YES":
                //do the saving to the file.
                //Console.WriteLine($"This is the YES statement");
                if (!File.Exists("GameStorage.txt"))
                {
                    // File.Create("GameStorage.txt");
                    // if empty, save the game to a List<Game> and write to the file.
                    List<Game> gameAsList = new List<Game>();
                    gameAsList!.Add(game);// '!' means that I know that the variable my be null. I want to DEREFERENCE it anyway
                    string gameSerialized = JsonSerializer.Serialize(gameAsList);
                    // write the serialized list of games ot the file.
                    File.WriteAllText("GameStorage.txt", gameSerialized);
                }
                else
                {
                    // read from the file into ta string
                    string gameText = File.ReadAllText("GameStorage.txt");
                    // convert the game into a list
                    // '?' means that I know that the value I an ASSIGNING to this variable may be null. I want to do it anyway.
                    List<Game>? gameList = JsonSerializer.Deserialize<List<Game>>(gameText);

                    // add the current game to the List<Game>
                    gameList!.Add(game);// '!' means that I know that the variable my be null. I want to DEREFERENCE it anyway

                    // serialize the List<Game> as Json
                    string gameSerialized = JsonSerializer.Serialize(gameList);

                    // write the serialized list of games ot the file.
                    File.WriteAllText("GameStorage.txt", gameSerialized);
                    // }
                }
                Console.WriteLine($"Thanks for playing. Your game was saved. Quitting the game.");
                break;
            case "NO":
                Console.WriteLine($"Quitting the game.");
                break;

                // default:
                //     Console.WriteLine($"The default value was tripped.");
                //     break;
        }


        // save the game to a file.
        // serialized the game object
        //string gameSerialized = JsonSerializer.Serialize(game);
        // Console.WriteLine(gameSerialized);

        // write the JSON string to the file.
        //File.WriteAllText("GameStorage.txt", gameSerialized);

    }// EoM
}// EoP

using System.Text.Json;
using System;

namespace RpsGame1;
class Program
{
    static void Main(string[] args)
    {
        // Random rand = new Random();
        Console.WriteLine($"Hey there. Please enter your first name followed by you last name followed by your age.");
        Person player = RPS_GamePlay.RegisterPlayer(Console.ReadLine()!);
        Person comp = RPS_GamePlay.Comp;

        // divide the string delimited by a space
        // string[] personDataArr = names!.Split(' ');
        int winsUser = 0;
        int winsComputer = 0;
        int ties = 0;
        Choices? userChoice;

        // create the game classe.
        List<Game> games = new List<Game>();
        Game game = new Game();

        // start the rounds
        do
        {
            // TODO create a try/catch to catch this exception
            try
            {
                Console.WriteLine($"Thanks {player.Fname} {player.Lname}. Please enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
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
            userChoice = null;
            int wrong = 0;
            do
            {
                if (wrong > 0)
                {
                    Console.WriteLine($"Hey, {player.Fname}. Please follow instructions. I said enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
                }
                userChoice = RPS_GamePlay.ValidateUserInput(Console.ReadLine()!);// what happens if the string is null?
                wrong++;
            } while (userChoice == null);

            Choices compChoiceEnum = RPS_GamePlay.GetRandomChoice();

            //document the choices of hte user and computer
            LoggingService.LogChoices(comp, compChoiceEnum);
            LoggingService.LogChoices(player, userChoice);

            // compare the results with the computers choice.
            int roundWinner = RPS_GamePlay.EvaluateRound(compChoiceEnum, userChoice);

            if (roundWinner == 1)
            {// computer wins
                Console.WriteLine($"Doh! {player.Fname}, bruh... The computer won");
                winsComputer++;
                Round r = new Round(comp, player!);
                r.RoundLoserChoice = userChoice;
                r.RoundWinnerChoice = compChoiceEnum;
                game.Rounds.Add(r);
            }
            else if (roundWinner == 2)
            {// user wins
                Console.WriteLine($"YAAAAS!!! {player.Fname}, bruh... The user won");
                winsUser++;
                Round r = new Round(player!, comp);
                r.RoundLoserChoice = compChoiceEnum;
                r.RoundWinnerChoice = userChoice;
                game.Rounds.Add(r);
            }
            else if (roundWinner == 0)
            {// tie
                Console.WriteLine($"Close!! {player.Fname}, bruh... It was a tie.");
                ties++;
                Round r = new Round(new Person() { Fname = "tie" }, new Person() { Fname = "tie" });
                r.RoundLoserChoice = userChoice;
                r.RoundWinnerChoice = compChoiceEnum;
                game.Rounds.Add(r);
            }

        } while (winsComputer < 2 && winsUser < 2);


        Console.WriteLine($"Looks like the computer won {winsComputer} rounds, You won {winsUser} rounds, and there were {ties} ties.");
        int roundNum = 1;
        foreach (Round r in game.Rounds)
        {
            Console.WriteLine($"The winner of round {roundNum} was {r.RoundWinner.Fname} with a choice of {r.RoundWinnerChoice}");
            roundNum++;
        }

        // give a switch statement for a menu
        Console.WriteLine($" Congratulations, {player.Fname}, You completed a game. Would you like to save it? YES or NO");
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

                    // write the serialized list of games to the file.
                    File.WriteAllText("GameStorage.txt", gameSerialized);
                    // }
                }
                Console.WriteLine($"Thanks for playing. Your game was saved. Quitting the game.");
                break;
            case "NO":
                Console.WriteLine($"Quitting the game.");
                break;
            default:
                Console.WriteLine($"The default value was tripped.");
                break;
        }
    }// EoM
}// EoP

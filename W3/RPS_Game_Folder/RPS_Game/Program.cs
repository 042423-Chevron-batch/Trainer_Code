using System.Text.Json;
using System;

namespace RpsGame1;


//this is equivalent to the website
class Program
{
    static void Main(string[] args)
    {
        // Random rand = new Random();
        Console.WriteLine($"Hey there. Please enter your first name followed by you last name followed by your age.");
        string? userResponse = Console.ReadLine();
        Person player = RPS_GamePlay.RegisterPlayer(userResponse!);
        Person comp = RPS_GamePlay.Comp;
        int winsUser = 0;// FE
        int winsComputer = 0;// FE`
        int ties = 0;// FE
        Choices? userChoice;// FE

        // create the game class.
        List<Game> games = new List<Game>();// BE
        Game game = new Game();// FE

        // start the rounds
        do
        {
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

            userChoice = null;
            int wrong = 0;
            do
            {
                if (wrong > 0)
                {
                    Console.WriteLine($"Hey, {player.Fname}. Please follow instructions. I said enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
                }
                userChoice = RPS_GamePlay.ValidateUserInput(Console.ReadLine()!);// TODO check return of this method.
                wrong++;
            } while (userChoice == null);

            Choices compChoiceEnum = RPS_GamePlay.GetRandomChoice();
            //document the choices of the user and computer
            LoggingService.LogChoices(comp, compChoiceEnum);
            LoggingService.LogChoices(player, userChoice);

            // compare the results with the computers choice.
            int roundWinner = RPS_GamePlay.EvaluateRound(compChoiceEnum, userChoice);

            if (roundWinner == 1)
            {// computer wins
                Console.WriteLine($"Doh! {player.Fname}, bruh... The computer won");
                winsComputer++;
                Round r = RPS_GamePlay.RecordRound(comp, player!, compChoiceEnum, userChoice);
                game.Rounds.Add(r);
            }
            else if (roundWinner == 2)
            {// user wins
                Console.WriteLine($"YAAAAS!!! {player.Fname}, bruh... The user won");
                winsUser++;
                Round r = RPS_GamePlay.RecordRound(player!, comp, userChoice, compChoiceEnum);
                game.Rounds.Add(r);
            }
            else if (roundWinner == 0)
            {// tie
                Console.WriteLine($"Close!! {player.Fname}, bruh... It was a tie.");
                ties++;
                Round r = new Round(new Person() { Fname = "tie" }, new Person() { Fname = "tie" }, userChoice, compChoiceEnum);
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

        Console.WriteLine($" Congratulations, {player.Fname}, You completed a game. Would you like to save it? YES or NO");
        string? savebool = Console.ReadLine();

        switch (savebool)
        {
            case "YES":
                bool yeah = DocumentGames.RecordMyGame(game);
                if (yeah)
                {
                    Console.WriteLine($"Thanks for playing. Your game was saved. Quitting the game.");
                }
                break;
            default:
                Console.WriteLine($"The default value was tripped.");
                break;
        }
    }// EoM
}// EoP

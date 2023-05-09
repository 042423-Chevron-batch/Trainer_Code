namespace RpsGame1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Hey there. Please enter your name.");
        string? name = Console.ReadLine();
        Console.WriteLine($"Thanks. Please enter a R, P, or S for Rock, Paper, or Scissors.");
        string? userChoice1 = Console.ReadLine();
        string userChoice = userChoice1!.ToUpper();
        // hard-code the computers choice.
        char compChoice = 'P';

        //compare the results with the computers hard-coded choice.
        if (userChoice == "R" && compChoice.ToString().Equals("P"))
        {// computer wins
            Console.WriteLine($"Doh! {name}, bruh... The computer won");
        }
        else if (userChoice == "S" && compChoice.ToString().Equals("P"))
        {// user wins
            Console.WriteLine($"YAAAAS!!! {name}, bruh... The user won");
        }
        else
        {// tie
            Console.WriteLine($"Close!! {name}, bruh... It was a tie.");
        }


        /* refactor this code so that the game continues looping till one player gets 2 wins.
        print out the number of rounds and how many wins each palyer had adn how many ties total. 

        */

    }
}

namespace RpsGame1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Hey there. Please enter your first name followed by you last name.");
        string? names = Console.ReadLine();

        // divide the string delimited by a space
        var namesArr = names!.Split(' ');
        int winsUser = 0;
        int winsComputer = 0;
        int ties = 0;

        // start the rounds
        do
        {

            Console.WriteLine($"Thanks {namesArr[0]} {namesArr[1]}. Please enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
            // string? userChoice1 = null;

            string? userChoice = null;
            int wrong = 0;
            do
            {
                if (wrong > 0)
                {
                    Console.WriteLine($"Hey, {namesArr[0]}. Please follow instructions. I said enter an \"R\", a \"P\", or an \"S\" for Rock, Paper, or Scissors.");
                }
                userChoice = Console.ReadLine()!.ToUpper();// TODO what happens if the string is null?
                wrong++;
            } while (!userChoice!.Equals("R") && !userChoice.Equals("P") && !userChoice.Equals("S"));


            // hard-code the computers choice.
            char compChoice = 'P';//TODO - change to 1,2,3 random choice. Add enum.. and refactor the code below

            // compare the results with the computers hard-coded choice.
            if (userChoice == "R" && compChoice.ToString().Equals("P"))
            {// computer wins
                Console.WriteLine($"Doh! {namesArr[0]}, bruh... The computer won");
                winsComputer++;
            }
            else if (userChoice == "S" && compChoice.ToString().Equals("P"))
            {// user wins
                Console.WriteLine($"YAAAAS!!! {namesArr[0]}, bruh... The user won");
                winsUser++;
            }
            else
            {// tie
                Console.WriteLine($"Close!! {namesArr[0]}, bruh... It was a tie.");
                ties++;
            }

        } while (winsComputer < 2 && winsUser < 2);


        Console.WriteLine($"Looks like the computer won {winsComputer} rounds, You won {winsUser} rounds, and there were {ties} ties.");
        /* refactor this code so that the game continues looping till one player gets 2 wins.
        print out the number of rounds and how many wins each palyer had adn how many ties total. 

        */

    }
}

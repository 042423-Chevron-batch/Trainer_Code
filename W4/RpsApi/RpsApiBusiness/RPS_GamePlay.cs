using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpsApiModels;
using RpsApiRepository;

namespace RpsApiBusiness
{
    public class RPS_GamePlay
    {
        private static List<Game> AllGames { get; set; } = new List<Game>();
        public static Person Comp { get; set; } = new Person("Inac", "atharvard", 77);
        private static Random rand = new Random();

        /// <summary>
        /// This method takes 2 sgtrings and passes them on to the repo method Test to register a new person
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Test(string fname, string lname, string email)
        {
            // the business layer is for validating the data and/or manipulating it.
            int res = Repository.Test(fname, lname, email);
            return res;
        }


        /// <summary>
        /// This method takes an int and a double and returns a string concatenation of them 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static string TestDemoMethod(int x, double y)
        {
            string ret = $"{x} {y}";
            return ret;
        }

        /// <summary>
        /// This method takes the 
        /// </summary>
        /// <param name="RoundWinner"></param>
        /// <param name="RoundLoser"></param>
        /// <param name="RoundWinnerChoice"></param>
        /// <param name="RoundLoserChoice"></param>
        /// <returns></returns>
        public static Round RecordRound(Person RoundWinner, Person RoundLoser, Choices? RoundWinnerChoice, Choices? RoundLoserChoice)
        {
            Round r = new Round(RoundWinner, RoundLoser, RoundWinnerChoice, RoundLoserChoice);
            return r;
        }


        /// <summary>
        /// send a string with player fname, lname, and age separated by a space.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Person RegisterPlayer(string x)
        {
            string[] xx = x.Split(' ');

            if (Int32.TryParse(xx[2], out int xx1))
            {
                return new Person(xx[0], xx[1], xx1);
            }
            else
            {
                return new Person(xx[0], xx[1], 111);
            }
        }

        public static Choices GetRandomChoice()
        {
            int c = rand.Next(Choices.GetNames(typeof(Choices)).Length);
            return (Choices)c;
        }

        /// <summary>
        /// send a string R, P, or S, and receive the equivalent Choices type in return.
        /// The method evaluates the first element in the string.
        /// If the char does not correlate, the method returns null
        /// </summary>
        /// <returns></returns>
        public static Choices? ValidateUserInput(string st)
        {
            string st1 = st.ToUpper();
            if (st1 != "")
            {
                if (st1[0].Equals('R')) { return Choices.ROCK; }
                else if (st1[0].Equals('P')) { return Choices.PAPER; }
                else if (st1[0].Equals('S')) { return Choices.SCISSORS; }
            }
            return null;
        }

        /// <summary>
        /// This method takes 2 Choices type arguents and evaluates them to determin a winner
        /// It the result is a tie, returns 0
        /// if the first arg wins, returns 1
        /// if the second arg wind, returns 2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int EvaluateRound(Choices x, Choices? y)
        {
            if ((y == Choices.ROCK && x == Choices.PAPER)
                || (y == Choices.PAPER && x == Choices.SCISSORS)
                || (y == Choices.SCISSORS && x == Choices.ROCK))
            {// computer wins
                return 1;
            }
            else if ((y == Choices.PAPER && x == Choices.ROCK)
                    || (y == Choices.SCISSORS && x == Choices.PAPER)
                    || (y == Choices.ROCK && x == Choices.SCISSORS))
            {// user wins
                return 2;
            }
            else return 0;
        }

        public static Person Login(string fname, string lname)
        {
            Person ret = Repository.Login(fname, lname);
            return ret;
        }
    }
}
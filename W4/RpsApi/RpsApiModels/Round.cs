using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsApiModels
{
    public class Round
    {
        // a constructor is public, it is the same name of the class, it has a body where setup actions are done.
        public Round(Person RoundWinner, Person RoundLoser, Choices? RoundWinnerChoice, Choices? RoundLoserChoice)
        {
            this.RoundDate = DateTime.Now;
            this.RoundWinner = RoundWinner;
            this.RoundLoser = RoundLoser;
            this.RoundWinnerChoice = RoundWinnerChoice;
            this.RoundLoserChoice = RoundLoserChoice;
        }

        public DateTime RoundDate { get; set; }
        public Person RoundWinner { get; set; }
        public Person RoundLoser { get; set; }
        public Choices? RoundWinnerChoice { get; set; }
        public Choices? RoundLoserChoice { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsGame1
{
    public class Game
    {
        public List<Round> Rounds { get; set; } = new List<Round>();
        public DateTime GameDate { get; set; } = DateTime.Now;



        //TODO method to calculate the winner
    }
}
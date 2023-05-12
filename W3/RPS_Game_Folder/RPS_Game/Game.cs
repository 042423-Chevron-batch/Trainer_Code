using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsGame1
{
    public class Game
    {
        public DateTime GameDate { get; set; } = DateTime.Now;
        public List<Round> Rounds { get; set; } = new List<Round>();



        //TODO method to calculate the winner
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpsApiModels
{
    public class Game
    {
        public Guid GameId { get; set; } = Guid.NewGuid();
        public DateTime GameDate { get; set; } = DateTime.Now;
        public List<Round> Rounds { get; set; } = new List<Round>();
        //TODO method to calculate the winner
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class PlayerRound
    {
        public GameRound GameRound { get; set; }
        public Player Player { get; set; }
        public bool In { get; set; }
        public string HoleCard1 { get; set; }
        public string HoleCard2 { get; set; }
        public string HoldCard3 { get; set; }
        public string Option { get; set; }
    }
}

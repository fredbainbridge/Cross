using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class PlayerRound
    {
        GameRound GameRound { get; set; }
        Player Player { get; set; }
        bool In { get; set; }
        public string HoleCard1 { get; set; }
        public string HoleCard2 { get; set; }
        public string HoldCard3 { get; set; }
        public string Option { get; set; }
    }
}

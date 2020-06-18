using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class GameRound
    {
        Game Game { get; set; }
        double PotSize { get; set; }
        public int DeckKey { get; set; }
        public string HiddenCard1 { get; set; }
        public string HiddenCard2 { get; set; }
        public string HiddenCard3 { get; set; }
        public string VisibleCard1 { get; set; }
        public string VisibleCard2 { get; set; }
    }
}

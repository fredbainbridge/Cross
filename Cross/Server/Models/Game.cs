using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class Game
    {
        public double Ante { get; set; }
#nullable enable
        public Player? Winner { get; set; }
        public double WinningAmount { get; set; }
    }
}

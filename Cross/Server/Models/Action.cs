using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cross.Server.Models
{
    public class Action
    {
        PlayerRound PlayerRound {get; set; }
        Player Player { get; set; }

        public double Amount { get; set; }
        public string ActionType { get; set; }

    }
}

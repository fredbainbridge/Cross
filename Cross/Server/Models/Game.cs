﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cross.Server.Models
{
    public class Game
    {
        [Required]
        public double Ante { get; set; }
        [Required]
        public int HoleCards { get; set; }
#nullable enable
        public Player? Winner { get; set; }
        public double WinningAmount { get; set; }
    }
}

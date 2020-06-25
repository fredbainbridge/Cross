using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Cross.Shared
{
    public class Game
    {
        [Required]
        public double Ante { get; set; }
        [Required]
        public int HoleCards { get; set; }
    }
}

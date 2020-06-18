using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cross.Server.Models
{
    public class CrossContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameRound> GameRounds { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRound> PlayerRounds { get; set; }
        public DbSet<Action> Actions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { }
    }

}

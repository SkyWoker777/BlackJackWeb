using BlackJack.DataAccess.Entities;
using System;
using System.Data.Entity;

namespace BlackJack.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(string connectionString) 
            : base(connectionString)
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<PlayerGameSession> PlayerGameSessions { get; set; }
    }
}

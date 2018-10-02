using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BlackJack.DataAccess.Entities;

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

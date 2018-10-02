using BlackJack.DataAccess.Entities;
using BlackJack.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Repositories
{
    public class PlayerRepository: BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext dbContext):
            base(dbContext)
        {

        }
    }
}

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BlackJack.DataAccess
{
    public class DbContextFactory : IDbContextFactory<ApplicationDbContext>
    {

        public ApplicationDbContext Create()
        {
            return new ApplicationDbContext("BlackJackDbConnection");
        }
    }
}

using Autofac;
using BlackJack.DataAccess.Repositories;
using BlackJack.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess
{
    public class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder, string connectionString)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf().WithParameter("connectionString", connectionString);
            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
            builder.RegisterType<CardRepository>().As<ICardRepository>();
            builder.RegisterType<GameSessionRepository>().As<IGameSessionRepository>();
            builder.RegisterType<PlayerGameSessionRepository>().As<IPlayerGameSessionRepository>();
            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>();
        }
    }
}

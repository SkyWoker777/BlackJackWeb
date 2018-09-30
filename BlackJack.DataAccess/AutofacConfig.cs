using Autofac;
using BlackJack.DataAccess.Repositories;
using BlackJack.DataAccess.Repositories.Interfaces;
using System;
namespace BlackJack.DataAccess
{
    public class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder, string connectionString)
        {
            builder.RegisterType<ApplicationDbContext>().AsSelf()
                .WithParameter("connectionString", connectionString);

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>));
            
        }
    }
}

using Autofac;
using BlackJack.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Business
{
    public class AutofacConfig
    {
        public static void Configure(ContainerBuilder builder, string connectionString)
        {
            builder.RegisterType<GameService>().As<IGameService>();
            DataAccess.AutofacConfig.Configure(builder, connectionString);
        }
    }
}

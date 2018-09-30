using Autofac;
using Autofac.Integration.WebApi;
using BlackJack.Business;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace BlackJack.WebApi.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            string connectionString = ConfigurationManager.ConnectionStrings["BlackJackDbConnection"].ConnectionString;

            AutofacConfig.Configure(builder, connectionString);
            Container = builder.Build();

            return Container;
        }

    }
}
using System.Configuration;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DataAcess.Entitites;
using DataAcess.Interfaces;
using DataAcess.Repositories;

namespace Mvc.Util
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<StoreRepository>().As<IRepository<Store>>();
            builder.RegisterType<ProductRepository>().As<IRepository<Product>>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
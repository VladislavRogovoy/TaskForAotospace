using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using DataAcess.Entitites;
using DataAcess.Interfaces;
using DataAcess.Repositories;
using BusinessLogic.Services;
using System.Configuration;

namespace Mvc.Util
{
    public static class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<StoreRepository>().As<IRepository<Store>>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            builder.RegisterType<ProductRepository>().As<IRepository<Product>>().WithParameter("connectionString", ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            //builder.RegisterType<StoreService>().As<StoreService>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
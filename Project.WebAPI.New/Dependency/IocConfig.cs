using Autofac;
using Autofac.Integration.WebApi;
using Project.DAL;
using Project.Repository;
using Project.Repository.Common;
using Project.Repository.Repository;
using Project.Service;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;

namespace Project.WebAPI.New.Dependency
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleMakeRepository>().As<IVehicleMakeRepository>();
            builder.RegisterType<VehicleModelRepository>().As<IVehicleModelRepository>();

            builder.RegisterType<VehicleContext>().InstancePerDependency();

            builder.RegisterGeneric(typeof(VehicleRepository<>))
                    .As(typeof(IVehicleRepository<>))
                    .InstancePerLifetimeScope();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
   
}

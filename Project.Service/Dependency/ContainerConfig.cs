using Autofac;
using Project.Model;
using Project.Model.Common;
using Project.Repository;
using Project.Repository.Common;
using Project.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Project.Service.Dependency
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(Project.Repository))) // GLUPA SAM, ovo nece ici, nisu mi u istom projektu, mozda ima neka fora da upali ali necemo sad to
            //    .Where(t => t.Namespace.Contains("Repository"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => t.Name == "I" + t.Name));


            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>().InstancePerLifetimeScope();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>().InstancePerLifetimeScope();

            builder.RegisterType<VehicleRepository<VehicleMake>>().As<IVehicleRepository<IVehicleMake>>();
            builder.RegisterType<VehicleRepository<VehicleModel>>().As<IVehicleRepository<IVehicleModel>>();


            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(VehicleRepository<>))
           .As(typeof(IVehicleRepository<>))
           .InstancePerLifetimeScope();

            return builder.Build(); // Bilda container; COntainer je mjesto na kojemu je spremljena definicija liste razlicitih klasa koje zelimo instancirati
        }
    }
}

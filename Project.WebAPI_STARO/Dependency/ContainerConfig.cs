using Autofac;
using Project.Model;
using Project.Model.Common;
using Project.Repository;
using Project.Repository.Common;
using Project.Service;
using Project.Service.Common;
//using Service.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.WebAPI.Dependency
{
    public static class ContainerConfig
    {

        public static IContainer Configure()
        {
            //base.Load(builder); 

            //builder.RegisterType<VehicleModelService>().As<IVehicleModelService>().InstancePerLifetimeScope();
            //builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>().InstancePerLifetimeScope();

            var builder = new ContainerBuilder();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            //builder.registertype<unitofwork>().as< iunitofwork > ().instanceperlifetimescope();

            builder.RegisterGeneric(typeof(VehicleRepository<>))
           .As(typeof(IVehicleRepository<>))
           .InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}

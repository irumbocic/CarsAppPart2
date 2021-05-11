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
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //base.Load(builder); 

            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>().InstancePerLifetimeScope();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>().InstancePerLifetimeScope();


            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();

            builder.RegisterType<IVehicleRepository<VehicleMake>>().As<IVehicleRepository<IVehicleMake>>();
            builder.RegisterType<IVehicleRepository<VehicleModel>>().As<IVehicleRepository<IVehicleModel>>();



            //builder.registertype<unitofwork>().as< iunitofwork > ().instanceperlifetimescope();

            ////// builder.RegisterGeneric(typeof(VehicleRepository<>))
            //////.As(typeof(IVehicleRepository<>))
            //////.InstancePerLifetimeScope();
        }
    }
}

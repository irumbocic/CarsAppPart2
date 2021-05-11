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


            ////// //builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            ////// //builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();

            //builder.RegisterType<VehicleRepository<VehicleMake>>().As<IVehicleRepository<IVehicleMake>>();
            //builder.RegisterType<VehicleRepository<VehicleModel>>().As<IVehicleRepository<IVehicleModel>>();



            ////// builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            ////// builder.RegisterGeneric(typeof(VehicleRepository<>))
            //////.As(typeof(IVehicleRepository<>))
            //////.InstancePerLifetimeScope();
        }
    }
}

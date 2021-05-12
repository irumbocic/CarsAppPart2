using Autofac;
using Autofac.Integration.WebApi;
using Project.DAL;
using Project.Model;
using Project.Model.Common;
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
using Module = Autofac.Module;

namespace Project.WebAPI.Dependency
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //    var builder = new ContainerBuilder();
            //    var config = new HttpConfiguration();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<VehicleModelService>().As<IVehicleModelService>();
            builder.RegisterType<VehicleMakeService>().As<IVehicleMakeService>();
            builder.RegisterType<VehicleMakeRepository>().As<IVehicleMakeRepository>();
            builder.RegisterType<VehicleModelRepository>().As<IVehicleModelRepository>();


            builder.RegisterType<VehicleContext>().InstancePerDependency();

            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope(); // OBRISALA SAM UNITY zasad

            //builder.RegisterType<VehicleRepository<VehicleMake>>().As<IVehicleRepository<IVehicleMake>>();

            //builder.RegisterType<VehicleRepository<VehicleModel>>().As<IVehicleRepository<IVehicleModel>>();

            builder.RegisterGeneric(typeof(VehicleRepository<>))
                    .As(typeof(IVehicleRepository<>))
                    .InstancePerLifetimeScope();

            //var container = builder.Build();
            //config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            //var resolver = new AutofacWebApiDependencyResolver(container); 
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); // OVO JE ZA MVC; ja moram za WEB API
            //GlobalConfiguration.Configuration.DependencyResolver = resolver;



        }
    }
}

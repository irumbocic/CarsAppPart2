//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model;
using Project.DAL;
using Project.Model.Common;

namespace Project.Service.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<VehicleModelEntity, VehicleModel>()
                .ReverseMap();
            CreateMap<VehicleModelEntity,IVehicleModel>()
              .ReverseMap();
            CreateMap<VehicleModel, IVehicleModel>()
              .ReverseMap();
        }
    }
}

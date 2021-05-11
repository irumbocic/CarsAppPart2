//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model;

namespace Project.Service.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Project.DAL.VehicleModel, Project.Model.VehicleModel>()
                .ReverseMap();
            CreateMap<Project.DAL.VehicleModel, Project.Model.Common.IVehicleModel>()
              .ReverseMap();
            CreateMap<Project.Model.VehicleModel, Project.Model.Common.IVehicleModel>()
              .ReverseMap();
        }
    }
}

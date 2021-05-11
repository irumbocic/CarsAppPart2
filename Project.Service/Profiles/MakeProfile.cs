//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model;
using Project.Model.Common;

namespace Project.Service.Profiles
{
    public class MakeProfile : Profile
    {
        public MakeProfile()
        {
            CreateMap<Project.DAL.VehicleMake, Project.Model.VehicleMake>()
               .ReverseMap();
            CreateMap<Project.DAL.VehicleMake, Project.Model.Common.IVehicleMake>()
              .ReverseMap();
            CreateMap<Project.Model.VehicleMake, Project.Model.Common.IVehicleMake > ()
              .ReverseMap();
        }
    }
}

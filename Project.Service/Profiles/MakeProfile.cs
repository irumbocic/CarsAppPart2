//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Project.Model;
using Project.Model.Common;
using Project.DAL;

namespace Project.Service.Profiles
{
    public class MakeProfile : Profile
    {
        public MakeProfile()
        {
            CreateMap<VehicleMakeEntity, VehicleMake>()
               .ReverseMap();
            CreateMap<VehicleMakeEntity, IVehicleMake>()
              .ReverseMap();
            CreateMap<VehicleMake, IVehicleMake > ()
              .ReverseMap();
        }
    }
}

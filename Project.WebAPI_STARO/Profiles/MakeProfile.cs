//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.WebAPI.Dto;
using AutoMapper;
using Project.Model;
using Project.Model.Common;

namespace Project.WebAPI.Profiles
{
    public class MakeProfile : Profile
    {
        public MakeProfile()
        {
            CreateMap<IVehicleMake, VehicleMakeDto>()
               .ReverseMap();
        }
    }
}

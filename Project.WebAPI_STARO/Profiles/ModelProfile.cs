//using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.WebAPI.Dto;
using AutoMapper;
using Project.Model;

namespace Project.WebAPI.Profiles
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<VehicleModel, VehicleModelDto>()
              .ReverseMap();
        }
    }
}

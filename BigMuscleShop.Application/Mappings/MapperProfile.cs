using AutoMapper;
using BigMuscleShop.Application.Dtos.UserDtos;
using BigMuscleShop.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMuscleShop.Application.Mappings
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ApplicationUser, RegisterDto>();
        }
    }
}

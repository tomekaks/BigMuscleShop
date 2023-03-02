using AutoMapper;
using BigMuscleShop.Application.Dtos.Product;
using BigMuscleShop.Application.Dtos.User;
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

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}

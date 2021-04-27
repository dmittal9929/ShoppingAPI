using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopping.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Product, Models.ProductsDTO>();
            CreateMap<Models.ProductCreatingDTO, Entities.Product>();
            CreateMap<Models.TagProductionDTO, Entities.Tags>();
        }
        
    }
}

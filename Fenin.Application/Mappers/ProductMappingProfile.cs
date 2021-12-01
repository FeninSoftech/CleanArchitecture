using AutoMapper;
using Fenin.Application.Commands;
using Fenin.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fenin.Application.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Fenin.Core.Entities.Product, ProductResponse>().ReverseMap();
            CreateMap<Fenin.Core.Entities.Product, CreateProductCommand>().ReverseMap();
        }
    }
}

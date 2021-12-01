using AutoMapper;
using Fenin.Application.Commands;
using Fenin.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fenin.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, CreateProductCommand>();
        }
    }
}

using AutoMapper;
using ComponentProcessing.Models;
using ComponentProcessing.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentProcessing.CPMappers
{
    public class CPMapppings : Profile
    {
        public CPMapppings()
        {
            CreateMap<ComponentProcessingModel, ComponentProcessingModelDto>().ReverseMap();
            CreateMap<ComponentProcessingModel, CreateDto>().ReverseMap();
            CreateMap<ComponentProcessingModel, UpdateDto>().ReverseMap();
        }
    }
}

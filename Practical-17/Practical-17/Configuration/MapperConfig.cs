using AutoMapper;
using Practical_17.Data;
using Practical_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Student, StudentViewModel>().ReverseMap();
        }
    }
}

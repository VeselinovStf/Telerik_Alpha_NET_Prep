using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversitySystem.StudentServices.DTOs;
using UniversitySystem.Web.ViewModels.Student;

namespace UniversitySystem.Web.Utilities.AutoMapperConfigurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<StudentDto, StudentViewModel>();
            CreateMap<StudentListDto, StudentListViewModel>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using ELearning.Api.Dtos;
using ELearning.Entities;

namespace ELearning.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterDto, User>();
            CreateMap<User, UserLoginDto>();

            CreateMap<Student, GetStudentDto>();
        }
    }
}

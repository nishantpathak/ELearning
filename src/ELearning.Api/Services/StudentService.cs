using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using ELearning.Api.Data;
using ELearning.Api.Dtos;
using ELearning.Entities;

using Microsoft.EntityFrameworkCore;

namespace ELearning.Api.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMapper mapper;
        private readonly DataContext context;

        public StudentService(IMapper mapper, DataContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<ServiceResponse<List<GetStudentDto>>> GetAllStudents()
        {
            ServiceResponse<List<GetStudentDto>> serviceResponse = new ServiceResponse<List<GetStudentDto>>();

            try
            {
                List<Student> dbStudents = await context.Students.ToListAsync();

                serviceResponse.Message = dbStudents.Count == 0 ? "No Records Available." : string.Format("Total {0} Records.", dbStudents.Count());
                serviceResponse.Data = dbStudents.Select(db => mapper.Map<GetStudentDto>(db)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;

            }

            return serviceResponse;
        }
    }
}

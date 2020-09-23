using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ELearning.Api.Dtos;

namespace ELearning.Api.Services
{
    public interface IStudentService
    {
        Task<ServiceResponse<List<GetStudentDto>>> GetAllStudents();
    }
}

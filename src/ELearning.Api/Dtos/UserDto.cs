using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Api.Dtos
{
    public class UserRegisterDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }


    public class UserLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

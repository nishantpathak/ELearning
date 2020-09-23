using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning
{
    public class ServiceResponse
    {
        public string Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = null;
    }
}

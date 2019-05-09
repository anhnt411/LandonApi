using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandonAPI.Models
{
    public class ApiError
    {
        public ApiError() { }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}

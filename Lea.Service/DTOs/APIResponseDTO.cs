using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lea.Service.DTOs
{
    public class APIResponseDto<T>
    {
        public required int StatusCode { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
    }
    
}

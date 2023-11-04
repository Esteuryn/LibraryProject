using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Application.Core
{
    namespace Library.Application.Core
    {
        public class ServiceResult
        {
            public ServiceResult()
            {
                Success = true;
            }

            public bool Success { get; set; }
            public string? Message { get; set; }
            public dynamic? Data { get; set; }
        }
    }

}

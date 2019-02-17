using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Core
{
    public class ApiException : Exception
    {
        public int StatusCode { get; set; }

        public bool IsExpired { get; set; }
        public ApiException(string message,
                            int statusCode = 500) :
            base(message)
        {
            StatusCode = statusCode;
        }
        public ApiException(Exception ex, int statusCode = 500) : base(ex.Message)
        {
            StatusCode = statusCode;
        }
    }
}
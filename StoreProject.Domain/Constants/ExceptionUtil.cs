using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StoreProject.Domain.Constants
{
    public class ExceptionUtil
    {
        public struct ResponseHeaders
        {
            public const string TOKEN_EXPIRED = "Token-Expired";
        }
    }

    public class ErrorDetails
    {
        public string Message { get; set; }
        public string? Title { get; set; }
        public Object? Details { get; set; }

        public ErrorDetails()
        {
            Title = "";
            Message = "";
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
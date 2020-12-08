using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IvendMpesaApi
{
    public class ExecutionResult
    {

        public bool IsOkay { get; set; }

        public string Message { get; set; }

        public object Result
        {
            get;
            set;
        }

        public ExecutionResult()
        {

        }

        public ExecutionResult(bool isokay)
        {
            IsOkay = isokay;
        }

        public ExecutionResult(bool isokay, string message) : this(isokay)
        {
            Message = message;
        }

        public ExecutionResult(bool isOkay, string message, object result) : this(isOkay, message)
        {
            Result = result;
        }
    }
}
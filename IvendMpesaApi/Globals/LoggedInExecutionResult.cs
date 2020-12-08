using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals
{
    public class LoggedInExecutionResult<T>
    {
        public T Result { get; set; }
        public string ModuleName { get; set; }
        public LoggedInExecutionResult(T _result, string _moduleName)
        {
            Result = _result;
            ModuleName = _moduleName;
        }
        public LoggedInExecutionResult()
        {

        }
    }
}

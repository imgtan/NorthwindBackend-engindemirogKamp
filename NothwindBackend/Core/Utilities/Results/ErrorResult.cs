using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(success:false)
        {
        }

        public ErrorResult(string message) : base(success:false, message)
        {
        }
    }
}

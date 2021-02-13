using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<P> : DataResult<P>
    {
        public ErrorDataResult(P data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(P data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
        public ErrorDataResult() : base(default, true)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<P> : Result, IDataResult<P>
    {
        public DataResult(P data, bool success, string message) : base(success, message)
        {

        }
        public DataResult(P data, bool success) : base(success)
        {
            Data = data;
        }
        public P Data { get; }
    }
}

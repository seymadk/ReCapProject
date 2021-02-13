using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<P> : IResult
    {
        P Data { get; }

    }
}

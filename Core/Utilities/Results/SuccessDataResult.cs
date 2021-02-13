﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<P> : DataResult<P>
    {
        public SuccessDataResult(P data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(P data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}

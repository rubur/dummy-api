﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dummyAPI.Application
{
    public class AlreadyExistsError : OperationResultError
    {
        public AlreadyExistsError(string message) : base(message)
        {
        }
    }
}

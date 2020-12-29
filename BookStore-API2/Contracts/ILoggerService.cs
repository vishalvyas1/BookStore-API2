﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API2.Contracts
{
    public interface ILoggerService
    {
        void LogInfo(string message);
        void LogDebug(string message);
        void LogWarn(string message);
        void LogError(string message);


    }
}

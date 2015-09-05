﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es.Logging
{
    public class Log4LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string name) {
            return new Log4(log4net.LogManager.GetLogger(name));
        }

        public void Dispose() {
            log4net.LogManager.Shutdown();
        }
    }
}
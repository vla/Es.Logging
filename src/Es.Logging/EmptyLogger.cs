﻿using System;

namespace Es.Logging
{
    /// <summary>
    /// Used to take
    /// </summary>
    internal class EmptyLogger : ILogger
    {
        internal static EmptyLogger Instance = new EmptyLogger();

        /// <summary>
        /// nothing
        /// </summary>
        /// <param name="logLevel"></param>
        /// <returns></returns>
        public bool IsEnabled(LogLevel logLevel) {
            return true;
        }

        /// <summary>
        /// nothing
        /// </summary>
        /// <param name="logLevel"></param>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Log(LogLevel logLevel, string message, Exception exception) {
        }
    }
}
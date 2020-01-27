﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AutomaticRatingMechanism.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}

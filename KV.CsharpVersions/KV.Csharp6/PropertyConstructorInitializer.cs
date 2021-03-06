﻿using System;

namespace KV.Csharp6
{
    public static class PropertyConstructorInitializer
    {
        public static void Execute()
        {
            LogMessage2 log = new LogMessage2();            
        }
    }   

    public class LogMessage2
    {
        public DateTime Date { get; }
        public LogType Type { get; set; }
        public string Message { get; set; }

        public LogMessage2()
        {
            Date = DateTime.Now;
            Type = LogType.Information;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MaesJarno.Models
{
    public static class LoggerService
    {
        private static LogMessage[] Logs;
        public static LogMessage[] logs
        {
            get { return Logs; }
            set { Logs = value; }
        }
        static LoggerService()
        {
            logs = new LogMessage[0];
        }

        public static void AddLog(LogMessage boodschap)
        {
            Array.Resize(ref Logs, Logs.Length + 1);
            Logs[Logs.Length - 1] = boodschap;
        }            
    }
}

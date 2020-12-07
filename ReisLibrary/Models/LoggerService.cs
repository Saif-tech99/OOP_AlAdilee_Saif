using System;

namespace ReisLibrary.Models
{
    public static class LoggerService 
    {
        private static LogMessage[] logs;
        public static int size = 0;
        public static LogMessage Logs { get; set; }


        static LoggerService()
        {
            logs = new LogMessage[0];
        }

        public static void AddLogMessage(LogMessage message)
        {
            size++;
            Array.Resize(ref logs, size);
        }

    }
}

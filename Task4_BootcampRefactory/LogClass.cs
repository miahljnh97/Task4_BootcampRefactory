using System;
using System.Collections.Generic;
using System.IO;

namespace Task4_BootcampRefactory
{
    public class LogClass
    {
        public interface ILog
        {
            DateTime Date { get; set; }
            string Message { get; set; }
        }
        public static class Log1
        {
            public static List<Log> errorLog = new List<Log>();
            public static void SaveAllLog()
            {
                var lines = new List<string>();
                foreach (var X in errorLog)
                {
                    lines.Add($"{X.Date} INFO: {X.Message}");
                }
                File.WriteAllLines(@"/Users/user/Projects/Task4_BootcampRefactory/Task4_BootcampRefactory/App.log", lines);
            }
            public static void PopulateLog(string msg)
            {
                DateTime date = DateTime.Now;
                errorLog.Add(new Log { Date = date, Message = msg });
            }
        }
        public class Log : ILog
        {
            public DateTime Date { get; set; }
            public string Message { get; set; }
        }
    }
}

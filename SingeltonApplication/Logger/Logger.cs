using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace SingeltonApplication.Logger
{
    public sealed class Logger : Ilog
    {
        private static Lazy<Logger> Instance = new Lazy<Logger>(() => new Logger());

        public static Logger GetInstance
        {
            get
            {
                return Instance.Value;
            }
        }

        private Logger()
        {

        }

        public void LogException(string Message)
        {
            string logFilePath = string.Format(@"C:\\Exception.txt");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(Message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}

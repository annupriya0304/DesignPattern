using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace AbstractDesignPattern.Logger
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



        public void LogException(string message)
        {
            string filePath = "@C:\\Exception.txt";
            StringBuilder sb = new StringBuilder();
            sb.Append("*************************************");
            sb.Append(DateTime.Now.ToString());
            sb.Append(message.ToString());

              using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.Write(sb);
                sw.Flush();
            }
        }
    }
}
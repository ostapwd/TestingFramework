using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingFramework.Tools
{
    public class Logger
    {
        private static StringBuilder sb = new StringBuilder();

        public static void Add(string text)
        {
            sb.Append(Thread.CurrentThread.ManagedThreadId + " - " + text + "\n");
        }

        public static void WriteToFile()
        {
            string path = Config.GetRootDir() + "\\ThreadsLogs.txt";
            Config.WriteTextToFile(path, sb.ToString());
        }
    }
}

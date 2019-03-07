using System;
using System.IO;
using System.Reflection;

namespace TestingFramework.Tools
{
    public static class Config
    {
        /// <summary>
        /// Gets path to project base root from environment where tests are run.
        /// </summary>
        /// <returns>Path to project base root.</returns>
        public static string GetRootDir()
        {
            var uri = new UriBuilder(Assembly.GetExecutingAssembly().CodeBase);

            var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path))
                .Replace("\\TestingFramework\\bin\\Debug", "")
                .Replace("/TestingFramework/bin/Debug", "");

            return path;
        }

        public static void WriteLogs(string logs)
        {
            string path = Config.GetRootDir() + "\\logs.txt";
            Config.WriteTextToFile(path, logs);
        }

        public static void WriteTextToFile(string pathToFile, string dataToWrite)
        {
            File.WriteAllText(pathToFile, dataToWrite);
        }
    }
}

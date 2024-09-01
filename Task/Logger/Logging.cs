using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestTask.Logger
{
    public static class Logging
    {
        private static readonly string logFilePath = ConfigurationManager.AppSettings["LogFile"]?.ToString();

        // Lock object for thread safety
        private static readonly object lockObj = new object();

        public static void LogInfo(string message)
        {
            Log("INFO", message);
        }

        public static void LogError(string message)
        {
            Log("ERROR", message);
        }

        private static void Log(string logType, string message)
        {
            // Ensure thread safety
            lock (lockObj)
            {
                try
                {
                    RotateLogFile();
                    using (StreamWriter writer = new StreamWriter(logFilePath, true))
                    {
                        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logType}] {message}";
                        writer.WriteLine(logEntry);
                    }
                }
                catch (Exception ex)
                {
                }
            }

        }
        private static void RotateLogFile()
        {
            const long maxSizeInBytes = 5 * 1024 * 1024; // 5 MB

            if (File.Exists(logFilePath) && new FileInfo(logFilePath).Length > maxSizeInBytes)
            {
                string archivePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"application_{DateTime.Now:yyyyMMddHHmmss}.log");
                File.Move(logFilePath, archivePath);
            }
        }
    }
}

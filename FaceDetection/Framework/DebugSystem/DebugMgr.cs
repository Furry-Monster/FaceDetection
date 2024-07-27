using System;
using System.IO;

namespace FaceDetection.Framework.DebugSystem
{
    public static class Debug
    {
        public static void Log(string message)
        {
            DebugMgr.Instance.Log(message);
        }

        public static void LogError(string message)
        {
            DebugMgr.Instance.LogError(message);
        }

        public static void LogWarning(string message)
        {
            DebugMgr.Instance.LogWarning(message);
        }

        public static void LogException(Exception ex, string message = null, bool isFatal = false)
        {
            DebugMgr.Instance.LogException(ex, message, isFatal);
        }
    }

    internal class DebugMgr
    {
        private string _logFilePath = "../Logs/DebugLog.txt";

        public static DebugMgr Instance { get; private set; }
        public DebugMgr()
        {
            if (Instance != null)
            {
                throw new InvalidOperationException("DebugMgr is a singleton class. It cannot be instantiated more than once.");
            }

            Instance = this;
        }

        public void Write(string message, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message);
            }
        }

        public void Log(string message)
        {
            Write("Log: " + message + "\n", _logFilePath);
        }

        public void LogError(string message)
        {
            Write("Error: " + message + "\n", _logFilePath);
        }

        public void LogWarning(string message)
        {
            Write("Warning: " + message + "\n", _logFilePath);
        }

        public void LogException(Exception ex, string message = null, bool isFatal = false)
        {
            Write("Exception: " + ex.Message + "\n" + "\t" + message + "\n", _logFilePath);
        }

        public void ClearLog()
        {
            File.WriteAllText(_logFilePath, "");
        }
    }
}

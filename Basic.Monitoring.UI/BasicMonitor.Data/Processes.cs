using System.Diagnostics;

namespace BasicMonitor.Data
{
    public static class Processes
    {
        public static Process[] GetRunningProcesses()
        {
            return Process.GetProcesses();
        }

        public static int GetRunningProcessesCount()
        {
            return GetRunningProcesses().Length;
        }
    }
}

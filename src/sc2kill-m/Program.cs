using System.Diagnostics;
using System.Linq;

namespace sc2kill
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = Process.GetProcesses().FirstOrDefault(x => x.ProcessName.Contains("SC2_x64"));
            if (process != null)
                process.Kill();
        }
    }
}

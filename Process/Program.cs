using Process.Process;
using Process.Process.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager manager = new ProcessManager(new List<AbstractProcess>() { new SalesProcess() });
            manager.StartProcesses();
            Console.ReadLine();
        }
    }
}

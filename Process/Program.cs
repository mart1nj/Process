using Process.Process;
using Process.Process.Process;
using System;
using System.Collections.Generic;

namespace Process
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager manager = new ProcessManager(new List<AbstractProcess>() { new SalesProcess() });
            manager.StartProcesses("Consumer Karen", "Provider Susan");
            Console.ReadLine();
        }
    }
}

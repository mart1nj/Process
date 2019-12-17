using System.Collections.Generic;
using Process.Process.Process;

namespace Process.Process
{
	public class ProcessManager {

		List<AbstractProcess> processes;

		public ProcessManager(List<AbstractProcess> processes){
            this.processes = processes;
		}

        public void StartProcesses(string consumer, string provider)
        {
            foreach(AbstractProcess process in processes)
            {
                process.DoTasks(consumer, provider);
            }
        }

        public List<AbstractProcess> GetProcesses()
        {
            return processes;
        }
	}
}
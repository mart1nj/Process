using System.Collections.Generic;
using Process.Process.Process;

namespace Process.Process
{
	public class ProcessManager {

		private List<AbstractProcess> processes;

		public ProcessManager(List<AbstractProcess> processes){
            this.processes = processes;
		}

        public void StartProcesses()
        {
            foreach(AbstractProcess process in processes)
            {
                process.doTasks();
            }
        }
	}
}
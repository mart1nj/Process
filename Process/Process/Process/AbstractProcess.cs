using Process.Process.Party;
using Process.Process.Tasks;
using System.Collections.Generic;

namespace Process.Process.Process
{
    public abstract class AbstractProcess {
        public AbstractProcess()
        {
            Tasks = new List<Task>();
            DefineTasks();
        }

        public abstract void DefineTasks();

        public void DoTasks()
        {
            foreach(Task task in Tasks)
            {
                task.DoTask();
            }
        }

        public Role Role { get; } = Role.Manager;

        public List<Task> Tasks { get; }
    }
}

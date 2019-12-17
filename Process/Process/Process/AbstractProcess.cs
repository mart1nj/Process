using Process.Process.Party;
using Process.Process.Tasks;
using System.Collections.Generic;

namespace Process.Process.Process
{
    public abstract class AbstractProcess {
        private List<Task> tasks;
        private Role role = Role.Manager;

        public AbstractProcess()
        {
            tasks = new List<Task>();
            defineTasks();
        }

        public abstract void defineTasks();

        public void doTasks()
        {
            foreach(Task task in tasks)
            {
                task.DoTask();
            }
        }

        public Role Role
        {
            get
            {
                return role;
            }
        }

        public List<Task> Tasks
        {
            get
            {
                return tasks;
            }
        }
    }
}

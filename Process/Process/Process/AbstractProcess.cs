using Process.Process.Party;
using Process.Process.Tasks;
using System.Collections.Generic;

namespace Process.Process.Process
{
    public abstract class AbstractProcess
    {
        private readonly Role role;

        public AbstractProcess()
        {
            Tasks = new List<Task>();
            DefineTasks();
            role = new Role();
            role.SetName("Manager");
        }

        public abstract void DefineTasks();

        public void DoTasks(string consumer, string provider)
        {
            foreach (Task task in Tasks)
            {
                task.DoTask(consumer, provider);
            }
        }
        public Role GetRole()
        {
            return role;
        }
        public List<Task> Tasks { get; }
    }
}

using Process.Process.Tasks;

namespace Process.Process.Process
{
    public class SalesProcess : AbstractProcess
    {
        public override void DefineTasks()
        {
            Tasks.Add(new GreetCustomerTask());
            Tasks.Add(new RegisterProductTask());
            Tasks.Add(new ReceiveMoneyTask());
            Tasks.Add(new GiveProductTask());
        }
    }
}
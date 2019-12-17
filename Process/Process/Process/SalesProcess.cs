using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Process.Process.Tasks;
using Process.Process.Party;

namespace Process.Process.Process
{
    public class SalesProcess : AbstractProcess
    {
        public override void defineTasks()
        {
            Tasks.Add(new GreetCustomerTask());
            Tasks.Add(new RegisterProductTask());
            Tasks.Add(new ReceiveMoneyTask());
            Tasks.Add(new GiveProductTask());
        }
    }
}
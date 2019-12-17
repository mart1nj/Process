using System;

namespace Process.Process.Tasks
{
    public class GreetCustomerTask : Task {
        public override void DoTask() {
            Console.WriteLine("Customer has been greeted. ");
        }
    }
}

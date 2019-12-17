using System;

namespace Process.Process.Tasks
{
    public class GreetCustomerTask : Task {
        public override void DoTask(string consumer, string provider) {
            base.DoTask(consumer, provider);
            Console.WriteLine("{0} has been greeted by {1}. ", GetConsumer().GetName(), GetProvider().GetName());
        }
    }
}

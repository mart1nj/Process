using System;

namespace Process.Process.Tasks {
    public class RegisterProductTask : Task {
        public override void DoTask(string consumer, string provider) {
            base.DoTask(consumer, provider);
            Console.WriteLine("The product {0} wishes to buy has been registered through the system by {1}. ", GetConsumer().GetName(), GetProvider().GetName());
            GetOutcomes().Add(new Outcome("Product registered through system. "));
        }
    }
}

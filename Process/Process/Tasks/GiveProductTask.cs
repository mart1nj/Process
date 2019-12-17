using System;

namespace Process.Process.Tasks {
    public class GiveProductTask : Task {
        public override void DoTask(string consumer, string provider) {
            base.DoTask(consumer, provider);
            Console.WriteLine("{0} has given the product to the {1}. ", GetProvider().GetName(), GetConsumer().GetName());
            GetOutcomes().Add(new Outcome("Product sold. "));

        }
    }
}

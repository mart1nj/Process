using System;

namespace Process.Process.Tasks {
    public class ReceiveMoneyTask : Task {
        public override void DoTask(string consumer, string provider) {
            base.DoTask(consumer, provider);
            Console.WriteLine("{0} has given money and {1} has given back change. ", GetConsumer().GetName(), GetProvider().GetName());
            GetOutcomes().Add(new Outcome("Money received. "));
            GetOutcomes().Add(new Outcome("Change given. "));
        }
    }
}

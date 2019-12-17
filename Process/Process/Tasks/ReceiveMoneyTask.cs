using System;

namespace Process.Process.Tasks {
    public class ReceiveMoneyTask : Task {
        public override void DoTask() {
            Console.WriteLine("Customer has given money and we've given back change. ");
            Outcomes.Add(new Outcome("Money received. "));
            Outcomes.Add(new Outcome("Change given. "));
        }
    }
}

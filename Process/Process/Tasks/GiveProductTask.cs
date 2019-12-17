using System;

namespace Process.Process.Tasks {
    public class GiveProductTask : Task {
        public override void DoTask() {
            Console.WriteLine("We've given the product to the customer. ");
            Outcomes.Add(new Outcome("Product sold. "));
        }
    }
}

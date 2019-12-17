using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process.Process.Tasks
{
    public class RegisterProductTask : Task
    {
        public override void DoTask()
        {
            Console.WriteLine("The product the customer wishes to buy has been registered through the system. ");
            Outcomes.Add(new Outcome("Product registered through system. "));
        }
    }
}

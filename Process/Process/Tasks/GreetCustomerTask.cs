using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process.Process.Tasks
{
    public class GreetCustomerTask : Task {
        public override void DoTask()
        {
            Console.WriteLine("Customer has been greeted. ");
        }
    }
}

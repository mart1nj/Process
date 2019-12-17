using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Process.Process;
using Process.Process.Party;
using Process.Process.Process;
using Process.Process.Tasks;

namespace ProcessTests
{
    [TestClass]
    public class ProcessUnitTest
    {
        public ProcessManager manager;
        public AbstractProcess process;
        public string consumer = "";
        public string provider = "";
        public Outcome productSold;
        public Outcome productRegistered;
        public Outcome moneyReceived;
        public Outcome changeGiven;
        public Task task;


        [TestInitialize]
        public void Initialize()
        {
            manager = new ProcessManager(new List<AbstractProcess>() { new SalesProcess() });
            process = manager.GetProcesses().FirstOrDefault();
            consumer = "Consumer Karen";
            provider = "Provider Susan";
            productSold = new Outcome("Product sold. ");
            productRegistered = new Outcome("Product registered through system. ");
            moneyReceived = new Outcome("Money received. ");
            changeGiven = new Outcome("Change given. ");
        }

        [TestMethod]
        public void TestProcess()
        {
            Assert.IsNotNull(manager.GetProcesses());
            Assert.IsNotNull(process.GetRole());
            Assert.IsNotNull(process.Tasks);
            Assert.AreEqual("Manager", process.GetRole().GetName());
            Assert.AreEqual(4, process.Tasks.Count);

        }

        [TestMethod]
        public void TestTasks()
        {
            task = process.Tasks.FirstOrDefault();
            Assert.IsNotNull(task.GetOutcomes());
            Assert.AreEqual(RelationshipType.SalesRelationship, task.GetRelationshipType());
            task.DoTask(consumer, provider);
            Assert.IsNotNull(task.GetConsumer());
            Assert.IsNotNull(task.GetProvider());
            Assert.AreEqual("Consumer Karen", task.GetConsumer().GetName());
            Assert.AreEqual("Provider Susan", task.GetProvider().GetName());


        }

        [TestMethod]
        public void TestGreetCustomerTask()
        {
            testTasksNotNullAndCount();
            task = process.Tasks[0];
            Assert.IsInstanceOfType(task, typeof(GreetCustomerTask));
            task.DoTask(consumer, provider);
            Assert.IsNotNull(task.GetConsumer());
            Assert.IsNotNull(task.GetProvider());
            Assert.AreEqual("Consumer Karen", task.GetConsumer().GetName());
            Assert.AreEqual("Provider Susan", task.GetProvider().GetName());

            var outcomes = task.GetOutcomes();
            Assert.AreEqual(0, outcomes.Count);


        }
        [TestMethod]
        public void TestRegisterProductTask()
        {
            testTasksNotNullAndCount();
            task = process.Tasks[1];
            Assert.IsInstanceOfType(task, typeof(RegisterProductTask));
            task.DoTask(consumer, provider);
            Assert.IsNotNull(task.GetConsumer());
            Assert.IsNotNull(task.GetProvider());
            Assert.AreEqual("Consumer Karen", task.GetConsumer().GetName());
            Assert.AreEqual("Provider Susan", task.GetProvider().GetName());
            var outcomes = task.GetOutcomes();
            Assert.AreEqual(1, outcomes.Count);
            Assert.AreEqual(outcomes.FirstOrDefault().Value, productRegistered.Value);

        }
        [TestMethod]
        public void TestReceiveMoneyTask()
        {
            testTasksNotNullAndCount();
            task = process.Tasks[2];
            Assert.IsInstanceOfType(task, typeof(ReceiveMoneyTask));
            task.DoTask(consumer, provider);
            Assert.IsNotNull(task.GetConsumer());
            Assert.IsNotNull(task.GetProvider());
            Assert.AreEqual("Consumer Karen", task.GetConsumer().GetName());
            Assert.AreEqual("Provider Susan", task.GetProvider().GetName());
            var outcomes = task.GetOutcomes();
            Assert.AreEqual(2, outcomes.Count);
            Assert.AreEqual(outcomes[0].Value, moneyReceived.Value);
            Assert.AreEqual(outcomes[1].Value, changeGiven.Value);
        }
        [TestMethod]
        public void TestGiveProductTask()
        {
            testTasksNotNullAndCount();
            task = process.Tasks[3];
            Assert.IsInstanceOfType(task, typeof(GiveProductTask));
            task.DoTask(consumer, provider);
            Assert.IsNotNull(task.GetConsumer());
            Assert.IsNotNull(task.GetProvider());
            Assert.AreEqual("Consumer Karen", task.GetConsumer().GetName());
            Assert.AreEqual("Provider Susan", task.GetProvider().GetName());
            var outcomes = task.GetOutcomes();
            Assert.AreEqual(1, outcomes.Count);
            Assert.AreEqual(outcomes[0].Value, productSold.Value);


        }

        [TestMethod]
        public void testTasksNotNullAndCount()
        {
            Assert.IsNotNull(process.Tasks);
            Assert.AreEqual(4, process.Tasks.Count);

        }




    }
}

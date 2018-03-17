using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication1;

namespace TestClassLib
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestCase1()
        {
            Task task = new Task(AsyncAwaitReadFile.callMethodAsync);
            task.Start();
            task.Wait();
        }
    }
}

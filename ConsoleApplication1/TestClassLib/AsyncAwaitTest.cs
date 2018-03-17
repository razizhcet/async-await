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
    class AsyncAwaitTest
    {
        [Test]
        public void Test1()
        {
            AsyncAwait.Method1Async();
            AsyncAwait.Method2();
        }
    }
}

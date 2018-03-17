using System;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// class to call methods Asynchronously with the use of async and await keyword
    /// T:ConsoleApplication1.AsyncAwait1
    /// </summary>
    public class AsyncAwait1
    {
        /// <summary>
        /// statement for using functions of log4net
        /// F:ConsoleApplication1.AsyncAwait1.log
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(AsyncAwait1));

        /// <summary>
        /// main method for calling callMethodAsync()
        /// M:ConsoleApplication1.AsyncAwait1.Main(System.String[])
        /// </summary>
        /// <param name="args">string array type parameter.</param>
        /// <returns>return type is void.</returns>
        static void Main(string[] args)
        {
            callMethodAsync();
            Console.ReadKey();
        }
        /// <summary>
        /// callMethodAsync() async method to read task asynchronously with await keyword
        /// M:ConsoleApplication1.AsyncAwait1.callMethodAsync
        /// </summary>
        /// <returns>return type is void.</returns>
        public static async void callMethodAsync()
        {
            Task<int> task = Method1Async();
            Method2();
            int count = await task; //waiting for method3 to complete task of method1
            Method3(count);
        }
        /// <summary>
        /// Method1Async() async method to read task asynchronously with await keyword
        /// M:ConsoleApplication1.AsyncAwait1.Method1Async
        /// </summary>
        /// <returns>return type is Task which is int type.</returns>
        public static async Task<int> Method1Async()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method1Async : " + i);
                    log.Info("Method1Async : " + i);
                    count++;
                }
            });
            return count;
        }
        /// <summary>
        /// Method2 method for iterating different task
        /// M:ConsoleApplication1.AsyncAwait1.Method2
        /// </summary>
        /// <returns>return type is void.</returns>
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method2 : " + i);
                log.Info("Method2 : " + i);
            }
        }
        /// <summary>
        /// Method3 method for iterating different task
        /// M:ConsoleApplication1.AsyncAwait1.Method3
        /// </summary>
        /// <param name="count">int type parameter.</param>
        /// <returns>return type is void.</returns>
        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
            log.Info("Total count is " + count);
        }
    }
}

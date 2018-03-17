using System;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// class to call the methods Asynchronously
    /// T:ConsoleApplication1.AsyncAwait
    /// </summary>
    public class AsyncAwait
    {
        /// <summary>
        /// statement for using functions of log4net
        /// F:ConsoleApplication1.AsyncAwait.log
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(AsyncAwait));

        /// <summary>
        /// Method1Async async method to read task asynchronously with await keyword
        /// M:ConsoleApplication1.AsyncAwait.Method1Async
        /// </summary>
        /// <returns>return type is void.</returns>
        public static async Task Method1Async()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Method1Async : " + i);
                    log.Info("Method1Async : " + i);
                }
            });
        }

        /// <summary>
        /// Method2 method for iterating
        /// M:ConsoleApplication1.AsyncAwait.Method2
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
        /// main method for calling Method1Async() and Method2()
        /// M:ConsoleApplication1.AsyncAwait.Main(System.String[])
        /// </summary>
        /// <param name="args">string array type parameter.</param>
        /// <returns>return type is void.</returns>
        static void Main(string[] args)
        {
            Method1Async();
            Method2();
            Console.ReadKey();
        }
    }
}

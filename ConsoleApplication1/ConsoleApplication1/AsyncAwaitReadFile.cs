using System;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// class to read the contents of a file Asynchronously
    /// T:ConsoleApplication1.AsyncAwaitReadFile
    /// </summary>
    public class AsyncAwaitReadFile
    {
        /// <summary>
        /// statement for using functions of log4net
        /// F:ConsoleApplication1.AsyncAwaitReadFile.log
        /// </summary>
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(AsyncAwaitReadFile));
        /// <summary>
        /// main method for creating instance of Task and calling start and wait method of task
        /// M:ConsoleApplication1.AsyncAwaitReadFile.Main(System.String[])
        /// </summary>
        /// <param name="args">string array type parameter.</param>
        /// <returns>return type is void.</returns>
        static void Main(string[] args)
        {
            Task task = new Task(callMethodAsync);
            task.Start();
            task.Wait();
            Console.ReadKey();
        }
        /// <summary>
        /// callMethodAsync async method to call readFileAsync method to read the file and use await keyword
        /// M:ConsoleApplication1.AsyncAwaitReadFile.callMethodAsync
        /// </summary>
        /// <returns>return type is void.</returns>
        public static async void callMethodAsync()
        {
            Task<int> task = readFileAsync(@"E:\data.txt");
            Console.WriteLine(" Other Work 1");
            log.Info(" Other Work 1");
            Console.WriteLine(" Other Work 2");
            log.Info(" Other Work 2");
            Console.WriteLine(" Other Work 3");
            log.Info(" Other Work 3");
            int length = await task;
            Console.WriteLine("Total length : " + length);
            log.Info("Total length : " + length);
            Console.WriteLine(" After work 1");
            log.Info(" After work 1");
            Console.WriteLine(" After work 2");
            log.Info(" After work 1");
        }
        /// <summary>
        /// readFileAsync method for for reading the contents of a file asynchronously
        /// M:ConsoleApplication1.AsyncAwaitReadFile.readFileAsync(System.String)
        /// </summary>
        /// <param name="file">string type parameter.</param>
        /// <returns>return type is Task which is int generic type.</returns>
        static async Task<int> readFileAsync(string file)
        {
            int length = 0;
            Console.WriteLine("File reading is started");
            log.Info("File reading is started");
            using (StreamReader reader = new StreamReader(file))
            {
                // Reads all characters from the current position to the end of the stream asynchronously  
                // and returns them as one string
                string s = await reader.ReadToEndAsync();
                /*
                 not wait to get a return value from this method and execute the other lines of code but it 
                 has to wait for the line 25 because we are using await keyword after that only line 26,27,28 will be execute
                 */
                length = s.Length;
            }
            Console.WriteLine("File reading is completed");
            log.Info("File reading is completed");
            return length;
        }
    }
}

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => MainAsync(args)).Wait();
        }

        static async void MainAsync(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            //var printA = PrintAsync();
            //var printB = PrintAsync();
            //await printA;
            //await printB;

            var printA = PrintAsync();
            await printA;
            var printB = PrintAsync();
            await printB;

            stopWatch.Stop();

            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }

        static async Task PrintAsync()
        {
            Console.WriteLine("thread starts to sleep.");
            Thread.Sleep(3000);
            Console.WriteLine("thread wakes up");
        }
    }
}

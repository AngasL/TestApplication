using System;
using System.Timers;

namespace TimerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer(0);
            timer.Elapsed += (e, arg) => { DispayMethed(); };

            var startTime = DateTime.Now;

            while (DateTime.Now.Millisecond - startTime.Millisecond < 5)
            {
                
            }

            timer.Stop();
        }

        static void DispayMethed()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}

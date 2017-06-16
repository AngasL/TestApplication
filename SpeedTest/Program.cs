using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var sw = new Stopwatch();
            var value = true;
            const int Max = 1000000000;
            int count = 0;
            // The loop will increment count Max times; let's measure how long it takes
            for (int i = 0; i != Max; i++)
            {
                count++;
            }
            sw.Stop();
            var baseTime = sw.ElapsedMilliseconds;

            sw.Start();
            count = 0;
            for (int i = 0; i != Max; i++)
            {
                if (value) count++;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds - baseTime);

            sw.Reset();
            count = 0;
            sw.Start();

            for (int i = 0; i != Max; i++)
            {
                if (value == true) count++;
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds - baseTime);
            */
            var value = true;
            var a = 0;
            if (value == true)
            {
                a = 1;
            }
            if (value)
            {
                a = 2;
            }
        }
    }
}

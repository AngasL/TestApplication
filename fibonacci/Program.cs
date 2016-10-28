using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 4;
            Console.WriteLine(Fib(number));
        }

        public static int Fib(int number)
        {
            var a = 0;
            var b = 1;
            int fn = 0;
            for (var i = 1; i < number; i++)
            {
                fn = a + b;
                a = b;
                b = fn;
            }

            return fn;
        }
    }
}

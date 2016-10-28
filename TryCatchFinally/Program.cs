using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test());
        }

        static string Test()
        {
            try
            {
                Console.WriteLine("This is try");

                return "this is return";
            }
            finally
            {
                Console.WriteLine("This is finally");
            }
        }
    }

}

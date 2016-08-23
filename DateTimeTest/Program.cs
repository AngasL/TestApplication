using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeNow = DateTime.UtcNow;

            var addedDateTime = dateTimeNow.AddSeconds(1);

            Console.WriteLine(dateTimeNow.Ticks);
            Console.WriteLine(addedDateTime.Ticks);
        }
    }
}

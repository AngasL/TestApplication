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
			//var dateTimeNow = DateTime.UtcNow;

			//var addedDateTime = dateTimeNow.AddSeconds(1);

			//Console.WriteLine(dateTimeNow.Ticks);
			//Console.WriteLine(addedDateTime.Ticks);

			//Console.WriteLine(DateTime.MaxValue.Ticks - 2 * dateTimeNow.Ticks);

			//decimal result;
			//int hashCode;
			//do
			//{
			//    hashCode = Guid.NewGuid().GetHashCode();
			//    result = Convert.ToDecimal(hashCode);
			//}
			//while (result != 0);

			//Console.WriteLine(result);
			//Console.WriteLine(hashCode);

			//double expectedValue = 1 / 2;
			//if (expectedValue > 0)
			//{
			//    expectedValue = expectedValue + 0.5;
			//}

			//Console.WriteLine(expectedValue);

			//var list = new List<string>();

			//var result = list.Where(l => l.Contains("123")).FirstOrDefault();
			//var currentDate = DateTime.Now;
			//Console.WriteLine(currentDate.ToShortTimeString());
			//Console.WriteLine(result);

			//Console.Read();

			var result =  TimeSpan.TryParse("00:01:00:00", out TimeSpan time);

			Console.WriteLine(time);
        }

        private delegate bool IsAssertException(Exception exc);
        

        //private static int Method(int first = 1, int second = 2, Func<Exception, bool> Sum = new IsAssertException(exc=>exc is AssertException))
        //{
        //    return Sum(first, second);
        //}

        private static int Add(int para1, int para2)
        {
            return para1 + para2;
        }


    }

    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

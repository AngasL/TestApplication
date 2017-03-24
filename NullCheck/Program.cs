using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            People p = null;

            var str = string.Format("12{0}3", null);

            Console.WriteLine(str);
            if (Convert.ToBoolean(p?.IsMale))
            {
                Console.WriteLine("Is male");
            }
            else
            {
                Console.WriteLine("Is Femal");
            }
        }
    }

    public class People
    {
        public bool IsMale { get; set; }
    }
}

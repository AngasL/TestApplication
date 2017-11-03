using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            var orignal = "rm=0&id=passive&ru=%2Fadmintools%2FEmailNotificationSettings";
            var substrings = orignal.Split('&');
            var result = substrings.Where(sub => sub.StartsWith("ru=")).FirstOrDefault()?.TrimStart(new char[] { 'r', 'u', '=' });

            if (result != null)
                Console.WriteLine(result);
        }
    }
}

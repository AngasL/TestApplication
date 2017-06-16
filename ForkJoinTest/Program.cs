using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForkJoinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = MainAsync(args);
            task.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var source = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = await source.ForkJoin(GetString);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static async Task<string> GetString(int item)
        {
            if (item == 5)
            {
                Thread.Sleep(3000);
            }

            return await Task.FromResult<string>(item + "-");
        }
    }

    static class Extention
    {
        public static Task<R[]> ForkJoin<T, R>(this IEnumerable<T> source, Func<T, Task<R>> worker)
        {
            var futures = source.Select(worker).ToArray();

            return Task.WhenAll<R>(futures);
        }
    }
}

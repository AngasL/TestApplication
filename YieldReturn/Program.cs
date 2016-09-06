using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = new People
            //{
            //    Pencil = new List<string> { "pencile1", "pencile2"},
            //    BallPointPen = new List<string> { "ballpointpen1","ballpointpen2"}
            //};

            //var pens = GetAllPens(people);

            //foreach (var pen in pens)
            //{
            //    Console.WriteLine(pen);
            //}

            Console.WriteLine(Guid.NewGuid());

            var intArr = new int[] { 9, 8, 4, 7, 6, 2, 1 };
            foreach (var item in intArr)
            {
                Console.Write(string.Format("{0} ,", item));
            }

            Console.WriteLine();

            intArr = intArr.OrderBy(i => i).ToArray();
            foreach (var item in intArr)
            {
                Console.Write(string.Format("{0} ,", item));
            }
        }

        private static IEnumerable<string> GetAllPens(People people)
        {
            foreach (var pencil in people.Pencil)
            {
                yield return pencil;
            }

            foreach (var ballpointpen in people.BallPointPen)
            {
                yield return ballpointpen;
            }
        }
    }

    public class People
    {
        public IEnumerable<string> Pencil { get; set; }
        public IEnumerable<string> BallPointPen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PetOwner[] petOwners =
            {
                new PetOwner
                {
                  Name ="Higa, Sidney",
                  Pets = new List<string>{ "123", "345" }
                },
                new PetOwner { Name="Ashkenazi, Ronen",
                  Pets = new List<string>{ "Walker", "Sugar" } },
                new PetOwner { Name="Price, Vernette",
                  Pets = new List<string>{ "Scratches", "Diesel" } }
            };

            var avaliablePets = petOwners.SelectMany(po =>
            {
                if (po.Pets != null)
                {
                    return po.Pets;
                }
                return new List<string>();
            });

            var selectManyTest = petOwners.SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName });

            Console.ReadKey();
        }
    }

    class PetOwner
    {
        public string Name { get; set; }
        public List<String> Pets { get; set; }
    }
}

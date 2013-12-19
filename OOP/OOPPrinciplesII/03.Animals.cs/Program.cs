using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals.cs
{
    class Program
    {
        private static IEnumerable<Tuple<string, double>> GetAverageAges(Animal[] animals)
        {
            var averageAges =
                from animal in animals
                group animal by animal.GetType() into animalType
                select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

            return averageAges;
        }

        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
            
            new Kitten("kity", 12, "female"),
            new Kitten("shshi", 2, " "),
            new Frog ("frogi", 1, "male"),
            new Dog("rex", 12, "male"),
            new Tomcat("Tom", 5, " "),
            new Tomcat("Araq", 8, " "),
            new Frog("sonya", 1, "female"),     
            };

            double averageAge = Animal.GetAverageAge(animals);

            Console.WriteLine(averageAge);

            var averageAges = GetAverageAges(animals);
            foreach (var animal in averageAges)
            {
                Console.WriteLine("Animal: {0}, Average Age: {1}", animal.Item1, animal.Item2);
            }
        }
    }
}

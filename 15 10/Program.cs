using System;
using System.Linq;

namespace _15_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, string, string, string> textConcat = (t1, t2, t3) => $"{t1 + t2 + t3}";
            //Console.WriteLine(textConcat("H", "e", "j"));

            //Console.WriteLine();

            //Func<int, int, bool> equals = (x, y) => x == y;
            //Console.WriteLine(equals(6, 6));

            //Console.WriteLine();

            //Func<int, bool> isEven = x => x % 2 != 1;
            //Console.WriteLine(isEven(3));

            var people = new[] {
                new { firstName = "Fredrik", lastName = "Johansson", age = 40, length = 1.80, weight = 72},
                new { firstName = "Maria", lastName = "Andersson", age = 42, length = 1.72, weight = 68 },
                new { firstName = "Anna", lastName = "Svensson", age = 22, length = 1.65, weight = 58 },
                new { firstName = "Per", lastName = "Svensson", age = 31, length = 1.87, weight = 71 },
                new { firstName = "Sara", lastName = "Rich", age = 19, length = 1.67, weight = 56 },
                new { firstName = "Yamen", lastName = "Al", age = 27, length = 1.77, weight = 79 }
                }.ToList();

            people.Add(new { firstName = "Linn", lastName = "Stark", age = 25, length = 1.64, weight = 49 });

            people.Where(p => 1.70 <= p.length && p.length <= 1.85).ToArray();

            var newArray = people
            .Where(p => p.age > 25)
            .Select(p => new { name = $"{p.firstName} {p.lastName}", p.age, BMI = p.weight / (p.length * p.length) })
            .ToArray();

            foreach (var person in newArray)
            {
                Console.WriteLine($"{person.name} BMI: {person.BMI:N2}");
            }
        }
    }
}

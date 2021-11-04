using System;
using System.Collections.Generic;

namespace _27Sep
{
    class Program
    {
        static void Main(string[] args)
        {
            var lookupDays = new Dictionary<string, DateTime>();

            lookupDays.Add("today", DateTime.Now);
            lookupDays.Add("yesterday", DateTime.Now.AddDays(-1));
            lookupDays.Add("tomorrow", DateTime.Now.AddDays(1));

            //Console.Write("enter an word: ");

            //var word = Console.ReadLine();
            //Console.WriteLine(lookupDays[word]);

            foreach (KeyValuePair<string, DateTime> day in lookupDays)
            {
                Console.WriteLine($"{day.Key}: {day.Value.DayOfWeek}");
            }

        }
        static void listexepmle()
        {

            var names = new List<string>();
            names.Add("Yamen");
            names.Add("Anna");
            names.Add("Fredrik");

            //names.Clear();

            var input = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(input))
            {
                names.Add(input);
                input = Console.ReadLine();
            }

            //names.Remove("Anna");
            //names.RemoveAt(1);

            Console.WriteLine(names.Count);

            Console.WriteLine(names.Count);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static T[] MakeGenericArray<T>(T variable, int leangth)
        {
            T[] array = new T[leangth];
            for (int i = 0; i < leangth; i++)
            {
                array[i] = variable;
            }
            return array;
        }
    }
}

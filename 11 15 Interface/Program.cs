using System;
using System.Collections.Generic;

namespace _11_15_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IStuffThatRuns>();

            list.Add(new Car() { Name = "Volvo" });
            list.Add(new Car() { Name = "BMW" });
         
            list.Add(new Dog() { Name = "Woff" });

            list.Add(new Dog() { Name = "Megalo" });

            foreach (var item in list)
            {
                item.Run();
                if (item is Cat cat)
                {
                    cat.Eat();
                }
            }

            static void PrintGreeting(IStuffThatRuns item)
            {
                Console.WriteLine($"Hello {item.Name}");
            }

        }
    }

    class Car : IStuffThatRuns
    {
        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
    }

    class Dog : IStuffThatRuns, IStuffThatEats
    {
        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine($"The dog {Name} is running");
        }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating");
        }
    }

    class Cat : IStuffThatRuns, IStuffThatEats
    {
        public string Name { get; set; }

        public void Run()
        {
            Console.WriteLine($"The cat {Name} is running");
        }

        public void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating");
        }
    }
}

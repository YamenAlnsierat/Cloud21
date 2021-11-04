using System;

namespace _13_sep_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat() { Name = "Megalo" };
            myCat.Eat();
            myCat.sayMeow();
            myCat.Drink();

            Console.WriteLine();

            Dog myDog = new Dog() { Name = "Koro" };
            myDog.Eat();
            myDog.saywoff();
            myDog.Drink();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();

        public virtual void Drink()
        {
            Console.WriteLine($"The animal {Name} is drinking");
        }
    }

    class Cat : Animal
    {
       public void sayMeow()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat()
        {
            Console.WriteLine($"The cat {Name} is eating");
        }
    }

    class Dog : Animal
    {
        public void saywoff()
        {
            Console.WriteLine("WOOFF");
        }
        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating");
        }
        public override void Drink()
        {
            base.Drink();
            Console.WriteLine($"The dog {Name} started drinking");
            for (int i = 0; i < 10; i++)
            {
            Console.WriteLine($"The dog {Name} is still drinking");
            }
            Console.WriteLine($"The dog {Name} is done");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Greetings
{
    class Calculator
    {
        double a;
        double b;
        public void Run()
        {

            Console.WriteLine("Hello to my calculator. ");

            int function;
            do
            {
                Console.WriteLine("Choose a function and then enter two numbers! ");
                Console.WriteLine("Enter 1 to add ");
                Console.WriteLine("Enter 2 to sub ");
                Console.WriteLine("Enter 3 to Multi ");
                Console.WriteLine("Enter 4 to divide ");
                Console.WriteLine("Enter 0 to exit ");
                function = int.Parse(Console.ReadLine());

                switch (function)
                {
                    case 1:
                        AddNumbers();
                        break;
                    case 2:
                        SubNumbers();
                        break;
                    case 3:
                        Multiway();
                        break;
                    case 0:
                        Console.WriteLine("Thx for using my calculator :) ");
                        break;
                    default:
                        Console.WriteLine("Unavilable chocie!");
                        break;
                }

            } while (function != 0);

        }
        public void AddNumbers()
        {
            Console.WriteLine("First number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            b = double.Parse(Console.ReadLine());
            double sum = a + b;
            Console.WriteLine($"Sum is: {sum}");
        }

        public void SubNumbers()
        {
            Console.WriteLine("First number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            b = double.Parse(Console.ReadLine());
            double diff = a - b;
            Console.WriteLine($"Sum is: {diff}");
        }

        public void Multiway()
        {
            Console.WriteLine("First number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            b = double.Parse(Console.ReadLine());
            double product = a * b;
            Console.WriteLine($"Result is: {product}");
        }
    }
}

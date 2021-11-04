using System;

namespace _4_okt
{
    class Program
    {
        public delegate string Artist(string input);
        public delegate void Printer(string input, bool uppercase);
        public delegate bool Inspector(string input, int x);


        static void Main(string[] args)
        {
            //Artist artist = new Artist(Pico);
            //var art = artist("yamen");
            //Console.WriteLine(art);
            //CreateArt("Yamen", Pico);


            //LoopCalculator(5, Multi);
            //Console.WriteLine("Enter the frist Number:");
            //var input = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second Number:");
            //var input2 = double.Parse(Console.ReadLine());
            //Console.Write("Result is : ");
            //Calculator(input, input2, Add);

            //Action<int, int> myPrint = PrintSum;
            //myPrint(4, 5);

            //Func<int, int, string> func = GetSumAsString;
            //Console.WriteLine(func(5, 5)); 


            //TextPrinter("Yamen", false, Toupper);
            //TextPrinter("Yamen", true, Toupper);

            //Func<string, int, bool> inspector = MoreOrLess;
            //Console.WriteLine("Write a text and then enter a number: ");
            //Console.WriteLine(inspector(Console.ReadLine(), int.Parse(Console.ReadLine()))); 

            //Action PrintMethod = PrintSomething;
            //PrintMethod += PrintSomethingElse;
            //PrintMethod += PrintSomething;
            //PrintMethod -= PrintSomethingElse;

            //PrintMethod?.Invoke();

            //Console.WriteLine();

            //PrintMethod();

        }

        public static string Pico(string text)
        {
            return $"Pico art: {text}";
        }
        public static string Leo(string text)
        {
            return $"Leo art: {text}";
        }
        public static void CreateArt(string text, Artist artist)
        {
            var art = artist(text);
            Console.WriteLine(art);
        }
        ////////////////////////////////////////////////

        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Multi(double x, double y)
        {
            return x * y;
        }
        static double Sub(double x, double y)
        {
            return x - y;
        }
        static double Divide(double x, double y)
        {
            return x / y;
        }
        static void Calculator(double x, double y, Func<double, double, double> calculate)
        {
            Console.WriteLine(calculate(x, y));
        }
        static void LoopCalculator(double x, Func<double, double, double> calculate)
        {
            for (double i = 1; i <= 10; i++)
            {
            Console.WriteLine(calculate(x, i));
            }
        }

        /////////////////////////////////////////////////////
       
        static void PrintSum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static string GetSumAsString(int x, int y)
        {
            return (x + y).ToString();
        }
        ////////////////////////////////////////////////////
        
        static void TextPrinter(string text, bool uppercase, Action<string, bool> printer)
        {
            printer(text.ToUpper(), uppercase);
        }

        static void Toupper(string text, bool upp)
        {
            if (upp)
            {
                Console.WriteLine(text.ToUpper());
            }
            else
            {
                Console.WriteLine(text.ToLower());
            }
        }

        /////////////////////////////////////////////////////

        static bool MoreOrLess(string text, int x)
        {
            if (text.Length > x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////


        static void PrintSomething()
        {
            Console.WriteLine("Somting");
        }
        static void PrintSomethingElse()
        {
            Console.WriteLine("Somtingelse");

        }
    }
}

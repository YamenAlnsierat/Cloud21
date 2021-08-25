using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 3;
            string y = "7";
            int.Parse(y);
            Console.WriteLine(x + y);
            Console.WriteLine(x + int.Parse(y));*/


            /*int a = 6;
            Console.WriteLine($"Frist number is {a}.");
            int b = 7;
            Console.WriteLine($"Secind number is {b}.");
            int sum = a + b;
            int diff = a - b;
            int multi = a * b;
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"diff is: {diff}");
            Console.WriteLine($"produkt is: {multi}");*/


            /*Console.Write("Skriv in förnamn, tack: ");
            String FristName = Console.ReadLine();
            Console.Write("Skriv in efternamn, tack: ");
            String LastName = Console.ReadLine();
            Console.Write("Skriv in ett nummer, tack: ");
            int number = int.Parse(Console.ReadLine());
            int i = 0;
            while (i != number)
            {
                Console.WriteLine($"Hej {FristName} {LastName} ");
                i++;
            }*/


            /*Console.Write("First number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Third number: ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine($"Sum is: {sum}");*/

            /*bool myBool = false;
            String name = Console.ReadLine();
            if (myBool)
            {
                Console.WriteLine("U R AWESOME! ");
            }
            else if (name != "Kalle")
            {
                Console.WriteLine("Kalle is cool");
            }
            else
            {
                Console.WriteLine("U R not Yam nor Kalle");
            }*/


            /*string x = "myword";
            Console.Write("write a password: ");
            string password = Console.ReadLine();
            if (x == password)
            {
                Console.WriteLine("Password is right! ");
            }
            else
            {
                Console.WriteLine("Wrong");
            }*/


            /*Console.Write("write a umber: ");
            int number = int.Parse(Console.ReadLine());
            
            if (number >= 100)
            {
                Console.WriteLine("The number is 100 or bigger  ");
            }
            else
            {
                Console.WriteLine("The number is smaller than 100");
            }*/


            /*Console.Write("Write the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Write one of the following choices: + - * or /: ");
            string operat = Console.ReadLine();
            Console.Write("Write the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            if (operat == "+")
            {
                int sum = number1 + number2;
                Console.WriteLine($"Here is the result of your two numbers: {sum}");
            }
            else if (operat == "-")
            {
                int diff = number1 - number2;
                Console.WriteLine($"Here is the result of your two numbers: {diff}");
            }
            else if (operat == "*")
            {
                int product = number1 * number2;
                Console.WriteLine($"Here is the result of your two numbers: {product}");
            }
            else if (operat == "/")
            {
                int result = number1 / number2;
                Console.WriteLine($"Here is the result of your two numbers: {result}");
            }*/



            /*int i = 2;
            while (i >= 100)
            {
                Console.WriteLine("e" + i);
                i *= 2;
            }*/
            /*bool mybool = true;
            while (mybool)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey();
                    Console.WriteLine("22");
                }
            }*/


            /*int i = 0;
            while (true)
            {
                i++;
                if (i == 7 || i == 12 || i == 17)
                {
                    Console.WriteLine("Hej");
                    continue;
                }
                if (i == 21)
                {
                    break;
                }
                Console.WriteLine("i is: " + i);
            }*/


            /*int x = 77;
            int randomNumber;
            do
            {
                Console.Write("Enter a random number between 1-100: ");
                randomNumber = int.Parse(Console.ReadLine());
                if (randomNumber > x)
                {
                    Console.WriteLine("Too big");
                }
                else if (randomNumber < x)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    Console.WriteLine("That is the right number!");
                }
            } while (x != randomNumber);*/


            /*int i = 1;
            while (i <=  5)
            {
                Console.WriteLine("Hej");

                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine("x");
                    j++;
                }
                i++;
            }*/


            /*for (int i = 1; i <= 9; ++i)
            {
                for (int col = 1; col <= i; ++col)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }*/



        }
    }
}

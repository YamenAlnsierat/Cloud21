using System;
using System.Text;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextAndNumber();
            //AddSubMulti();
            //Greet();
            //MyBool();
            //PassWord();
            //Between100();
            //SimpleCalc();
            //Exception();
            //Random();
            //NastedWhile();
            //NumberTriangle();
            //PatternLoop();
            //NumberReader();
            //MakeArray();
            //ReversPrinter();
            //NoVocalsPolicy();
            //Palindrom();
            //OnlyNumbers();
            //OneLineCalc();
            //PartOfText();
            //LettersInSentence();
            //GiveBackText(45);

        }
        static void TextAndNumber()
        {
            int x = 3;
            string y = "7";
            int.Parse(y);
            Console.WriteLine(x + y);
            Console.WriteLine(x + int.Parse(y));
        }

        static void AddSubMulti()
        {
            int a = 6;
            Console.WriteLine($"Frist number is {a}.");
            int b = 7;
            Console.WriteLine($"Secind number is {b}.");
            int sum = a + b;
            int diff = a - b;
            int multi = a * b;
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"diff is: {diff}");
            Console.WriteLine($"produkt is: {multi}");
        }

        static void Greet()
        {
            Console.Write("Skriv in förnamn, tack: ");
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
            }
        }

        static void MyBool()
        {
            bool myBool = false;
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
            }
        }

        static void PassWord()
        {
            string x = "myword";
            Console.Write("write a password: ");
            string password = Console.ReadLine();
            if (x == password)
            {
                Console.WriteLine("Password is right! ");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }

        static void Between100()
        {
            Console.Write("write a umber: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100)
            {
                Console.WriteLine("The number is 100 or bigger  ");
            }
            else
            {
                Console.WriteLine("The number is smaller than 100");
            }
        }

        static void SimpleCalc()
        {
            Console.Write("Write the first number: ");
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
            }
        }

        static void Exception()
        {
            int i = 0;
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
            }
        }

        static void Random()
        {
            int x = 77;
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
            } while (x != randomNumber);
        } //Improve

        static void NastedWhile()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Hej");

                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine("x");
                    j++;
                }
                i++;
            }
        }

        static void NumberTriangle()
        {
            for (int i = 1; i <= 9; ++i)
            {
                for (int t = 1; t <= i; ++t)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void PatternLoop()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (b == i || b == i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("A");

            for (int i = 0; i < 4; i++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (b == i || b == i)
                    {
                        Console.Write("#");
                    }
                    else if (b == i + 4)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("B");

            for (int i = 0; i < 4; i++)
            {
                for (int b = 0; b < 8; b++)
                {
                    if (b == i * 2)
                    {
                        Console.Write("#");
                    }
                    else if (b == i * 2 + 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("C");


            for (int i = 1; i < 5; i++)
            {
                for (int b = 1; b < 9; b++)
                {
                    if (b + 2 == 2 * i)
                    {
                        Console.Write("#");
                    }
                    if (i == b)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("D");
        } //ToBeCon

        static void NumberReader()
        {
            string[] NumbersWritting = { "noll", "ett", "tva", "tre", "fyra", "fem", "sex", "sjo", "atta", "nio" };
            Console.WriteLine("Enter at number between 0 and 9: ");

            for (int i = 0; i < NumbersWritting.Length; i++)
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine(NumbersWritting[i]);
            }
        }

        static void MakeArray()
        {
            Console.WriteLine("How many number will you enter? ");
            int x = int.Parse(Console.ReadLine());
            int[] Numbers = new int[x];
            int i;
            for (i = 0; i < Numbers.Length; i++)
            {
                Console.Write($"Index[{i}]: ");
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Indexes in revers : ");
            for (i = Numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"Index[{i}]: {Numbers[i]}");
            }

        }

        static void ReversPrinter()
        {
            int i, l;
            string text, text1 = "";
            Console.WriteLine("Write a text");
            text = Console.ReadLine();

            l = text.Length - 1;
            for (i = l; i >= 0; i--)
            {
                text1 = text1 + text[i];
            }
            Console.WriteLine(text1);
        }

        static void NoVocalsPolicy()
        {
            Console.WriteLine("Write a text");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'i' || text[i] == 'o' || text[i] == 'a' || text[i] == 'e' || text[i] == 'u')
                {
                    Console.Write('*');
                }
                else
                {
                Console.Write(text[i]);
                }
            }
        }

        static void Palindrom()
        {
            string reversText = "";
            Console.WriteLine("Write a random word");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversText = reversText + text[i];
            }
            if (text == reversText)
            {
            Console.WriteLine($"Your word in backwards is: {reversText} It is a palindrom ");
            }
            else
            {
            Console.WriteLine($"Your word in backwards is: {reversText} It is not a palindrom ");
            }
        }

        static void OnlyNumbers()
        {
            //int i = 0;
            //int sum = 0;
            //double avrage = 0;
            //bool cont = true;
            //List<int> Numbers = new List<int>();
            //while (cont)
            //{
            //    Console.Write("Enter a number: ");
            //    string input = Console.ReadLine();
            //    bool succes = int.TryParse(input, out int result);

            //    if (succes)
            //    {
            //        Console.WriteLine($"Index[{i}]: {result} ");
            //        i++;
            //        sum += result;
            //        Console.WriteLine($"Here is the sum of all your numbers: {sum} ");
            //    }
            //    else
            //    {
            //        cont = false;
            //        Console.WriteLine("wrong input");
            //        avrage = (double)sum / Numbers.Count;
            //        Console.WriteLine($"Here is the avarge value of you numbers: {avrage}");
            //    }
            //}   
            int sum = 0;
            double avrage=0;
            bool cont = true;
            while (cont)
            {
                int x;
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                bool succes = int.TryParse(input, out int result);
                if (succes)
                {
                    sum += result;
                    Console.WriteLine($"Here is the sum of all your numbers: {sum} ");
                }
                else
                {
                    cont = false;
                    Console.WriteLine("wrong input");
                    avrage = (double)sum;
                    Console.WriteLine($"Here is the avarge value of you numbers: {avrage}");
                }
            }//ToBe
        }//Improv

        static void OneLineCalc()
        {
            Console.WriteLine("Write a number and one of the following marks: + - * or / and then one more number : ");
            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out int equation);

            if (succes)
            {
                Console.WriteLine(equation);
            }           
            else
            {
                Console.WriteLine($"Wrong input");
            }
        }//ToBe

        static void PartOfText()
        {
            string text, text1;

            Console.Write("Write a text: ");
            text = Console.ReadLine();
            Console.Write("Write a part of your first text: ");
            text1 = Console.ReadLine();
            if (text.Contains(text1))
            {
                for (int i = 0; i < text.Length; i++)
                {

                    if (i == text1[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (i == text1.Length)
                    {
                        Console.ResetColor();
                    }
                    Console.Write(text[i]);

                }
            }
            else
            {
            Console.WriteLine("Wrong input");                    
            }


        }//ToBe

        static void LettersInSentence()
        {
            Console.WriteLine("White down a sentence, please. ");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence.Length);          
        }//Improve


    }
}

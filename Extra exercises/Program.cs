using System;

namespace Extra_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab1Exercises();
            //lab1();
        }

        static void Lab1Exercises()
            {
            //string text = "Hello World!";
            //foreach (char c in text)
            //{
            //    if (c == ' ')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write(c);
            //    }
            //}


            //string text1 = "this is just another text";
            //foreach (var i in text1)
            //{
            //    if (i == ' ')
            //    {
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //    }
            //}


            //string text = "Detta är uppgift 3";
            //for (var r = 0; r < text.Length; r++)
            //{
            //    if (r==0)
            //    {
            //        Console.Write(text[r]);
            //    }
            //    else if (r % 2 == 0 && r!=0)
            //    {
            //        Console.Write("*");
            //    }
            //    else
            //    {
            //        Console.Write(text[r]);
            //    }
            //}


            //string text1 = "Hello World!";
            //foreach (var i in text1)
            //{
            //    Console.ResetColor();
            //    if (i == 'o')
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write(i);
            //    }
            //    else if (i == 'l')
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.Write(i);
            //    }
            //    else
            //    {
            //        Console.Write(i);
            //    }
            //}


            //string text1 = "Hello World!";
            //for (var r = 0; r < text1.Length; r++)
            //{
            //    if (r <= 1 || r >= text1.Length - 1)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        Console.Write(text1[r]);
            //        continue;
            //    }
            //    if (text1[r] == text1[r + 1] || text1[r] == text1[r - 1])
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.Write(text1[r]);
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        Console.Write(text1[r]);
            //    }
            //}
            //Console.WriteLine();


            //string text = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
            //Console.WriteLine(text);
            //Console.Write("write a part of the text above: ");
            //string text1 = Console.ReadLine();
            //if (text.Contains(text1))
            //{
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        bool isMatch = true;
            //        for (int t = 0; t < text1.Length; t++)
            //        {
            //            if (text[i + t] != text1[t])
            //            {
            //                isMatch = false;
            //                break;
            //            }
            //        }
            //        if (isMatch)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            for (int t = i; t < i + text1.Length; t++)
            //            {
            //                Console.Write(text[t]);
            //            }
            //            i += text1.Length - 1;
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Gray;
            //            Console.Write(text[i]);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"The text: \"{text}\" doesn`t contain your text: \"{text1}\" ");
            //}
            //Console.WriteLine();


            //string text = "Hello world";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int t = 0; t <= i; t++)
            //    {
            //        Console.Write(text[i]);
            //    }
            //    Console.WriteLine();
            //}


            //string text = "How much wood would a woodchuck ckuck if a woodchuck could chuck wood?";
            //string[] arrayText = text.Split(" ");
            //for (int i = 0; i < arrayText.Length; i++)
            //{
            //    for (int t = i; t >= 0; t--)
            //    {
            //        Console.Write(arrayText[i]);
            //        Console.Write(' ');
            //    }
            //    Console.WriteLine();
            //}


            //string text = "How much wood would a woodchuck ckuck if a woodchuck could chuck wood?";
            //string[] arrayText = text.Split();
            //for (int i = 0; i < arrayText.Length; i++)
            //{
            //    for (int t = 0; t <= i; t++)
            //    {
            //        Console.Write(arrayText[t]);
            //        Console.Write(' ');
            //    }
            //    Console.WriteLine();
            //}


            //string text = "How much wood would a woodchuck ckuck if a woodchuck could chuck wood?";
            //string[] arrayText = text.Split(' ');
            //for (int i = 0; i < arrayText.Length; i++)
            //{
            //    for (int t = 0; t < arrayText.Length; t++)
            //    {
            //        if (t == i)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.Write(arrayText[t]);
            //        }
            //        else
            //        {
            //            Console.Write(arrayText[t]);
            //        }
            //        Console.Write(' ');
            //        Console.ResetColor();
            //    }
            //    Console.WriteLine();
            //}


            //string text = "abcdefghijklmnopqrstuvwxyz";
            //for (int i = 0; i < text.Length - 4; i++)
            //{
            //    for (int t = 0; t < text.Length; t++)
            //    {
            //        if (t == i)
            //        {
            //            for (int r = i; r < 5 + t; r++)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                Console.Write(text[r]);
            //            }
            //            t = +4 + i;
            //        }
            //        else
            //        {
            //            Console.Write(text[t]);
            //        }
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //    Console.WriteLine();
            //}


            //string text = "abcdefghijklmnopqrstuvwxyz";
            //for (int i = 0; i < text.Length - 4; i++)
            //{
            //    for (int t = 0; t < text.Length; t++)
            //    {
            //        if (t == i)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }
            //        if (t == i + 5)
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //        }
            //        Console.Write(text[t]);
            //    }
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine();
            //}


            //string text = Console.ReadLine();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == text[0])
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    if (i != 0 && i - 1 != 0 && text[i - 1] == text[0])
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //    Console.Write(text[i]);
            //}
            //Console.WriteLine();


            //string text = Console.ReadLine();
            //Console.ForegroundColor = ConsoleColor.Green;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.Write(text[i]);
            //    if (i > 0 && text[i] == text[0]) Console.ResetColor();
            //}
            //Console.WriteLine();


            //string text = "ajdfhvajhdfd";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int t = 0; t < text.Length; t++)
            //    {
            //        if (text[t] == text[i])
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }
            //        if (t != 0 && t - 1 != i && text[t - 1] == text[i])
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //        }
            //        Console.Write(text[t]);
            //    }
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //Console.WriteLine();


            //string text = "ajdfhvajhdfd";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int t = 0; t < text.Length; t++)
            //    {
            //        if (text[t] == text[i] && t <= i)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }
            //        if (t > 0 && t - 1 != i && text[t - 1] == text[i])
            //        {
            //            Console.ForegroundColor = ConsoleColor.White;
            //        }
            //        Console.Write(text[t]);
            //    }
            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.White;
            //}
            //Console.WriteLine();

            //string text = "ajdfhvajhdfd";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    for (int t = 0; t < text.Length; t++)
            //    {
            //        if (text[t] == text[i] && t == i)
            //        {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        }
            //        if (t > 0 && t - 1 != i && text[t - 1] == text[i])
            //        {
            //        Console.ResetColor();
            //        }
            //        Console.Write(text[t]);
            //    }
            //Console.WriteLine();
            //Console.ResetColor();
            //}
            //Console.WriteLine();


        }

        static void lab1()
        {
            Console.Write("Write a random text:");
            string text = Console.ReadLine();
            long totSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                long sum = 0;
                int startIndex = 0;
                int endIndex = text.Length;
                // Here, the program loops to define "startIndex" and "endIdex" to each line.
                for (int t = i; t < text.Length; t++)
                {
                    if (!char.IsDigit(text[i]) && i != text.Length - 1)
                    {
                        i++;
                        t++;
                    }
                    if (char.IsDigit(text[i]))
                    {
                        startIndex = i;
                    }
                    if (!char.IsDigit(text[t]) || (t > i && text[t - 1] == text[i] && t - 1 != i))
                    {
                        endIndex = t;
                        break;
                    }
                }
                //Here, checks the program if the current line has a value to both start-and endIndex.
                if (text[startIndex] == text[endIndex - 1] && startIndex != endIndex - 1 && char.IsDigit(text[startIndex]))
                {
                    int leanth = 0;
                    //Here, the program prints only the lines were confirmed to contain start-and endIndex.
                    for (int j = 0; j < text.Length; j++)
                    {
                        if (j == startIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        if (j == endIndex)
                        {
                            Console.ResetColor();
                        }
                        if (j >= startIndex && j < endIndex)
                        {
                            leanth++; //this is the leanth of Substing method.
                        }
                        Console.Write(text[j]);
                    }
                    string number = text.Substring(startIndex, leanth);                    
                    sum += long.Parse(number); //sum is the marked number in each line and it resets to 0 for each line.                   
                    totSum += sum; //totSum is the sum of all marked number in all lines.
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of all the marked numbers is: {totSum}");

        }
    }
}

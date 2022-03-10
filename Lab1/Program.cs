using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a random text: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            long totSum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                bool foundSubString = false;
                int startIndex = i;
                int endIndex = text.Length;

                if (!char.IsDigit(text[i])) continue;

                for (int t = i + 1; t < text.Length; t++)
                {
                    if (!char.IsDigit(text[t])) break;

                    if (text[i] == text[t])
                    {
                        endIndex = t + 1;
                        foundSubString = true;
                        break;
                    }
                }

                if (foundSubString)
                {
                    int leanth = 0;

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
                            leanth++;
                        }
                        Console.Write(text[j]);
                    }
                    string number = text.Substring(startIndex, leanth);
                    long sum = long.Parse(number);
                    totSum += sum;
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of all the marked numbers is: {totSum}");
        }

    }
}                   
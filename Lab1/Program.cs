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
                int startIndex = 0;
                int endIndex = text.Length;
                // Here, the program loops to define "startIndex" and "endIdex" to each line, if both found.
                for (int t = i; t < text.Length; t++)
                {
                    if (!char.IsDigit(text[i]) && i != text.Length - 1)
                    {
                        i++; // the values increses by 1 if it occurs letter, to pass it. 
                        t++;
                    }
                    if (char.IsDigit(text[i]))
                    {
                        startIndex = i;
                    }
                    if (!char.IsDigit(text[t]) || (t > i && text[t - 1] == text[i] && t - 1 != i))
                    {
                        endIndex = t;
                        foundSubString = true;
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
                    long sum = long.Parse(number); //sum is the marked number in each line and it resets to 0 for each line.                    
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
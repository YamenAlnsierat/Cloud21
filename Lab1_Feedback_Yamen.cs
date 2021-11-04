using System;

namespace lab3
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
                bool foundSubstring = false;
                int startIndex = i;                     // startIndex ska alltid vara i, så sätt den innan t-loopen.
                int endIndex = text.Length;

                if (!char.IsDigit(text[i])) continue;   // ... men om det inte är en siffra, fortsätt nästa varv i loopen
                
                for (int t = i + 1; t < text.Length; t++)
                {
                    if (!char.IsDigit(text[t])) break;  // Om tecken t inte är en siffra, avbryt innan foundSubstring sätts true

                    if (text[t] == text[i])             
                    {
                        foundSubstring = true;          // Här hittade vi tecknet vi letar efter ...
                        endIndex = t;                   // ... på index t
                        break;
                    }
                }

                // Logiken som fanns här tidigare upprepade egentligen samma sak du hade ovan. Blir enklare när vi bara kan kolla foundSubstring
                if (foundSubstring)
                {
                    // Om vi använder 3 st Substring så behövs ingen loop för utskriften
                    string start = text.Substring(0, startIndex);
                    string number = text.Substring(startIndex, endIndex - startIndex + 1);
                    string end = text.Substring(endIndex + 1);

                    long sum = long.Parse(number); // Nu deklareras variablen sum direkt när den sätts
                    totSum += sum; 

                    // Utskriftsloopen ersätts med 3 styck Console.Write:
                    Console.ResetColor();
                    Console.Write(start);
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(number);

                    Console.ResetColor();
                    Console.Write(end);

                    Console.WriteLine();                    
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of all the marked numbers is: {totSum}");
        }    
    }
}
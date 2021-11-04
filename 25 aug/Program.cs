using System;

namespace _25_aug
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoWhile();
            //forloop();
            //NastedFor();
            //MyArray();
            //Console.WriteLine(Methods(3,4));
        }
            
            static void DoWhile() 
            { 
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(i);

            } while (i < 10);
            
            }

            static void forloop()
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            }

            static void NastedFor()
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        for (int y = 0; y < 5; y++)
                        {
                            Console.Write("o");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }

            static void MyArray()
            {
                int[] numbers = new int[5] {1,2,3,4,5};
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"index {i} har vardet {numbers[i]}");
                }
                foreach (var i in numbers)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("red\nrad2\tEfter tap\\");
                Console.WriteLine(@"red\nrad2\tEfter tap\\");
            }

            static int Methods(int a, int b)
            {
                return a + b;
            }
    }
}

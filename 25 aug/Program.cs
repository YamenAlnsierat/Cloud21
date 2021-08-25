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
            PatternLoop();
            
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

            static void PatternLoop()
            {
                /*for (int i = 0; i < 4; i++)
                {
                    for (int b = 0; b < 8; b++)
                    {
                        if (b==i || b==i)
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
                        if (b == i*2)
                        {
                            Console.Write("#");
                        }
                        else if (b==i*2+1)
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
                Console.WriteLine("C");*/


                for (int i = 1; i < 5; i++)
                {
                    for (int b = 1; b < 9; b++)
                    {
                        if (b+2 == 2*i)
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
            }
        }
    }
}

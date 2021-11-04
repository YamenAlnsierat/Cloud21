using System;

namespace _22_sep3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.OneTo100 = -199;
            Console.WriteLine(MyClass.OneTo100);
        }
    }
    public class MyClass
    {
        private static int number;

        public static int OneTo100 
        {
            get 
            {
                return number;
            }
            set
            {
                //number = Math.Clamp(value, 0, 100);
                number = value < 0 ? 0 : (value > 100 ? 100 : value);
            } 
        }
    }
}

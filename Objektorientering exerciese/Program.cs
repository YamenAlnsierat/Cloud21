using System;

namespace Objektorientering_exerciese
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // NR32
            //VattenGlas glas = new VattenGlas();
            //glas.BreakGlas();
            //glas.FillGlas();
            //glas.EmbtyGlas();
            //glas.EmbtyGlas();
            //glas.FillGlas();
            //glas.FillGlas();
            //glas.EmbtyGlas();
            //glas.EmbtyGlas();



            // NR33
            //Car honda = new Car("civic", 200000, "blue");
            ////honda.whatModel = "Civic";
            ////honda.whatPrice = 200000;
            ////honda.whatColor = "blue";
            ////honda.halvPrice();
            //Console.WriteLine($"My favo car is {honda.whatModel} with {honda.whatColor} color but it costs {honda.whatPrice} ><\" ");
            //Console.WriteLine();
            //Car aCar = new Car();
            //Console.WriteLine($"aCar has {aCar.whatModel} model."); 



            //NR34
            //HealthCare mySteps = new HealthCare();
            //Console.WriteLine("This is a stepcounter at max 1000 steps. \nIf you want to reset steps enter \"r\" \n");
            //while (mySteps.steps < 1000)
            //{
            //    if (Console.ReadKey().Key == ConsoleKey.R)
            //    {
            //        mySteps.ResetSteps();
            //    }
            //    else
            //    {
            //        mySteps.Step();
            //    }
            //    Console.WriteLine(mySteps.steps);
            //}


            //NR35
            //RedAndBlue rb = new RedAndBlue();
            //rb.Blue = 87.5f;
            //Console.WriteLine(rb.Red);
            //rb.Red = 10;
            //Console.WriteLine(rb.Blue);



            //NR36
            //Person p1 = new Person(" ", " ");



            //NR37+NR38
            Bil honda = new Bil();
            //Console.WriteLine($"color is {honda.myColor} and leangth is {honda.SetLeangth}");
            //Bil.getSameTenCars("Honda");



            //NR41
            //OneToOneHundred.OneTo100 = -199;
            //Console.WriteLine(OneToOneHundred.OneTo100);



            //NR42
            //Revers.Text = "Yamen";
            //Console.WriteLine(Revers.Reverse);


        }

        class Bil
        {
            private int leanth;
            private ConsoleColor color;
            //private string car;

            public int SetLeangth
            {
                get
                {
                    int[] leanth = {3, 4, 5};
                    Random slump = new Random();
                    int varde = slump.Next(0, leanth.Length);
                    return leanth[varde];
                }
                set
                {
                    leanth = value;
                }
            }

            public ConsoleColor myColor 
            {
                get
                {
                    ConsoleColor[] color = {ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.Green, ConsoleColor.DarkYellow};
                    Random slump = new Random();
                    int varde = slump.Next(0, color.Length);
                    return color[varde];
                }
                set
                {
                    color = value;
                }
            }

            //public static Bil[] getSameTenCars (string car)
            //{
            //    int _leangth = 4;
            //    return Console.WriteLine();
            //}

            //public Bil(ConsoleColor color)
            //{
            //    this.color = color;
            //}
        }
    }
}

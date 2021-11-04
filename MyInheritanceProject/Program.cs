using System;

namespace MyInheritanceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop microsoft = new Laptop() {Model = "SurFace pro7 ", Year_Model = 2017};
            Console.WriteLine(microsoft.Model + microsoft.Year_Model);

            Console.WriteLine();

            PC MSI = new PC() {Model = "Albest", Year_Model = 2019};
            Console.WriteLine(MSI.Year_Model);

            Console.WriteLine();

            Hybrid_laptop myMicrosoft = new Hybrid_laptop() { Model = "SP7", weight = 1.2};
            Console.WriteLine($"Your Laptop {myMicrosoft.Model} is {myMicrosoft.weight} kg");
            myMicrosoft.TakeOffKeyboard();
            Console.WriteLine(myMicrosoft.weight);
            myMicrosoft.putOnKeyboard();
            Console.WriteLine(myMicrosoft.weight);
        }
    }

    class Computer
    {
        public string Model;
        public int Year_Model;
        public double prossesor;
        public int storage;
        public double price;
        public double graphicCard;
        public double weight;
        public int BattryLife;
        public double size;

        public bool TurnedOn = true;
        public bool broken = false;

        public void TurnOn()
        {
            if (!broken)
            {
            Console.WriteLine("The device is turning on.");
            TurnedOn = true;
            }
            else
            {
            Console.WriteLine("Device is broken");
            }
        }
        public void TurnOff()
        {
            Console.WriteLine("The device is turning off.");
            TurnedOn = false;
        }

    }

    class Laptop : Computer
    {
        public bool touch = false;

        public void PutInCase()
        {
            if (TurnedOn)
            {
                Console.WriteLine("Turn off device first!");
            }
            else
            {
                Console.WriteLine("Device is home.");
            }
        }
    }
    class PC : Computer
    {
        private string keyBoeard;
        private string Mouse;


    }
    class SmartPhone : Computer
    {
        private int durability;
        private int camera;

        public void DropPhone()
        {
            Console.WriteLine($"Device got broken!");
            broken = true;
        }
    }

    class Hybrid_laptop : Laptop
    {
        public void TakeOffKeyboard()
        {
            Console.WriteLine("Your device is in table-mode.");
            touch = true;
            weight -= 0.3;
        }
        public void putOnKeyboard()
        {
            Console.WriteLine("your device in laptop/mode");
            touch = false;
            weight += 0.3;
        }
    }
}

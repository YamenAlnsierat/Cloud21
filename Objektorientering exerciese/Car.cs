using System;

namespace Objektorientering_exerciese
{
    class Car
    {
        private string model;
        private double price;
        private string color;

        public string whatModel
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public double whatPrice
        {
            get 
            {
                return price;
            }
            set
            {
                price = value;
            } 
        }
        public string whatColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public Car()
        {
            model = "unknown";
            price = 120000;
            color = "rose";
        }
        public Car(string model, double price, string color)
        {
            this.model = model;
            this.price = price;
            this.color = color;
        }

        public void halvPrice()
        {
            price /= 2;
            Console.WriteLine(price);
        }
    }
}

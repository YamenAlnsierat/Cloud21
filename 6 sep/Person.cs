using System;
using System.Collections.Generic;
using System.Text;

namespace _6_sep
{
    class Person
    {
        private string firstName = "Mr.NoBody";
        public double length;
        public double weight;

        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double BMI {
            get
            {
                return weight / (length * length);
            }
            //set; 
        }

        public void PrintGreeting()
        {
            Console.WriteLine($"Hello, {firstName} {lastName}");
        }

        public void SetFirstName(string name)
        {
            this.firstName = name.ToUpper();
        }
        public string GetFirstName()
        {
            return this.firstName;
        }
    }
}

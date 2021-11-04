using System;

namespace _6_sep
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("nn", 3.4);
            Cat myOtherCat = new Cat("mm", 4.3, "asd123");

            myCat.name = "Megalo";
            myCat.weight = 4.5;
            myOtherCat.setPassword("eee");

            Console.WriteLine($" My cat name is {myCat.name} and its weight is {myCat.weight}");
            Console.WriteLine($" My cat name is {myOtherCat.name} and its weight is {myOtherCat.weight}");

            Console.WriteLine(myCat.TellPassWord());
            Console.WriteLine(myOtherCat.TellPassWord());

            Console.WriteLine();

            Person person1 = new Person();
            person1.SetFirstName("Yamen");
            person1.LastName = "Al";
            person1.length = 1.77;
            person1.weight = 82;

            string firstName = person1.GetFirstName();
            string _lastName = person1.LastName;

            //Yamrn.BMI = 25;
            Console.WriteLine($"BMI = {person1.BMI}");

            Person person2 = new Person() { length = 5.6, weight = 82};
            person2.SetFirstName(firstName);

            person1.PrintGreeting();
            person2.PrintGreeting();
        }
    }

    class Cat
    {
        public string name;
        public double weight;
        private string passWord;

        public Cat()
        {
            this.name = "Badass";
        }
        public Cat(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public Cat(string name, double weight, string passWord)
        {
            this.name = name;
            this.weight = weight;
            this.passWord = passWord;
        }
        public string TellPassWord()
        {
            return passWord;
        }
        public void setPassword(string newPassword)
        {
            passWord = newPassword;
        }
    }
}

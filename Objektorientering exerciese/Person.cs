namespace Objektorientering_exerciese
{
    partial class Program
    {
        class Person
        {
            private string firstName;
            private string lastName;          
            private string Name;

            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
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
            public string _Name
            {
                get
                {
                    return Name;
                }
                //set; 
            }

            public Person(string fristName, string lastName)
            {
                this.firstName = fristName;
                this.lastName = lastName;
            }

        }
    }
}

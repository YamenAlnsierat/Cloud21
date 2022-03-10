using System;

namespace _11_15_training
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    static class PerttierText
    {
       public static string Title(this String text)
        {
            var FirsetLetter = text.Substring(0, 1);
            var rest = text.Substring(1);  
            return FirsetLetter.ToUpper() + rest.ToLower(); 
        }

        public static string GetWord(this String text, int index)
        {
            if (index < 0 || index >= text.Length -1) throw new Exception(" ");

            else return text.Split(' ')[index];
        }
    }
}

class person
{
    public string FristName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }

    public person()
    {
        Title = "Mr.";
        FristName = "Yamen";
        LastName = "Al";
    }

    public person(string fristName)
    {
        FristName = fristName;
    }

    public person(string fristName, string lastName, string title)
    {
        FristName = fristName;
        LastName = lastName;
        Title = title;
    }

    public person(string fristName, string lastName)
    {
        FristName = fristName;
        LastName = lastName;
    }
}

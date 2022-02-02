using System;

public class Program
{
    public static void Main(string[] args)
    {
        int total = 3;
        Person[] p = new Person[total];

        for (int i = 0; i < total; i++)
        {
            p[i] = new Person() {
                Name = Console.ReadLine()
            };
        }

        for (int i = 0; i < total; i++)
        {

            Console.WriteLine(p[i].ToString()); 
        }
        Console.ReadKey();
    }

#region Person
    public class Person
    {
        public string Name { get; set; }
        
        public Person (string n)
        {
            this.Name = n;
        }

        ~Person()
        {
            Name = string.Empty;
        }
        

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }

    }
#endregion


}
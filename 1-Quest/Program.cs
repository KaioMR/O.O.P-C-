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

    public class Person
    {
        public string Name { get; set; }
        
        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}
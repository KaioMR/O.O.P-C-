using System;

public class StudentProfessorTest
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Greet();
        
        Student s1 = new Student();
        s1.SetAge(15);
        s1.Study();
        s1.Greet();
        s1.ShowAge();

        Teacher t1 = new Teacher();
        t1.SetAge(37);
        t1.Greet();
        t1.Explain();
    }
}

#region Person
    public class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void SetAge(int age1)
        {
            this.age = age1;
        }
    }
#endregion

#region Student
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studing");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }
#endregion

#region Teacher
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
#endregion
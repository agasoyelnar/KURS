using System;
using MyApp.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Teacher t1 = new Teacher(
            "user1",
            "Nikola",
            "Tesla",
            "IT",
            "Programming",
            new DateTime(1990, 5, 10),
            "Baku",
            "0501111111",
            "tesla@mail.com",
            "12345"
        );

        
        Teacher t2 = new Teacher(
            "",
            "Aliyeva",
            "leyla@mail.com",
            "pass",
            "leyla123",
            "0552222222"
        );

        
        Teacher t3 = new Teacher(
            "Rashad",
            "Huseynov",
            "rashad@mail.com",
            "pass123",
            "rashad01",
            new DateTime(1985, 3, 20),
            "Math"
        );

        
        Console.WriteLine("---- T1 ----");
        Console.WriteLine(t1.GetName());
        Console.WriteLine(t1.GetSubject());
        Console.WriteLine(t1.GetContact());

        Console.WriteLine("---- T2 ----");
        Console.WriteLine(t2.GetTeacher());
        Console.WriteLine(t2.GetContact());

        Console.WriteLine("---- T3 ----");
        Console.WriteLine(t3.GetTeacher());
        Console.WriteLine(t3.GetBirthdate());
        Console.WriteLine(t3.GetSubject());
    }
}
using System;

namespace KURS
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher(
                1,
                "Jale",
                "Mammadova",
                "C#",
                "mid level programmer",
                "BP101",
                new DateTime(1990, 5, 10),
                "Baku",
                "0501234567",
                "ali@gmail.com",
                "12345"
            );

            Console.WriteLine("Teacher Name: " + teacher1.Name);
            Console.WriteLine("Surname: " + teacher1.Surname);
            Console.WriteLine("Subject: " + teacher1.Subject);
            Console.WriteLine("Username: " + teacher1.Username);
            Console.WriteLine("Group Number: " + teacher1.GroupNumber);
            Console.WriteLine("Birth Date: " + teacher1.BirthDate.ToShortDateString());
            Console.WriteLine("Address: " + teacher1.Address);
            Console.WriteLine("Phone: " + teacher1.PhoneNumber);
            Console.WriteLine("Email: " + teacher1.Email);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
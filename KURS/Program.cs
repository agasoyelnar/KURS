using KURS.Models;

Student telebe = new Student(
    "huseynov55",
    "Hüseyn",
    "Hüseynov",
    101,
    2000,
    "Bakı ş.",
    "+994550000000",
    "huseyn@mail.com",
    "pass123",
    95
);

Console.WriteLine(telebe.GetName());
Console.WriteLine(telebe.GetGroup());
Console.WriteLine(telebe.GetStudent());
Console.WriteLine(telebe.GetEmail());
Console.WriteLine(telebe.GetBirthDay());
Console.WriteLine(telebe.GetContact());

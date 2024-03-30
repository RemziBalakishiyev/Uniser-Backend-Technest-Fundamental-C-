using _08.Ders_Inheritance_and_Interfaces_.Interfaces;

namespace _08.Ders_Inheritance_and_Interfaces_.Classes;

internal class Student:Person,IPerson
{

    public string GroupName { get; set; }

    public void Add()
    {
        Console.WriteLine($"{Id} student added");
    }

    public void GetData()
    {
        Console.WriteLine("Student get data");
    }
}

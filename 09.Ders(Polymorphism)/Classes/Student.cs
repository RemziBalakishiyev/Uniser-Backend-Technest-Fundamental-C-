namespace _09.Ders_Polymorphism_.Classes;

internal class Student:Person
{
    public string GroupNumber { get; set; }

    public override void ShowInformation()
    {
        Console.WriteLine("Student class is work!");
    }

}

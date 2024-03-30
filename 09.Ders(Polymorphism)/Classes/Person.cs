namespace _09.Ders_Polymorphism_.Classes;

internal class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public virtual void ShowInformation()
    {
        Console.WriteLine("Class is work");
    }
}

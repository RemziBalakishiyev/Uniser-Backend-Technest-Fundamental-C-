namespace _08.Ders_Inheritance_and_Interfaces_.Classes;

internal class Person
{
    public Person()
    {
        Console.WriteLine("Person Constructor is work");
    }

    public Person(string msg)
    {
        Console.WriteLine(msg);
    }
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; }
    public string LastName { get; set; }




  

}

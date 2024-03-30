using _08.Ders_Inheritance_and_Interfaces_.Interfaces;

namespace _08.Ders_Inheritance_and_Interfaces_.Classes;

internal class Teacher : Person, IPerson, IEmployee
{


    public Teacher()
    {
        Console.WriteLine("Teacher constructor is work");

    }

    public Teacher(string msg) : base(msg)
    {

    }
    private int salary;

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 250 || value > 20000)
            {
                throw new ArgumentException("Salary is invalid");
            }
        }
    }

    public int Exprience { get; set; }

    public double NetSalary()
    {
        return Salary - (Salary * 0.04);
    }


    public void Test()
    {
        this.NetSalary();
    }

    public void GetData()
    {
        Console.WriteLine("Teacher Get Data");
    }

    public void Add()
    {
        Console.WriteLine($"{Id} teacher added");
    }
}

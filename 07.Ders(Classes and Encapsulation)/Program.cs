



#region Classes
//using System.Threading.Channels;

////Student bruce = new Student();



////bruce.firstName = "Bruce";
////bruce.lastName = "Wayne";
////bruce.age = 50;

////bruce.PrintHello();


////Company uniser = new Company();


////uniser.ShowCompanyInfo();

////uniser.companyName = "Uniser IT Academy";
////uniser.address = "Besti Baghirova 2a";
////uniser.countOfEmployee = 20;

//Company uniserGroup = new Company("Uniser Group LLC", "Karat business center");

//uniserGroup.ShowCompanyInfo();



//Student student = new Student();

//Console.WriteLine(student.firstName);

#endregion





using _07.Ders_Classes_and_Encapsulation_.Classes;

Student student = new();

Console.WriteLine(student.secretKey);

student.id = -100;
student.SetAge(100);


Console.WriteLine(student.GetAge());
student.FirstName = "Nezrin";

Console.WriteLine(student.FirstName);

student.GetInformation();


Employee walter = new Employee();
Console.WriteLine(walter.Id);


walter.FirstName = "Walter";
walter.LastName = "White";

walter.Salary = 4000;

Console.WriteLine($"ID: {walter.Id} \t FullName{walter.FullName} \t Salary {walter.Salary} ");

class Student
{

    public int id;
    public string secretKey;
    private string firstName;
    public string lastName;
    private int age;



    public string FirstName
    {
        get
        {
            return $"Mr {this.firstName}";

        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("First name is invalid");
            }

            firstName = value;
        }
    }

    public Student()
    {
        Console.WriteLine("Constructor method is work");
        secretKey = ";qk432k4po30-r-e-23";


    }


    public void SetAge(int age)
    {
        if (age < 0 || age > 150)
        {
            throw new ArgumentException("Age is invalid");

        }

        this.age = age;
    }


    public int GetAge()
    {
        return this.age;
    }

    public void PrintHello()
    {
        Console.WriteLine("Hello world!");
    }

    public void GetInformation()
    {
        Console.WriteLine($"Id : {this.id} age : {this.age}");
    }
}

class Company(string companyName, string address)
{
    public string _companyName = companyName;
    public string _address = address;
    public int _countOfEmployee;


    public void ShowCompanyInfo()
    {
        Console.WriteLine($"Name : {_companyName}");
        Console.WriteLine($"Address : {_address}");
    }
}

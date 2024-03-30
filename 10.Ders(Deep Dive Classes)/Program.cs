

//Database database = new Database();
//Console.WriteLine(Database.secret_keyword);
//Console.WriteLine(Math.Tau);
//class Database
//{
//    public const string secret_keyword = "secret keyword";

//    public readonly string newKeyword = "new secret keyword";


//    public Database()
//    {
//        newKeyword = "asd";
//    }
//}
//using _10.Ders_Deep_Dive_Classes_.Extensions;
//int a = 20;

//string name = "Ramzi";
//int typeOfUser = 2;
//Console.WriteLine((int)UserTypes.teacher);
//switch (typeOfUser)
//{
//    case (int)UserTypes.user:
//        Console.WriteLine("Istifadeci girishi");
//        break;

//    case (int)UserTypes.teacher:
//        Console.WriteLine("Muellim girishi");
//        break;

//    case (int)UserTypes.student:
//        Console.WriteLine("Telebe girishi");
//        break;
//    default:
//        break;
//}
using Uniser;

Teacher teacher = new Teacher();


Employee employee1 = new Employee();
Employee employee2 = new Employee();







class Employee
{
    public readonly static string[] specialies;

    public Employee()
    {

        Console.WriteLine("Ctor is work");
    }

    static Employee()
    {

        specialies = ["Backend", "Front end", "Full stack"];
        Console.WriteLine("Static ctor is work");
    }

    public string Id { get; private init; } = Guid.NewGuid().ToString();

    public string FullName { get; init; }

    public double Salary { get; init; }


    public virtual double GetNetSalary()
    {
        return Helper.GetNetSalary(Salary);
    }
}






public record User(string UserName, string Mail, string job);




enum UserTypes
{
    /// <summary>
    /// Istifadeci girishi ucun
    /// </summary>
    user = 1,

    /// <summary>
    /// Muellim girishi ucun
    /// </summary>
    teacher = 2,

    student = 3
}
static class Helper
{
    public const double tax = 0.04;



    public static double GetNetSalary(double enteredSalary)
    {
        return enteredSalary - (enteredSalary * Helper.tax);
    }



}



namespace Uniser
{
    partial class Teacher
    {

        public Teacher()
        {
            Console.WriteLine("Teacher first");
        }
        public string Id { get; private set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public double Salary { get; set; }

        public void Add()
        {
            Console.WriteLine("Teacher added");
        }




    }

    partial class Teacher
    {

        public Teacher(string teacher)
        {
            Console.WriteLine("Teacher first");
        }
        public void CalcSalary()
        {
            Console.WriteLine("Salary was caclculated");
        }
    }
}


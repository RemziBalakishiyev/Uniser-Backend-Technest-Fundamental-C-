namespace _07.Ders_Classes_and_Encapsulation_.Classes;

internal class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private double salary;

    public double Salary
    {
        get { return salary - (salary * 0.4); }
        set
        {
            if (value > 10000 || value < 250)
            {
                throw new ArgumentException("Salary is invalid!");
            }

            salary = value;

        }
    }


    public string Id { get; private set; } = Guid.NewGuid().ToString();

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    

}

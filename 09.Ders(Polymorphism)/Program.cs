

using _09.Ders_Polymorphism_.Classes;

Student student = new Student();

student.ShowInformation();

Teacher teacher = new Teacher();
teacher.ShowInformation();

Person teacher2 = new Teacher();
Person student2 = new Student();

Console.WriteLine(
ShowFullName(new Teacher
{
    FirstName = "Bruce",
    LastName = "Wayne"
}));

Console.WriteLine(ShowFullName(new Student
{
    FirstName = "Jamie",
    LastName = "Lannister"
}));



string ShowFullName(Person person)
{
    return person.FirstName + " " + person.LastName;
}


Person[] people = [new Student(), new Teacher()];
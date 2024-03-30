

using _08.Ders_Inheritance_and_Interfaces_.Classes;
using _08.Ders_Inheritance_and_Interfaces_.Interfaces;

Teacher teacher = new Teacher("Teacher message")
{
    FirstName = "Walter",
    LastName = "Lastname",
    Salary = 2000
};

Student student = new Student
{
    FirstName = "Bruce",
    LastName = "Wayne",
    GroupName = "Technest"
};

Person person = new Person();

person.FirstName = "John";
person.LastName = "Wick";


//Person person1 = new Student();
//Person person2 = new Teacher();


student.GetData();
teacher.GetData();


IPerson person1 = new Student();
IPerson person2 = new Teacher();

person1.Add();
person2.Add();




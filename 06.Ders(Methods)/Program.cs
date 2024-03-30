

int[] number1 = { 1, 2, 3, 4, 5, 6 };
SumOfArray(1, number1);

int[] number2 = { 2, 3, 4, 5, 6, 7 };
SumOfArray(1, number2);

int[] number3 = { 2, 2, 3, 54, 56, 6, 6, 7 };
SumOfArray(1, number3);

Console.WriteLine(SumOfArray(2, 1, 23, 4, 5, 5, 6));


int SumOfArray(int divisibleNum, params int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % divisibleNum == 0)
        {
            sum += numbers[i];
        }
    }

    return sum;
}


//Console.WriteLine(SumOfNumberMultpNum(multpNum:10));
//Console.WriteLine(SumOfNumberMultpNum(456, 2));


//int SumOfNumberMultpNum(int number=456, int multpNum=1)
//{

//    int sumReminder = 0;
//    while (number > 0)
//    {
//        sumReminder = sumReminder + (number % 10);
//        number = number / 10;
//    }

//    return sumReminder * multpNum;
//}





//GetInformation(firstName, age);
//GetInformation( age);
//GetInformation(firstName, lastName, age);

int Ten() => 10;


MyClass myClass = new();
myClass.Main();

Console.WriteLine();



internal class MyClass
{


    public void Main()
    {
        string firstName = "Bruce", lastName = "Wayne";
        int age = 20;
        GetInformation(age);
        GetInformation(firstName, lastName);
        GetInformation(firstName, lastName, age);
    }
    void GetInformation(string firstName, string lastName)
    {
        Console.WriteLine($"{firstName} {lastName}");
    }


    void GetInformation( int age , string firstName,)
    {
        Console.WriteLine($"{firstName} {age}");
    }

   


    void GetInformation(int age)
    {
        Console.WriteLine($" {age}");
    }
    void GetInformation(string firstName, string lastName, int age)
    {
        Console.WriteLine($"{firstName} {lastName} {age}");
    }
}








// metodun tipi - void MethodName() { }

//SayHello();
//SayHello();
//SayHello();
//SayHello();
//SayHello();
//SayHello();
//SayHello();

//void SayHello()
//{
//    Console.WriteLine("Hello World");
//    Console.WriteLine("Hello World");
//    Console.WriteLine("Hello World");
//    Console.WriteLine("Hello World");
//}


//int num1 = 13, num2 = 16;
//int num3 = 45, num4 = 55;
//int num5 = 50, num6 = 60;


////SumNumber(10,20);
////SumNumber(11,11);
////SumNumber(numberTwo:45,numberOne:35);



//int SumNumber(int numberOne,int numberTwo)
//{
//    Console.WriteLine(numberOne + numberTwo);
//    return numberOne + numberTwo;
//}



//if(SumNumber(num1,num2) > 0)
//{
//    SumNumber(num3, num4);
//}
//else
//{
//    SumNumber(num5, num6);
//}







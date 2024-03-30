using static System.Console;
using static System.Convert;

#region Input data to Program
// Console hissədən dəyəri daxil etmək üçün Console.Readline() ifadəsi işləyir.
// Qeyd daxil edilən dəyər string tipində olur.
// 

Console.WriteLine("Write your age : ");
//string value =  Console.ReadLine(); // == Cmd - den gelen deyer
//int number = Convert.ToInt32("A");
//string textNumber = Convert.ToString(22);
////Console.WriteLine(number + 10) ;
//Console.Write("Write your age : ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(age + 10);
#endregion

#region Condition operators
// boolean ,   >, !,  == , || , && operators 

//Console.WriteLine(1 < 5);
//Console.WriteLine(5 <= 5);
//Console.WriteLine(5 == 2);
//Console.WriteLine(!true);
//Console.WriteLine(5!=2);


//Console.WriteLine(10 > 3 && 10 > 1);
//Console.WriteLine(10 > 3 || -3 > 1);


#endregion

#region If Else
// If and Else statements



//{
//    int numberTwo = 20;
//    Console.WriteLine(numberTwo);
//    Console.WriteLine(number);

//    {
//        string name = "Bruce";
//        Console.WriteLine(name);
//    }


//}



//int number = -10;

//if (number > 0 )
//{
//    Console.WriteLine("Conditions is true");
//}
//else
//{
//    WriteLine("Eded menfidir");

//}

//WriteLine("Type role : ");
//string role = ReadLine();

//if (role == "admin")
//{
//    WriteLine("Your role is admin");
//}
//else
//{
//    WriteLine("System not found!");
//}


//WriteLine("Task is completed");
#endregion

#region Else-If
// Else If Statements 
// Niyə istifadə etməliyik?



Write("Type role : ");
string role = ReadLine();

//user / teacher / admin 

//if (role == "admin")
//{
//    WriteLine("Admin rolundadir");
//}
//else if (role == "teacher")
//{
//    WriteLine("Muellim rolundadir");
//}
//else if (role == "user")
//{
//    WriteLine("Istifadeci rolundadir");
//}
//else
//{
//    WriteLine("Rol tapilmadi");
//}

//* Practice

//Write("Type login : ");
//string enteredLogin = ReadLine();
//Write("Type password : ");
//string enteredPassword = ReadLine();


//string realLogin = "uniser";
//string realPassword = "it123";


////if (enteredLogin == realLogin && enteredPassword != realPassword)
////{
////    WriteLine("Shifre yanlishdir!");
////}
////else if (enteredLogin != realLogin && enteredPassword == realPassword)
////{
////    WriteLine("Istifadeci tapilmadi!");
////}
////else if (enteredLogin == realLogin && enteredPassword == realPassword)
////{
////    WriteLine("Sisteme daxil oldunuz!");
////}
////else
////{
////    WriteLine("Sisteme daxil ola bilmezsiniz!");
////}


//int number = ToInt32(ReadLine());

//if (number % 2 == 0)
//{
//    WriteLine($"{number} ededi cutdur");
//}
//else
//{
//    WriteLine($"{number} ededi tekdir");
//}
//#endregion

//#region Nested If
//WriteLine("Terefleri Daxil edin");
//int side1 = ToInt32(ReadLine()), side2 = ToInt32(ReadLine()), side3 = ToInt32(ReadLine());

//if (side1 > 0 && side2 > 0 && side3 > 0)
//{
//    if (side1 < side2 + side3 || side2 < side1 + side3 || side3 < side1 + side2)
//    {
//        Console.WriteLine("Ucbucaq movcuddur");
//    }
//}


#endregion



#region Ternary Operators


int num = -3;
//string message;
//if (num > 0)
//{
//    message = "Musbet";
//}
//else
//{
//    message = "Menfi";
//}


//string message = num > 0 ? "Musbet" : "Menfi";

//WriteLine(message);
#endregion

//string grade = "B";


////if (grade == "B")
////{
////    Console.WriteLine("Zerbeci");
////}
////else if (grade == "A")
////{
////    WriteLine("Elaci");
////}
////else if (grade == "C")
////{
////    WriteLine("Adi");
////}
////else
////{
////    WriteLine("Kesr");
////}


//switch (grade)
//{
//    case "A":
//        WriteLine("Elaci");
//        break;
//    case "B":
//        WriteLine("Zerbeci");
//        break;
//    case "C":
//        WriteLine("Adi");
//        break;
//    default:
//        WriteLine("Kesr");
//        break;
//}

WriteLine("Ededleri daxil edin");
int numberOne = ToInt32(ReadLine());
int numberTwo = ToInt32(ReadLine());

WriteLine("Ifadelerden birini daxil edin  (+, - , * , /)");
Write("Ifade : ");
char calcOperator = ToChar(ReadLine());

switch (calcOperator)
{
    case '+':
        WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
        break;
    case '-':
        WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
        break;
    case '*':
        WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
        break;
    case '/':
        WriteLine($"{numberOne} / {numberTwo} = {numberOne / numberTwo}");
        break;
    default:
        WriteLine("Bele bir ifade yoxdur");
        break;
}

#region
//Switch case
#endregion
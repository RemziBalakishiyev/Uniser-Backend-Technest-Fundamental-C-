using System;


Console.WriteLine("Uniser It Academy");


// CTRL + K +  C -- comment
// CTRL + K + U -- uncomment
Console.WriteLine("Backend Tutorial");

// deyisenin_tipi deyisenin_adi = 13;
#region Tam ededler
// Tam ədədlər - ınt, short , long

//int numberOne = 10; // 32 bit
//short numberTwo = 11;// 16 bit
//long numberThree = 12;// 64 bit  



//Console.WriteLine(numberOne);
//Console.WriteLine(numberTwo);
//Console.WriteLine(numberThree);


//Console.WriteLine(int.MinValue);
//Console.WriteLine(int.MaxValue);
//Console.WriteLine(short.MaxValue);
//Console.WriteLine(short.MinValue);
//Console.WriteLine(long.MaxValue);
//Console.WriteLine(long.MinValue);

//short numberFour = 32768;

#endregion

// Natamam ededler -  float, double, decimal

#region Natamam ededler
//double numberFive = 5.7;

//float numberSix = 6.3F;

//decimal numberThree = 7.90M;


//double numberFour = 9.3;

//double numberSeven = numberFour;


//int number1;


//number1 = 12;

//Console.WriteLine(number1);

//number1 = 13;

//Console.WriteLine(number1); 
#endregion

// Metinsel tek simvollar üçün  -  char

char className = 'A';

// Metinsel ifadeler üçün  -  string

//string firstName = "Bruce";

//string text = "10 @#$ R";

//// Mentiqi ifadeler üçün bool

//bool isStudent = true;



//int sum = 10 + 15;
//int substract = 20 - 8;
//int multp = 10 * 10;
//int divided = 100 / 20;
////double remaind = (13.0) / (5.0);
//int remaind =13 %  5;
//Console.WriteLine(sum);
//Console.WriteLine(substract);
//Console.WriteLine(multp);
//Console.WriteLine(remaind);

// CTRL +  K +  D
int numberOne = 10;
int numberTwo = 5;
int numberThree = 20;


Console.WriteLine(numberOne);

numberTwo = numberOne;

numberOne = numberTwo + numberThree;

numberThree = numberTwo + 10;





int number1 = 5, number2 = 4, number3 = 2;

number1 = 5 + number2 * number3;


number3 = number1 + number2;

number2 = number3 - 1 + number3;

number1 = 10;







string firstName = "Bruce";
string lastName = "Wayne";

int age = 20;
string fullName = firstName +" " + lastName;
Console.WriteLine(fullName);

Console.WriteLine("My name is "+fullName+" and i am "+age+" y.o");


Console.WriteLine("My name is {0}  and i am {1} y.o",fullName,age);


// String interpolation 
Console.WriteLine($"My name is {fullName}   and i am {age} y.o");

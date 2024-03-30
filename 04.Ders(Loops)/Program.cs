
#region While Loops

//int index = 0;
//while (index < 5)
//{
//    Console.WriteLine("Uniser");
//    Console.WriteLine($"Index = {index}");
//    index++; // index += 1 , index++;



//}

//int countOfLoops = 1;

//while (countOfLoops <= 10)
//{
//    Console.WriteLine(countOfLoops);
//    countOfLoops += 2;
//}

//Console.WriteLine("Count of Loops : {0}", countOfLoops);
#endregion



#region Do While Loops


string password;


//do
//{
//    Console.Write("Type your password : ");
//    password = Console.ReadLine();
//} while (password != "uni123");

#endregion

#region For Loops

//
//int index = 0;
//while (index<10)
//{
//    index+=2
//}

//for (int index = 0; index < 10; index += 2)
//{
//    Console.WriteLine($"index : {index}");
//}



#endregion
#region For with conditions
// -10  -  10 arasinde 5 ve ya 2 bolunen ededlerin sayini


//int count = 0;

//for (int i = -10; i <= 10; i++)
//{
//    if ((i % 2 == 0 || i % 5 == 0) && i != 0)
//    {
//        Console.WriteLine(i);
//        count++;
//    }
//}

//Console.WriteLine($"Count :{count} ");
#endregion

#region Break , Continue , Go to

//int sum = 0;
//int index = 0;

//while (true)
//{
//    //index+=5;
//    sum += 5;
//    Console.WriteLine(sum);
//    if (sum == 20)
//    {
//       break;
//    }
//}

//for (int i = 0; i < 100; i++)
//{

//    if (i == 20)
//    {
//        //break;

//        continue;
//    }
//    Console.WriteLine(i);

//}

repeat:
//Console.WriteLine(" Choose your operation ");
//Console.WriteLine("1 . Exit ");
//Console.WriteLine("2 . Repeat ");

//Console.Write("Operation : ");
//string operationName = Console.ReadLine();

//switch (operationName)
//{
//    case "1":
//        Console.WriteLine("Exit operation is work !");
//        break;
//        case "2":
//        goto repeat;
//    default:
//        break;
//}




#endregion

#region Nested For Loops


//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.WriteLine($"i = {i} j = {j} ");
//    }
//}
#endregion


#region Practice
// 1. Verilmish ededin reqemlerinin cemin tapin


//int numberOne = 2345;
//int countOfNumberOne = 0;
//int sumOfNumberOne = 0;
//int reminder;
//while (numberOne != 0)
//{
//    reminder = numberOne % 10;
//    numberOne = numberOne / 10;

//    countOfNumberOne++;
//    sumOfNumberOne += reminder;
//}



//Console.WriteLine($"Count of {numberOne} is {countOfNumberOne}");

//Console.WriteLine("Sum : {0}",sumOfNumberOne);

// Eded =  2345;


// 2. Secret number


// 3. 2 -  20 arasinda Ededlerin cemini tapan proqram  yazin. 
//int sum = 0;
//for (int i = 2; i <= 20; i++)
//{


//    if (i % 2 ==0)
//    {
//        Console.WriteLine(i);
//        sum += i;
//        Console.WriteLine($"Sum in Loop :  {sum}");
//    }

//}

//Console.WriteLine("Result : " + sum);


// 4. Duzbucaqli ucbucaq yaradin '*' vasitesile


for (int i = 1; i < 5; i++)
{
    for (int j = 1; j <=i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
// 5 .  Vurma cedveli

//for (int i = 1; i <= 9; i++)
//{
//    for (int j = 1; j < 9; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i*j}");
//    }
//    Console.WriteLine("---------------");
//}
#endregion




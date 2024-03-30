#region Array Basic
//string city1 = "Baku";

//string city2 = "Istanbul";
//string city3 = "Madrid";


//string[] cities = {"Baku","Madrid","Istanbul" };



//Console.WriteLine(cities[0]);

//cities[1] = "Barcelona";

//Console.WriteLine(cities[1]);

//int[] numbers = new int[5];

//numbers[0] = 1;
//numbers[1] = 1;
//numbers[2] = 2;
//numbers[3] = 3;
//numbers[4] = 4;


//Console.WriteLine(numbers[2]);

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"cities[{i}] {cities[i]} ");

//    if (cities[i]=="Baku")
//    {
//        Console.WriteLine("Capital of Azerbaijan");
//    }
//}


//string[] books = { "Martin Eden", "Crime and Punishment", "Cont of Monte Cristo" };
//
//for (int i = 0; i < books.Length; i++)
//{
//    Console.WriteLine(books[i]);
//}

//foreach (var book in books)
//{
//    Console.WriteLine(book);
//}

//Console.WriteLine(books.Length); 
#endregion


//Practice

string[] movies = new string[3];



MyClass myClass = new MyClass();
//for (int i = 0; i < movies.Length; i++)
//{
//    Console.Write($"{i+1}. Type Movie name: ");
//    movies[i] = Console.ReadLine();
//}

//Console.WriteLine("----------------");

//foreach (string movie in movies)
//{
//    Console.WriteLine($"Your movie : {movie}");
//}



// Istifadeciden 5 eded alin ve onlarin cemini tapaq


//int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write($"{i}. Number : ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}


//int sumOfNumber = 0;

//foreach (var num in numbers)
//{
//    sumOfNumber += num;
//}


//Console.WriteLine(sumOfNumber);


int[] numbers = { 1, 14, -100, 101, 99, 13 };
//int[] numbers2 = { 1, 2, 120, -30, 40 };
//int maxNumber = numbers[0];
//int maxIndex = 0;


//for (int i = 0; i < numbers.Length; i++)
//{
//    if (maxNumber<numbers[i])
//    {
//        maxIndex = i;
//        maxNumber = numbers[i];
//    }
//}

//Console.WriteLine(maxNumber);
//Console.WriteLine(maxIndex);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}




//Array.Reverse(numbers);

//Console.WriteLine(numbers.);
//Console.WriteLine(Array.IndexOf(numbers,101));
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine(numbers.GetHashCode());



//int[,] matrix1 =
//{
//    {1,1,3 },
//    {4,1,6 },
//    {7,1,9 }
//};


//int[,] matrix2 =
//{
//    {5,6,13 },  
//    {14,11,16 },
//    {17,11,19 }
//};


//int[,] sumMatrix = new int[3, 3];

//for (int i = 0; i < matrix1.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix1.GetLength(1); j++)
//    {
//        Console.WriteLine($"sumMatrix[{i},{j}] = {matrix1[i,j]} + {matrix2[i,j]}");

//        sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
//    }
//}


//for (int i = 0; i < sumMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < sumMatrix.GetLength(1); j++)
//    {
//        Console.Write($"\t\t\t   {sumMatrix[i,j]}");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(number2d.GetLength(0));
//Console.WriteLine(number2d.GetLength(1));

//for (int i = 0; i < number2d.GetLength(0); i++)
//{
//    for (int j = 0; j < number2d.GetLength(1); j++)
//    {
//        Console.WriteLine($"number[{i},{j}] = {number2d[i,j]}");
//    }
//}

//Console.WriteLine(number2d[1,2]);

int[] number = new int[10];


var random = new Random();


for (int i = 0; i < numbers.Length; i++)
{
    number[i] = random.Next(1,20); 
}

foreach (var item in number)
{
    Console.WriteLine(item);
}

Console.WriteLine(Guid.NewGuid().ToString());

// Verilmis ededin tersini yazin 1993 3991

// Verilmis ededin 
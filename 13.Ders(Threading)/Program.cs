//static async Task Main(string[] args)
//{
//    Task<int> task = Task.Run(() =>
//    {
//        return 42;
//    });

//    await task.ContinueWith(t =>
//    {
//        Console.WriteLine($"The result is: {t.Result}");
//    });
////}


//static int counter = 0;
//static object lockObject = new object();

//static void Main(string[] args)
//{
//    // Create two threads that increment the counter
//    Thread thread1 = new Thread(IncrementCounter);
//    Thread thread2 = new Thread(IncrementCounter);

//    // Start the threads
//    thread1.Start();
//    thread2.Start();

//    // Wait for the threads to complete
//    thread1.Join();
//    thread2.Join();

//    // Print the final value of the counter
//    Console.WriteLine($"Final counter value: {counter}");
//}

//static void IncrementCounter()
//{
//    // Acquire the lock to ensure thread safety
//    lock (lockObject)
//    {
//        // Increment the counter
//        for (int i = 0; i < 10000; i++)
//        {
//            counter++;
//        }
//    }
//}

//CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
//CancellationToken cancellationToken = cancellationTokenSource.Token;


//Task longRunningTask = LongRunningOperationAsync(cancellationToken);

//Console.WriteLine("Press any key");
//Console.ReadKey();

//cancellationTokenSource.Cancel();

//try
//{

//    await longRunningTask;
//}
//catch (OperationCanceledException)
//{


//}

//Console.WriteLine("Program is ended.");


//    static async Task LongRunningOperationAsync(CancellationToken cancellationToken)
//{

//    for (int i = 0; i < 10; i++)
//    {

//        cancellationToken.ThrowIfCancellationRequested();


//        Console.WriteLine($"Thread is continue {i + 1}");

//        await Task.Delay(1000);
//    }
//}


//Thread thread = new Thread(PrintOne);
//thread.Start();
//thread.Join();
//Thread.Sleep(2000);

//for (int i = 0; i < 1000; i++)
//{
//    Console.Write(1);
//}


//void PrintOne()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.Write(0);
//    }
//}
//object lockObject = new object();

//int counter = 0;

//Thread thread1 = new Thread(IncrementCounter);
//Thread thread2 = new Thread(IncrementCounter);

//// Start the threads
//thread1.Start();
//thread2.Start();



//// Print the final value of the counter
//Console.WriteLine($"Final counter value: {counter}");


//void IncrementCounter()
//{
//    lock (lockObject)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            counter++;
//        }
//    }


//}


//bool _done = false;  // Static fields are shared between all threads
//                     // in the same process.

//new Thread(Go).Start();
//Go();

//void Go()
//{

//    lock (locking)
//    {
//        if (!_done) { Console.WriteLine("Done"); _done = true; }
//    }
//}




await Print();
await PrintHi();


async Task Print()
{
    Console.WriteLine("Hello world");
}

async Task PrintHi()
{
    Console.WriteLine("hi worl");
}
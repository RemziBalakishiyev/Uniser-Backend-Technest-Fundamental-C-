


using _11.Ders_Collections_.Classes;
using _11.Ders_Collections_.Managers;
using System.Collections;
#region ArrayList

//ArrayList arrayList = new ArrayList();

//arrayList.Add("C#");
//arrayList.Add(true);
//arrayList.Add(false);
//arrayList.Add(12);
//arrayList.Add(new Book { Id=1,Name="1984"});


//Console.WriteLine(arrayList[3]);

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//} 
#endregion


#region List ICollection, IEnumerable , IList

//List<string> cities = new List<string>();

//cities.Add("Baku");
//cities.Add("Sumqayit");
//Console.WriteLine(cities[1]);

//Book addedBook = new Book { Id = 3, Name = "Crime and Punishment" };
//List<Book> books = new List<Book>
//{
//    new Book {Id=1, Name="1984"},
//    new Book { Id = 2,Name="Martin Eden" }
//};

//books.AddRange(new List<Book>()
//{
//    addedBook,
//    new Book{Id=4,Name="Atomic Habbits" }
//});





//books.Add(new Book { Id = 1,Name="1984" }) ;
//books.Add(new Book { Id = 2,Name="Martin Eden" }) ;
//books.Add(addedBook);
//books.RemoveAt(1)


//foreach (var book in books)
//{
//    Console.WriteLine($"ID: {book.Id} Name: {book.Name}");
//}


#endregion

#region Dictionary
//Dictionary<int,string> student = new Dictionary<int,string>();

//student.Add(1,"Bruce");
//student.Add(2,"Walter");

//Dictionary<string, Book> books = new Dictionary<string, Book>();
//books.Add("a",new Book {Id=1,Name="1984" });
//books.Add("b",new Book {Id=2,Name="Martin Eden" });

//Console.WriteLine(books["b"].Name);

//foreach (KeyValuePair<string,Book> item in books)
//{
//    Console.WriteLine(item.Value.Name);
//}
//Console.WriteLine(student[1]); 
#endregion

#region Queue


//Queue<string> persons =  new Queue<string>();

//persons.Enqueue("Bruce");
//persons.Enqueue("Walter");
//persons.Enqueue("John");


//for (int i = 0; i < persons.Count;)
//{
//    Console.WriteLine(persons.Dequeue());
//}


//Stack<string> languages = new Stack<string>();

//HashSet<string> names = new HashSet<string>();
#endregion


//BookManager bookManager = new BookManager();

//Book addedBook = new Book {Id=3, Name = "Crime and Punishment", Price = 30 };

//bookManager.Add(addedBook);





//Console.WriteLine(bookManager.GetById(2).Name);

//bookManager.Update(1, new Book {Name="Atomic Habbits",Price=50 });

//foreach (var book in bookManager.GetAll())
//{
//    Console.WriteLine($"Id - {book.Id} - - - Name - {book.Name} - - - Price - {book.Price}");
//}



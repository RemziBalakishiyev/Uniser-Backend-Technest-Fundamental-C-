using _12.Ders_File_Handling_.Classess;
using Microsoft.VisualBasic.FileIO;
using System.Net.Sockets;
using System.Text;

string path = @"C:\Users\ASUS\Documents\Test folder";

string newPath = Path.Combine(path, "test.txt");

//Console.WriteLine(newPath);

//Console.WriteLine(Path.GetFileName(newPath));
//Console.WriteLine(Path.GetDirectoryName(newPath));
//Console.WriteLine(Path.GetExtension(newPath));
//Console.WriteLine(Path.GetFullPath(newPath));

//Console.WriteLine(Path.Combine(Path.GetDirectoryName(newPath),"Subfolder"));
//string newFolder = Path.Combine(Path.GetDirectoryName(newPath), "Subfolder");
//Directory.CreateDirectory(newFolder);
////Directory.Delete(newFolder, true);
//Console.WriteLine(Directory.GetCurrentDirectory());
//string[] folders = Directory.GetDirectories(path);

//string[] files =  Directory.GetFiles(path);
//Console.WriteLine(folders[0]);
//Console.WriteLine(Path.GetFileName(files[0]));


//Console.WriteLine(Environment.SpecialFolder.MyDocuments);


//foreach (var item in Directory.GetDirectories(SpecialDirectories.MyDocuments))
//{
//    Console.WriteLine(item);
//}


//string myDocuments = SpecialDirectories.MyDocuments;

//string testFolder = Path.Combine(myDocuments, "Test folder");
//string newSubfolderPath = Path.Combine(testFolder, "Subfolder2");


//Directory.CreateDirectory(newSubfolderPath);

//Console.WriteLine(Environment.OSVersion.VersionString);
//Console.WriteLine(newSubfolderPath);


//File.Create(newPath);

//File.WriteAllText(newPath, "Technest telebeleri mohtesemdir!");


//string text = File.ReadAllText(newPath);

//Console.WriteLine(text);

//string[] lines = File.ReadAllLines(newPath);
//Console.WriteLine(lines[2]);
//string[] contents = ["Uniser ","It","əüö"];
//File.AppendAllLines(newPath,contents,System.Text.Encoding.UTF8);
////foreach (string line in lines)
////{
////    Console.WriteLine(line);
////}
///

string uniserPath = Path.Combine(path, "uniserItAcademy.txt");

//List<string> contents = new List<string>();
//List<Student> students = new List<Student>
//{
//    new Student {FirstName="Bruce",LastName="Wayne" },
//    new Student {FirstName="Walter",LastName="White" },
//    new Student {FirstName="Jamie",LastName="Lannister" },
//    new Student {FirstName="John",LastName="Wick" },
//};


//foreach (var student in students)
//{
//    contents.Add($"{student.Id},{student.FirstName},{student.LastName}");
//}


//File.AppendAllLines(uniserPath, contents);


//IList<Student> students = new List<Student>();
//List<string> lines = File.ReadAllLines(uniserPath).ToList();

//foreach (string line in lines)
//{
//    //Console.WriteLine(line); a,b,c -> ["a","b","c"]
//    string[] parts = line.Split(',');
//    Student student = new Student();

//    student.Id= parts[0];
//    student.FirstName= parts[1];
//    student.LastName= parts[2];

//    students.Add(student);
//}

//foreach (Student student in students)
//{
//    Console.WriteLine($"Id: {student.Id} Full Name {student.FirstName} {student.LastName}");
//}



string ramzi = Path.Combine(path, "ramzi.txt");
//using (FileStream fileStream = new FileStream(ramzi, FileMode.Create))
//{
//    string testValue = "Bu file Stream ile yazilan deyerdir";

//    byte[] byteValues = Encoding.UTF8.GetBytes(testValue);

//    fileStream.Write(byteValues, 0, byteValues.Length);
//}

using (FileStream fileStream =  new FileStream(ramzi, FileMode.Open))
{
    byte[] buffer = new byte[fileStream.Length];
    fileStream.Read(buffer, 0, buffer.Length);
    string data = Encoding.UTF8.GetString(buffer);
    
    Console.WriteLine(data);
}


using (StreamWriter writer = new StreamWriter(ramzi,true))
{
   
    writer.WriteLine("Buda Stream Writer ile yazilan ifadedir");
}


using (StreamReader reader =  new StreamReader(ramzi))
{
    reader.ReadLine();
}






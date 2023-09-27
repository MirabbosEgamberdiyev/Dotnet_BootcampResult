//Stream
/*
 //Stream stream = new FileStream("Test.txt", FileMode.Open, FileAccess.ReadWrite);
//StreamReader sr = new StreamReader(stream);
//StreamWriter sw = new StreamWriter(stream);
//sw.Write("Stream sinfi!");
//Console.WriteLine(sr.ReadToEnd());
 */


// FileInfo sinfi
/*
FileInfo fileInfo = new FileInfo(@"C:\Users\Nodirbek\Desktop\Test_copy1.txt");
Console.WriteLine($"Name: {fileInfo.Name}");
Console.WriteLine($"Path: {fileInfo.FullName}");
Console.WriteLine($"Exten: {fileInfo.Extension}");
Console.WriteLine($"Created: {fileInfo.CreationTime}");
Console.WriteLine($"Modified: {fileInfo.LastWriteTime}");
Console.WriteLine($"Size: {fileInfo.Length} byte");

//nusxalash
fileInfo.CopyTo(@"C:\Users\Nodirbek\Desktop\Test_copy.txt");

//ko'chirish
fileInfo.MoveTo(@"C:\Users\Nodirbek\Desktop\Test_copy.txt", true);

//o'chirish
if (fileInfo.Exists)
{
    fileInfo.Delete();
}
*/


//File statik sinfi
/*
string path = "Test.txt";
var stream = File.Create(path);
Console.WriteLine(File.Exists(path));
string text = """
        SALOM!
        File va
        FileInfo!
    """;
File.WriteAllText(path, text);
Console.ReadLine();
Console.WriteLine(File.ReadAllText(path));
*/


// Directory va DirectoryInfo
/*
DirectoryInfo directory = 
    new DirectoryInfo(@"C:\");

//yangi qo'shish
//directory.Create();
//o'chirish
//directory.Delete();
Console.WriteLine("Directories: ");
foreach (var file in directory.GetDirectories())
{
    Console.WriteLine(file);
}
Console.WriteLine("Files: ");
foreach (var file in directory.EnumerateFiles())
{
    Console.WriteLine(file);
}

Console.ReadKey(true);
*/


using _15_dars;
using _15_dars.Interfaces;
using _15_dars.Models;
using Newtonsoft.Json;
using System.IO;

class Student
{
    public int Age { get; set; }
    public string FullName { get; set; }
    public string Country { get; set; }

    public List<Subject> Subjects = new List<Subject>();

    public Student(int age, string fname, string country)
    {
        Age = age;
        FullName = fname;
        Country = country;
    }
}

class Subject
{
    public string Name { get; set; }
    public int Score { get; set; }
}


static class Program
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student(20, "Tom", "USA")
            {
                Subjects = new List<Subject>()
                {
                    new Subject() {Name = "Math", Score = 5},
                    new Subject() {Name = "CS", Score = 5},
                }
            },
            new Student(21, "John", "UK"),
            new Student(26, "Alex", "AUS")
            {
                Subjects = new List<Subject>()
                {
                    new Subject() {Name = "Math", Score = 5},
                    new Subject() {Name = "CS", Score = 5},
                }
            },
        };

        /*
        list.SaveToFile();
        var data = ReadFromFile();
        //foreach (var student in data)
        //{
        //    Console.WriteLine($"Age: {student.Age}, FullName: {student.FullName}, Country: {student.Country}");
        //}

        var student = data.OrderByDescending(s => s.Age).First();
        Console.WriteLine($"Age: {student.Age}, FullName: {student.FullName}, Country: {student.Country}");
        */

        /*
        // json filega konvert qilish
        var json = JsonConvert.SerializeObject(list);
        //xotiraga saqlash
        SaveToJsonFile(json);

        //xotiradan fileni o'qib, listga deserialize qilish
        var jsonData = JsonConvert.DeserializeObject<List<Student>>(ReadFromJsonFile());
        */

        //BankList bankList = new BankList();
        //try
        //{
        //    bankList.CreateBank(new Bank("Yangi bank", "Adress", "00000"));
        //    bankList.CreateBank(new Bank("Yangi bank", "Adress", "00000"));
        //}
        //catch (BankException e)
        //{
        //    Console.WriteLine(e.ErrorMessage);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //Console.WriteLine($"Total banks count: {bankList.TotalCount}");
        //Console.Clear();

        //using (StreamReader sr = new StreamReader("Students.txt"))
        //{
        //    while (sr.Peek() >= 0)
        //    {
        //        Console.WriteLine(sr.ReadLine());
        //    }
        //}

        //StreamReader sr = new StreamReader("Students.txt");
        //try
        //{
        //while (sr.Peek() >= 0)
        //{
        //    Console.WriteLine(sr.ReadLine());
        //}
        //sr.Close();
        //}
        //finally
        //{
        //    sr.Dispose();
        //}


        File.WriteAllText("Students.txt", "Salom");

        //StreamWriter sw = new StreamWriter("Students.txt");
        //sw.WriteLine("Some text");
        //sw.Close();
        //string[] lines = File.ReadAllLines("Students.txt");
    }

    static void SaveToFile(this List<Student> list)
    {
        using (var sw  = new StreamWriter("Students.txt")) 
        { 
            foreach (var student in list)
            {
                sw.WriteLine($"{student.Age},{student.FullName},{student.Country}");
            }
            Console.WriteLine("Saved successfully!");
            sw.Flush();
        }
    }
    static List<Student> ReadFromFile()
    {
        string path = "Students.txt";
        List<Student> students = new List<Student>();
        using (var reader = new StreamReader(path))
        {
            var data = reader.ReadToEnd().Split("\n");
            foreach (var line in data)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var items = line.Split(',');
                    students.Add(new Student(int.Parse(items[0]), items[1], items[2]));
                }
            }
        }

        return students;
    }


    static void SaveToJsonFile(string text)
    {
        using (var sw = new StreamWriter("Students.json"))
        {
            sw.Write(text);
            Console.WriteLine("Saved successfully!");
            sw.Flush();
        }
    }
    static string ReadFromJsonFile()
    {
        return File.ReadAllText("Students.json");
    }
}

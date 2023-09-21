//Value type
//int a = 5;
//int b = a;
//Console.WriteLine(a);
//Console.WriteLine(b);

//b = 10;
//Console.WriteLine(a);
//Console.WriteLine(b);

//Reference type
//int[] arr1 = { 5 };
//int[] arr2 = arr1;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//arr2[0] = 10;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//string a = "hello";
//string b = "h";
//// Append to contents of 'b'
//b += "ello";
//Console.WriteLine(a == b);
//Console.WriteLine(object.ReferenceEquals(a, b));

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text;

//StringBuilder a = new StringBuilder();
//a.Append("hello");
//// Append to contents of 'b'
//StringBuilder b = new StringBuilder();
//b.Append("h");
//b.Append("ello");
//Console.WriteLine(a == b);
//Console.WriteLine(object.ReferenceEquals(a, b));

//long a = 25;
//byte b = (byte)a;
//Console.WriteLine(b);


//String vs StringBuilder
//class Program
//{
//    public static int NumberOfRuns = 100;
//    static void Main()
//    {
//        var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
//    }
//}

//[MemoryDiagnoser]
//public class MemoryBenchmarkerDemo
//{
//    int NumberOfItems = 100000;
//    [Benchmark]
//    public string ConcatStringsUsingStringBuilder()
//    {
//        var sb = new StringBuilder();
//        for (int i = 0; i < NumberOfItems; i++)
//        {
//            sb.Append("Hello World!" + i);
//        }
//        return sb.ToString();
//    }
//    [Benchmark]
//    public string ConcatStringsUsingGenericList()
//    {
//        string s = string.Empty;
//        for (int i = 0; i < NumberOfItems; i++)
//        {
//            s += "Hello World!" + i;
//        }
//        return s;
//    }
//}

//StringBuilder stringBuilder = new StringBuilder();
//stringBuilder.Append("Hello");
//string s = string.Empty;
//s.Append('f');
//Console.WriteLine(stringBuilder);

//enum
//enum UserRoles
//{
//    Admin = 543,
//    SuperAdmin = 435098,
//    User = 4398,
//    Guest = 212
//}

//class User
//{
//    public string Name { get; set; }
//    public string Password { get; set; }
//    public UserRoles Roles { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        User user = new User();
//        user.Roles = UserRoles.User;
//        //Console.WriteLine((ConsoleKey)39);
//        //Console.WriteLine((int)UserRoles.Guest);

//        //Console.WriteLine(Enum.GetName(UserRoles.User));
//        //foreach (var role in Enum.GetValues<ConsoleKey>())
//        //{
//        //    Console.WriteLine(role);
//        //}
//    }
//}


//int index = 0;
//try
//{
//    int number = int.Parse(Console.ReadLine());
//    int a = 3;
//    int b = int.Parse(Console.ReadLine());
//    //divide by zero exception
//    int c = a / b;
//    Console.WriteLine(c);
//    //index out of range by zero exception
//    int[] arr = { 1 };
//    index = int.Parse(Console.ReadLine());
//    Console.WriteLine(arr[index]);
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Nolga bo'lish amalga oshirildi!");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Noto'g'ri format!");
//}
//catch(IndexOutOfRangeException) 
//    when (index < 0)
//{
//    Console.WriteLine("Index manfiy bo'lishi mumkin emas!");
//}
//catch (IndexOutOfRangeException) 
//    when (index >= 0)
//{
//    Console.WriteLine("Index massiv chegarasidan chiqib ketdi!");
//}
//catch (Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}
//finally
//{
//    Console.WriteLine("Dastur yakunlandi!");
//}


//var connection = new SqlConnection();
//try
//{
//    connection.Open();
//}
//catch (Exception)
//{
//    Console.WriteLine();
//}
//finally
//{
//    connection.Close();
//}

int age = int.Parse(Console.ReadLine());
try
{
    User user = new User(age);
}
catch (UserCreationException) 
    when (age > 150)
{
    Console.WriteLine("No way!");
}
catch (UserCreationException ex)
{
    Console.WriteLine(ex.ErrorMessage);
}

class User
{
    public int Age { get; set; }

    public User(int Age)
    {
        if (Age < 0 || Age > 150)
        {
            throw new UserCreationException("Age cann't be negative!");
        }
        else
        {
            this.Age = Age;
        }
    }
}


//Custom exception
class UserCreationException : Exception
{
    public string ErrorMessage { get; set; }
    public UserCreationException(string Message)
    {
        ErrorMessage = Message;
    }
}
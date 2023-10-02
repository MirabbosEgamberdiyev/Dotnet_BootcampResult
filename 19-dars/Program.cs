#region - Funksiyalar
//var res = Sum(1, 3, 56, 6, 76, 87);
//Print(res.ToString());
//Print2("Salom", 3);

//int A = 12;
//int B = 13;
//Swap(ref A, ref B);
//Console.WriteLine(A);
//Console.WriteLine(B);

//int number = 3;
//int d1 = 0;
//int d2 = 1;
//Degree(number, ref d1, out d2);
//Console.WriteLine(d1);
//Console.WriteLine(d2);


//void Print(string s)
//    => Console.WriteLine(s);

//void Print2(string s, int a = 5)
//    => Console.WriteLine(a + s);

//int Sum1(int a, int b)
//    => a + b;

//int Sum(params int[] a)
//{
//    int sum = 0;
//    foreach (int i in a)
//    {
//        sum += i;
//    }

//    return sum;
//}

//void Swap(ref int a, ref int b)
//{
//    a = a + b;
//    b = a - b;
//    a = a - b;
//}

//void Degree(int n, ref int d1, out int d2)
//{
//    //ref ga qiymat berish ixtiyoriy
//    d1 = n * n;
//    //out ga qiymat berish majburiy
//    d2 = n * d1;

//    //int a = d1;
//    //int b = d2;
//}

#endregion

#region - Massivlar
//string[] array = new string[3];
//string[,] arr2 = new string[2, 3];
//string[,,,,,,,,,] arr10 =
//    new string[1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//jagged array - notekis(arrasimon) massiv
//int[][] jagged = new int[5][];
//jagged[0] = new int[0];
//jagged[1] = new int[7];
//jagged[2] = new int[3];
//jagged[3] = new int[7];
//jagged[4] = new int[2];

//foreach  (var arr in jagged)
//{
//    foreach (int i in arr)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}

//for (int i = 5; i >= 0; i--)
//{
//    string stars = string.Empty;
//    for (int j = 0; j < 11 - 2 * i; j++)
//    {
//        stars += "*";
//    }
//    Console.WriteLine(stars.PadLeft(6 + stars.Length / 2, ' '));
//}


//static class Program
//{
//    static void Main()
//    {
//        int[] numbers = new int[10];

//        //extension method
//        //numbers.RandomFill();
//        //numbers.Print();

//        // ord method
//        //RandomFill(numbers);
//        //Print(numbers);

//        int[] numbers2 = new int[10];

//        //numbers[0] = 1;
//        //Array.Copy(numbers, numbers2, 10);
//        //Array.Reverse(numbers);
//        ////numbers2 = numbers;
//        //Console.WriteLine("n1=" + numbers[0]);
//        //Console.WriteLine("n2=" + numbers2[0]);

//        //numbers[0] = 2;

//        //Console.WriteLine();
//        //Console.WriteLine("n1=" + numbers[0]);
//        //Console.WriteLine("n2=" + numbers2[0]);

//        numbers.RandomFill();
//        numbers.Print();
//        Array.Sort(numbers);
//        numbers.Print();
//        Array.Reverse(numbers);
//        numbers.Print();

//        //Array.Resize(ref numbers, 5);
//        //numbers.Print();

//        // range - oraliq berish va teskari indekslash
//        numbers[1..^2].Print();
//        numbers[^8..5].Print();
//    }

//    static void RandomFill(this int[] numbers)
//    {
//        Random random = new Random();
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(100);
//        }
//    }

//    static void Print(this int[] array)
//    {
//        foreach (int i in array)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//    }
//}
#endregion

class Program
{
    static void Main()
    {
        //1-kod
        PrintUserInfo(12, "Ali", "Valiyev", "Fergana", "123");

        //2-kod
        User ali = new()
        {
            Age = 23,
            FirstName = "Ali",
            LastName = "",
            Address = "",
            Phone = ""
        };
        PrintUserInfo(ali);

        var users = new List<User>();

        // nested class
        User user = new();
        User.NestedLevel1 nestedUser = new();
        User.NestedLevel1.NestedLevel2 nestedUser2 = new();
        User.NestedLevel1.NestedLevel2.NestedLevel3 nestedUser3 = new();
    }

    static void PrintUserInfo(int age,
                   string fname,
                   string lname,
                   string address,
                   string phone)
    {
        Console.WriteLine(age);
        Console.WriteLine(fname);
        Console.WriteLine(lname);
        Console.WriteLine(address);
        Console.WriteLine(phone);
        Console.WriteLine();
    }

    static void PrintUserInfo(User user)
    {
        Console.WriteLine(user.Age);
        Console.WriteLine(user.FirstName);
        Console.WriteLine(user.LastName);
        Console.WriteLine(user.Address);
        Console.WriteLine(user.Phone);
        Console.WriteLine();
    }
}

class User
{
    protected int id = 0;
    public int Age { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public User()
    {
        
    }
    public User(int Age)
    {
        this.Age = Age;
    }

    public class NestedLevel1
    {
        public class NestedLevel2
        {
            public class NestedLevel3
            {

            }
        }
    }
}

//class Account : User
//{
//    public int AccountId { get; set; }
//    public Account(User user)
//    {
//        //AccountId = id;
//        //impossible
//        //AccountId = user.id;
//    }
//}

//class Nimadir(int a, sting b)
//{

//}
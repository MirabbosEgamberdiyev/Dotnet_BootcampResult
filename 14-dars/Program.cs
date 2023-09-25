//var tuple = (12, "salom", "tuple", new int[] {1, 2, 3});
//var anonymType = new
//{
//    Id = 2,
//    Name = "A"
//};

//tuple.Item1 = 3;
//tuple.Item2 += " Dunyo!";

//(int, string, bool) tuple2 = (1, "", false);
//Person person = new Person(35, "Ali");
//int id = 1;
//var tuplePerson = (id, person.Age, person.Name);

//tuplePerson.Age += 1;
//tuplePerson.Name += " !";
//tuplePerson.id = 2;
//(id, person.Age, person.Name) = tuplePerson;

////if (tuplePerson is (id: > 36, Age: > 3, Name: "Ali"))
//if (tuplePerson.id > 2 && 
//    tuplePerson.Name != "A" 
//    && tuplePerson.Age > 36)
//Console.WriteLine();

//HashSet<int> numbers = new HashSet<int>();
//numbers.Add(0);
//numbers.Add(2);
//numbers.Add(1);
//numbers.Add(1);
//numbers.Add(2);
//numbers.Add(0);
//numbers.Add(0);
//numbers.Add(2);
//numbers.Add(1);
//Console.WriteLine(numbers.Count);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//List<int> list = new() { 2, 3, 5, 6, 7, 4, 3, 3, 56, 65 };
//Console.WriteLine(list.Count);
//list = list.ToHashSet().ToList();
//Console.WriteLine(list.Count);

//List<List<List<int>>> list = new List<List<List<int>>>();


//static class math <T> where T : struct
//{
//    public static T Add(T n1, T n2)
//    {
//        return (dynamic)n1 + (dynamic)n2;
//    }

//    public static void Print(T t)
//    {
//        Console.WriteLine(t);
//    }
//}

//class Person
//{
//    public int Age { get; set; }
//    public string Name { get; set; }

//    public Person(int age, string name)
//    {
//        Age = age;
//        Name = name;
//    }

//    public (int, string, DateTime, Student[]) GetTuplePerson()
//    {
//        return (Age, Name, DateTime.Now, new Student[] {});
//    }
//}

//class Student
//{ }


//class CustomList<Tip>
//{
//    private List<Tip> list = new List<Tip>();
//    public int Count { get { return list.Count; } }

//    public void Add(Tip t)
//    {
//        list.Add(t);
//    }

//    public void Remove(Tip t)
//    {
//        list.Remove(t);
//    }

//    public void Clear()
//    {
//        list.Clear();
//    }

//    //indexer
//    public Tip this[int i]
//    {
//        get { return list[i]; }
//        set { list[i] = value; }
//    }

//    public Tip GetByIndex(int index)
//    {
//        return list[index];
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        List<Person> list = new List<Person>();
//        list.Add(new Person(25, "Ali"));

//        CustomList<Person> customList = new CustomList<Person>();
//        customList.Add(new Person(35, "Vali"));
//        var person = list[0];
//        var person2 = customList.GetByIndex(0);
//        person2 = customList[0];
//        customList[0] = person2;

//        CustomList<int> customList1 = new CustomList<int>();
//        CustomList<string> customList2 = new CustomList<string>();
//    }
//}

class Program
{
    public delegate void Print(string msg);
    public delegate int Sum(params int[] nums);

    static void Main()
    {
        var input = Console.ReadLine;
        Print print = Console.WriteLine;

        //Delegate del2 = Console.ReadLine;
        Sum sum = Add;
        print(sum(new int[] {1, 2, 3, 4}).ToString());


        var text = input();
        print(text);

        //delegatga metod tayinlash
        Func<int, int, int> addFunc = Add;

        Action<string> printString = Console.WriteLine;
        printString("salom");


        //delegatni ishlatish va natijani o'zlashtirish
        int result = addFunc(2, 3);

        //natijani ekranga chiqarish
        Console.WriteLine($"{2} + {3} = {result}");

        Func<int, int> sqr = delegate (int x) 
        { 
            return x * x; 
        };

        Func<int, double> sqrt = delegate (int x)
        {
            return Math.Sqrt(x);
        };



        Console.WriteLine(sqr(3));

        //print.Invoke(text);
        Predicate<int> predicate = IsPrime;

        for (int i = 2; i < 50; i++)
        {
            if (predicate(i)) Console.Write(i + " ");
        }
        Console.ReadKey();
    }

    static bool IsPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }


    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Add(params int[] arr)
    {
        return arr.Sum();
    }
}

class Generic<Type>
{
    public delegate void PrintDelegate(Type t);

    public void PrintMethod(Type type)
    {
        Console.WriteLine(type);
    }
}
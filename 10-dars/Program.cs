////Console.WriteLine(Person.GetPersonName());
////Console.WriteLine(Person.DefaultName);


////class Person
////{
////    //field
////    private string name;
////    //property
////    public string Name { get; set; }

////    public static string DefaultName = "Default";
////    public static string GetPersonName()
////    {
////        return "Name";
////    }

////    public static void Print()
////    {
////        //
////    }
////}


//using System.Xml.Linq;

//class Person
//{
//    public int Age;
//    public string Name;
//    public Person(int age, string name)
//    {
//        Age = age;
//        Name = name;
//    }

//    public void GetInfo()
//    {
//        Console.WriteLine($"Name: {Name}\nAge:{Age}");
//    }
//}



//static class Program
//{
//    static void Main()
//    {
//        //Person john = new Person(23, "John");
//        //Person alex = new Person(23, "Alex");
//        //Console.WriteLine(john.IsEqualsTo(alex));

//        //person.GetInfo();
//        //GetInfoFromProgram(person.Age, person.Name);
//        //person1.GetInfoExtension();

//        //string input = Console.ReadLine();
//        //int son = int.Parse(input);
//        //int son2 = Convert.ToInt32(input);

//        //int son3 = Console.ReadLine().ToInt();
//        //int[] numbers = Console.ReadLine().ToIntArray();
//        //int a = 0;


//        Coords coords = new Coords(3, 5);

//        DailyTemperature dt = new DailyTemperature(2, 4);
//        DailyTemperature dt2 = new DailyTemperature(2, 4);
//        Console.WriteLine(dt != dt2);
//        DailyTemperaturec dtc = new DailyTemperaturec(2, 4);
//        int a = 2;
//    }


//    //public static void GetInfoFromProgram(int Age, string Name)
//    //{
//    //    Console.WriteLine($"Name: {Name}\nAge:{Age}");
//    //}

//    //public static void GetInfoExtension(this Person person)
//    //{
//    //    Console.WriteLine($"Name: {person.Name}\nAge:{person.Age}");
//    //}

//    //public static int ToInt(this string text)
//    //{
//    //    return Convert.ToInt32(text);
//    //}

//    //public static int[] ToIntArray(this string text)
//    //{
//    //    string[] strings = text.Split();
//    //    int[] array = new int[strings.Length];
//    //    for (int i = 0; i < array.Length; i++)
//    //    {
//    //        array[i] = strings[i].ToInt();
//    //    }

//    //    return array;
//    //}

//    //public static bool IsEqualsTo(this Person person1, Person person2)
//    //{
//    //    return person1.Age == person2.Age 
//    //          && person1.Name == person2.Name;
//    //}
//}

//public struct Coords
//{
//    public Coords(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public double X { get; }
//    public double Y { get; }

//    public override string ToString() => $"({X}, {Y})";
//}


//public record DailyTemperature(double HighTemp, double LowTemp);

//class DailyTemperaturec
//{
//    public double HighTemp;
//    public double LowTemp;
//    public DailyTemperaturec(double HighTemp, double LowTemp)
//    {
//        this.HighTemp = HighTemp;
//        this.LowTemp = LowTemp;
//    }
//}



//interface
//interface IAnimal
//{
//    string Name { get; set; }
//    void MakeSound();
//    void GiveName(string name);
//}

//abstract class Animal
//{
//    private readonly string defaultSound = "NoN";
//    protected string Name { get; set; }
//    public virtual void MakeSound()
//    {
//        Console.WriteLine(defaultSound);
//    }
//    public abstract void GiveName(string name);
//}

//class Dog : IAnimal
//{
//    public string Name { get; set; }

//    public void GiveName(string name)
//    {
//        Name = name;
//    }

//    public void MakeSound()
//    {
//        Console.WriteLine($"{Name}: Wow-wow");
//    }
//}

//class Cat : IAnimal
//{
//    public string Name { get; set; }

//    public void GiveName(string name)
//    {
//        Name = name;
//    }

//    public void MakeSound()
//    {
//        Console.WriteLine($"{Name}: Meyauw");
//    }
//}

//class Horse : Animal
//{
//    public override void GiveName(string name)
//    {
//        Name = name;
//    }

//    public override void MakeSound()
//    {
//        Console.WriteLine($"{Name}: Horse");

//        base.MakeSound();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //IAnimal rex = new Dog();
//        //rex.GiveName("Rex");
//        //rex.MakeSound();

//        //IAnimal cat = new Cat();
//        //cat.GiveName("Masha");
//        //cat.MakeSound();

//        Animal animal = new Horse();
//        animal.GiveName("Toy");
//        animal.MakeSound();
//    }
//}

//string? text = Console.ReadLine();
//if (text is null)
//{
//    text = "0";
//}
//int? a ;
//a = 0;

//Recursiya
//static int Fib(int n, ref int counter)
//{
//    counter++;
//    if (n == 0) return 1;
//    if (n == 1) return 1;

//    return Fib(n-1, ref counter) + Fib(n-2, ref counter );
//}
//int c = 0;
//Fib(10, ref c);
//Console.WriteLine(c);


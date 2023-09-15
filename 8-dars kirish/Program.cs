//class Program
//{
//    static void Main()
//    {
//        C obj = new();
//        obj.PrintPowB();
//    }
//}


//class A
//{
//    public int a = 1;
//    public void Print()
//    {
//        Console.WriteLine(a);
//    }
//}

//class B : A
//{
//    private int b = 2;
//    public void PrintPowB()
//    {
//        Console.WriteLine(b * b);
//    }
//}

//class C : B
//{
//    public int c = 3;
//}

//Point p1 = new();
//p1.x = int.Parse(Console.ReadLine());
//p1.y = int.Parse(Console.ReadLine());

//Point p2 = new();
//p2.x = int.Parse(Console.ReadLine());
//p2.y = int.Parse(Console.ReadLine());

////double dis = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1 - y2, 2));
//Console.WriteLine(p2.DistanceFrom(p1));
//class Point
//{
//    public int x; 
//    public int y;

//    public double DistanceFrom(Point p)
//    {
//        return Math.Sqrt(Math.Pow(p.y - this.y, 2) + Math.Pow(p.x - this.x, 2));
//    }
//}


//int a = 3;
//int b = 4;

//parametrli konstruktor qo'llanishi
//User user1 = new User(30, "Alex", "alex@gmail.com");

//// bo'sh konstruktor qo'llanishi
//User user2 = new User();
//user2.Age = 39;
//user2.FullName = "J. Price";
//user2.Email = "price@mail.com";
//user2.Address = "USA";

//user1.PrintUserInfos();
//user2.PrintUserInfos();

//User user3 = new User()
//{
//    Age = 50,
//    FullName = "Tom",
//    Address = "Texas",
//    Email = "tom@mail.com"
//};
//user3.PrintUserInfos();
//GC.Collect();
//GC.SuppressFinalize(user3);


class User
{
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            age = value;
            BirthYear = DateTime.Now.Year - value;
        }
    }

    public string FullName;
    public string Email;
    public string Address;

    private int BirthYear = 0;
    private int age = 0;

    public User()
    {
        Age = 0;
        FullName = string.Empty;
        Email = string.Empty;
        Address = string.Empty;
    }

    public User(int Age,
                string FullName)
    {
        this.Age = Age;
        //SetBirthYear(Age);
        this.FullName = FullName;
        Email = string.Empty;
        Address = string.Empty;
    }
    //constructor
    public User(int age,
                string fullname,
                string email,
                string address = "")
    {
        Age = age;
        //SetBirthYear(Age);
        FullName = fullname;
        Email = email;
        Address = address;
    }

    public void PrintUserInfos()
    {
        Console.WriteLine($"Full name:\t{this.FullName}");
        Console.WriteLine($"Age:\t\t{this.Age}");
        Console.WriteLine($"Birth Year:\t\t{this.BirthYear}");
        Console.WriteLine($"Email:\t\t{this.Email}");
        Console.WriteLine($"Address name:\t{this.Address}");
        Console.WriteLine();
    }

    public void SetBirthYear(int age)
    {
        BirthYear = DateTime.Now.Year - age;
    }
}

//using System;
//using _7_dars;
//// abstrakt class 'Hayvonlar' 
//public abstract class Hayvolar
//{
//    protected string name = "nom";
//    // abstrakt metod 'Ovoz()'
//    public abstract void Ovoz();
//}

//// class 'Hayvolar' dan olingan  voris class 'Sigir'
//public class Sigir : Hayvolar
//{
//    public string GetName()
//    {
//        Console.WriteLine(name);
//        return name;
//    }
//    // Qayta ishlangan 'Ovoz()' metodi
//    public override void Ovoz()
//    {
//        Console.WriteLine("Moo");
//    }
//}
public class Mushuk : Hayvolar
{
    // Qayta ishlangan 'Ovoz()' metodi
    public override void Ovoz()
    {
        Console.WriteLine("Myauuu");
    }
}
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Sigir obyektini yaratish
//        //Sigir sigir_obj = new Sigir();
//        //// abstrakt metodni chaqirish
//        //sigir_obj.Ovoz();
//        ////sigir_obj.name = "Masha";
//        //sigir_obj.GetName();

//        //Mushuk mushuk = new Mushuk();
//        //mushuk.Ovoz();

//        Arifmetika arifmetika = new Arifmetika();
//        var res = arifmetika.Sum(1,2,5,6,7,8,8,86,76,6);
//        Console.WriteLine(res);
//    }
//}
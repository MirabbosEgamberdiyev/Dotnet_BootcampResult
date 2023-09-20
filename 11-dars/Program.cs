class Program
{
    static void Main()
    {
        Container container = new Container();
        //Container.Nested nested = new Container.Nested();
        //nested.CreateInstance();

        //Employee employee = new Employee();
        //employee.DoWork();
        //employee.GoToLunch();

        //double d = 5;

        //Console.WriteLine();

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello");
        
        Console.Beep(580, 1000);
    }
}

public class Container
{
    static Container() 
    {
        Console.WriteLine("Static constructor");
    }

    //private Container()
    //{
    //    Console.WriteLine("Private constructor works!");
    //}

    public class Nested
    {
        public Nested() { }

        public void CreateInstance()
        {
            Container container = new Container();
        }
    }
}

public partial class Employee
{
    public void DoWork()
    {
        Console.WriteLine("Some work!");
    }
}

public partial class Employee
{
    public void GoToLunch()
    {
        Console.WriteLine("Go Lunch!");
    }
}

public static partial class Math
{
    public static double Sqr(double d)
    {
        return d * d;
    }
}

//public class Person(string name)
//{
//}
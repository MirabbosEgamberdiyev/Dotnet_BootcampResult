using _9_dars;
using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main()
    {
        //Bank bank = new("Hamkorbank", "Fergana");
        //bank.CreateNewCustomer("Nodirbek Abdulaxadov",1, 0);

        //var customer = bank.GetCustomerByAccountNumber(1);
        //Console.WriteLine(customer.FullName);

        //Account account = new Account();
        //account.Balance

        //TimePeriod timePeriod = new TimePeriod();
        //timePeriod.Hours = 11;
        //Console.WriteLine(timePeriod.Hours);

        //Point point = new Point()
        //{
        //    Y = 10
        //};
        //point.X = 10;
        //point.Y = 10;

        Person person = new Person()
        {
            Age = 12,
            FirstName = "",
        };

        //anonym types
        var person2 = new
        {
            FName = person.FirstName,
            Price = 15000.09,
            Year = 2023
        };
    }
}

public class TimePeriod
{
    private double _seconds;

    public double GetHours()
    {
        return _seconds / 3600;
    }
    public void SetHours(double seconds)
    {
        if (seconds < 0 || seconds > 24)
            throw new ArgumentOutOfRangeException(nameof(seconds),
                  "The valid range is between 0 and 24.");

        _seconds = seconds * 3600;
    }

    public double Hours
    {
        get 
        { 
            return _seconds / 3600; 
        }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(nameof(value),
                      "The valid range is between 0 and 24.");

            _seconds = value * 3600;
        }
    }
}

class Point
{
    public int X { get; set; }
    public int Y { get; init; }
}

public class Person
{
    public Person() { }

    public Person(string firstName, string lastName) { }

    public required string FirstName { get; init; }
    public string LastName { get; init; }

    public required int Age { get; set; }
}
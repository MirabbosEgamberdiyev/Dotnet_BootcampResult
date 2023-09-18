namespace _9_dars;

public class Account : Customer
{
    public int Id = 0;
    public string AccountType = string.Empty;

    public void AddDeposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("Successfully!");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("Successfully!");
        }
        else
        {
            Console.WriteLine("No enough money!");
        }
    }
}
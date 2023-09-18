using _9_dars;

class Program
{
    public static void Main()
    {
        Bank bank = new("Hamkorbank", "Fergana");
        bank.CreateNewCustomer("Nodirbek Abdulaxadov",1, 0);

        var customer = bank.GetCustomerByAccountNumber(1);
        Console.WriteLine(customer.FullName);

        Account account = new Account();
        account.Customer = customer;
        account.AddDeposit(1000);
        Console.WriteLine(account.Balance);
    }
}
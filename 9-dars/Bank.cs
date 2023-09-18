namespace _9_dars;

public class Bank
{
    public string Name = string.Empty;
    public string Location = string.Empty;

    private Customer[] customers = new Customer[100];
    private int CustomersCount = 0;

    public Bank(string Name, string Location)
    {
        this.Name = Name;
        this.Location = Location;
    }

    public void CreateNewCustomer(string fullName,
                                      int accountNumber,
                                      double balance)
    {
        var customer = new Customer(fullName, accountNumber, balance);
        customers[CustomersCount++] = customer;
        Console.WriteLine("Customer created!");
    }

    public Customer GetCustomerByAccountNumber(int accountNumber)
    {
        foreach (var customer in customers)
        {
            if (customer.AccountNumber == accountNumber)
                return customer;
        }

        Console.WriteLine("Customer not found!");
        return new Customer();
    }
}
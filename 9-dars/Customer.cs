namespace _9_dars;

public class Customer
{
    public string FullName = string.Empty;
    public int AccountNumber = 0;
    protected double Balance = 0;

    public Customer(string FullName, 
                    int AccountNumber, 
                    double Balance)
    {
        this.FullName = FullName;
        this.AccountNumber = AccountNumber;
        this.Balance = Balance;
    }

    public Customer() { }
}
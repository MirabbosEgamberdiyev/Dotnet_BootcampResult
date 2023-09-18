namespace _9_dars;

public class Transaction
{
    public string Type = string.Empty;
    public double Amount = 0;
    public DateTime Date;

    public int AccountId = 0;
    public Account Account = new();
}

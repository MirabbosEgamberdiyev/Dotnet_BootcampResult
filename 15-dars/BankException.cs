namespace _15_dars;

public class BankException : Exception
{
    public string ErrorMessage { get; set; } = string.Empty;
    public BankException(string message)
    {
        ErrorMessage = message;
    }
}
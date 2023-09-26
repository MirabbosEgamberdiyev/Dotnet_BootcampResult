namespace _15_dars.Models;

public class Bank
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime FoundedDate { get; set; }
    public string Address = string.Empty;
    public string PhoneNumber = string.Empty;

    public Bank(string name,
                string address,
                string phoneNumber)
    {
        Name = name;
        FoundedDate = DateTime.Now;
        Address = address;
        PhoneNumber = phoneNumber;
    }
}


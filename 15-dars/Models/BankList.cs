using _15_dars.Interfaces;

namespace _15_dars.Models;

internal class BankList : IBankList
{
    List<Bank> banks = new List<Bank>();
    public int TotalCount
    {
        get
        {
            return banks.Count;
        }
    }

    public void CreateBank(Bank newBank)
    {
        if (newBank == null)
        {
            throw new ArgumentNullException(nameof(newBank));
        }

        if (string.IsNullOrEmpty(newBank.Name) || 
            newBank.Address == null || 
            newBank.PhoneNumber == null)
        {
            throw new ArgumentException("Bank ma'lumotlari yetarli emas!");
        }

        if (banks.Any(b => b.Name == newBank.Name))
        {
            throw new BankException("Bunday nomli bank allaqachon mavjud!");
        }
        newBank.Id = banks.Count + 1;
        banks.Add(newBank);
    }

    public List<Bank> GetAllBanks() => banks;
}
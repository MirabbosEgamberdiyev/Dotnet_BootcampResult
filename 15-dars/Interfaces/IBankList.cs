using _15_dars.Models;

namespace _15_dars.Interfaces;

public interface IBankList
{
    void CreateBank(Bank newBank);
    List<Bank> GetAllBanks();
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interface
{
    public interface IVendingMachineOperations
    {
        //void SetPersistentCookiesOnStartup();

        string TakeMoneyAndRefund(string canFlavour, double price, double paidMoney);

        List<string> GetCanFlavours();

        int GetCurrentCanStocks();

        void RestockMachine(int cans);
    }
}

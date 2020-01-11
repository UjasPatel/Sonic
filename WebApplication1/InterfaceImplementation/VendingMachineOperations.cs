using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interface;

namespace WebApplication1.InterfaceImplementation
{
    public class VendingMachineOperations : IVendingMachineOperations
    {   
        /// <summary>
        /// If money that is paid is more than price than return money to be refunded
        /// </summary>
        /// <param name="canFlavour"></param>
        /// <param name="price"></param>
        /// <param name="paidMoney"></param>
        /// <returns></returns>
        public string TakeMoneyAndRefund(string canFlavour, double price, double paidMoney)
        {
            if (paidMoney > price)
            {
                // need to deduct available stock by 1
                return "Payment Successful. Please Collect your can and change " + (paidMoney - price).ToString() + "$ from the machine. Thanks for your purchase!!";
            }
            else if (paidMoney == price)
            {
                // need to deduct available stock by 1
                return "Payment Successful. Please collect your can. Thanks for your purchase!!";
            }
            return (price - paidMoney).ToString() + " still required to buy a can";
        }
    }
}

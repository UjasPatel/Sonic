using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interface;

namespace WebApplication1.InterfaceImplementation
{
    public class VendingMachineOperations : IVendingMachineOperations
    {
        //// Call this when first load of the page is done
        //// Provide a button to do this if refresh is required
        //public void SetPersistentCookiesOnStartup()
        //{
        //    CookieOptions option = new CookieOptions();

        //    Response.Cookies.Append("TotalCans", "20", option);
        //    Response.Cookies.Append("TotalCash", "0", option);
        //    Response.Cookies.Append("TotalCredit", "0", option);
        //}

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
                return "Please Collect your can and change " + (paidMoney - price).ToString() + "$ from the machine. Thanks for your puchase!!";
            }
            else if (paidMoney == price)
            {
                // need to deduct available stock by 1
                return "Please collect your can. Thanks for your purchase!!";
            }
            return (price - paidMoney).ToString() + " still required to buy a can";
        }

        /// <summary>
        /// Just for Display
        /// </summary>
        /// <returns></returns>
        public List<string> GetCanFlavours()
        {
            var flavours = new List<string>();
            flavours.Add("a");
            flavours.Add("b");
            flavours.Add("c");
            flavours.Add("d");
            flavours.Add("e");
            flavours.Add("f");
            flavours.Add("g");
            flavours.Add("h");
            flavours.Add("i");
            flavours.Add("j");
            return flavours;
        }

        /// <summary>
        /// How many cans are still available in the machine
        /// </summary>
        /// <returns></returns>
        public int GetCurrentCanStocks()
        {
            // return total number of cans still available in machine
            return 0;
        }

        public void RestockMachine(int cans)
        {
            // set the cash held in machine to 0
            // set the amount payed by credit card to 0
            // set number of cans sold
            // number of cans added to the availabkle cans
        }
    }
}

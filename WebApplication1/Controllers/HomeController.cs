using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Call this when first load of the page is done
        // Provide a button to do this if refresh is required
        public void SetPersistentCookiesOnStartup()
        {
            CookieOptions option = new CookieOptions();

            Response.Cookies.Append("TotalCans", "20", option);
            Response.Cookies.Append("TotalCash", "0", option);
            Response.Cookies.Append("TotalCredit", "0", option);
        }

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
                return (paidMoney - price).ToString();
            }
            else if( paidMoney == price)
            {
                // need to deduct available stock by 1
                return "0";
            }
            return (price - paidMoney).ToString() + " still required to buy a can";
        }

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

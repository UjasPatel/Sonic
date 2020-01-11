using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVendingMachineOperations _vendingMachineOperations;
        private readonly VendingMachineViewModel VendingMachineViewModel = new VendingMachineViewModel();

        public HomeController(IVendingMachineOperations vendingMachineOperations)
        {
            _vendingMachineOperations = vendingMachineOperations;
        }

        public IActionResult Index()
        {
            if(VendingMachineViewModel.TotalCansLeft == null)
                VendingMachineViewModel.TotalCansLeft = 20;
            if (VendingMachineViewModel.TotalCashCollected == null)
                VendingMachineViewModel.TotalCashCollected = 0;
            if (VendingMachineViewModel.TotalCreditCollected == null)
                VendingMachineViewModel.TotalCreditCollected = 0;
            if (VendingMachineViewModel.TotalCansSold == null)
                VendingMachineViewModel.TotalCansSold = 0;

            return View(VendingMachineViewModel);
        }

        [HttpPost]
        public ActionResult Index(VendingMachineViewModel model, string submit)
        {
            switch (submit)
            {
                case "Purchase":
                    ModelState.Clear();                    
                    model.Operations = OperationEnum.Purchase;                    
                    return View(model);
                case "Restock":                    
                    ModelState.Clear();  
                    model.Operations = OperationEnum.Restock;
                    return View(model);
                case "Complete Restock":
                    if (model.RestockNumber == null)
                    {
                        model.ErrorMessage = "Error: Please enter number of cans to restock and Try Again!!";
                        return View(model);
                    }
                    if (model.TotalCansLeft + model.RestockNumber > 20)
                    {
                        model.ErrorMessage = "Error: Only 20 cans can be inserted in vending machine at a time";
                        return View(model);
                    }
                    ModelState.Clear();
                    model.TotalCansLeft += model.RestockNumber;
                    model.TotalCashCollected = 0;
                    model.TotalCreditCollected = 0;
                    model.TotalCansSold = 0;
                    model.Operations = OperationEnum.Home;
                    return View(model);
                case "Complete Purchase":
                    if(model.CashEntered == null)
                    {
                        model.ErrorMessage = "Please enter an amount to buy a can.";
                        return View(model);
                    }

                    if (model.CashEntered < 4.5)
                    {
                        model.ErrorMessage = "Money entered was not enough. Please enter atleast 4.5$ in the machine. Please collect your change and try again!!";
                        return View(model);
                    }

                    if (model.TotalCansLeft == 0)
                    {
                        model.ErrorMessage = "Sorry for inconvenience!! We have no cans left in machine anymore.";
                        return View(model);
                    }

                    ModelState.Clear();
                    model.RefundMessage = _vendingMachineOperations.TakeMoneyAndRefund("a", 4.5, model.CashEntered.Value);
                    model.TotalCansLeft -= 1;
                    model.TotalCansSold += 1;
                    if (model.CashCredit == Enums.CashCreditEnum.cash)
                    {
                        model.TotalCashCollected += 4.5;
                    }
                    else if (model.CashCredit == Enums.CashCreditEnum.credit)
                    {
                        model.TotalCreditCollected += 4.5;
                    }
                    return View(model);
                case "Cash":
                    ModelState.Clear();
                    model.Operations = OperationEnum.Purchase;
                    model.CashCredit = Enums.CashCreditEnum.cash;
                    return View(model);
                case "Credit Card":
                    ModelState.Clear();
                    model.Operations = OperationEnum.Purchase;
                    model.CashCredit = Enums.CashCreditEnum.credit;
                    return View(model);
                default:
                    return View(model);
            }            
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
        //public void SetPersistentCookiesOnStartup()
        //{
        //    CookieOptions option = new CookieOptions();

        //    Response.Cookies.Append("TotalCans", "20", option);
        //    Response.Cookies.Append("TotalCash", "0", option);
        //    Response.Cookies.Append("TotalCredit", "0", option);
        //}

        ///// <summary>
        ///// If money that is paid is more than price than return money to be refunded
        ///// </summary>
        ///// <param name="canFlavour"></param>
        ///// <param name="price"></param>
        ///// <param name="paidMoney"></param>
        ///// <returns></returns>
        //public string TakeMoneyAndRefund(string canFlavour, double price, double paidMoney)
        //{
        //    if (paidMoney > price)
        //    {
        //        // need to deduct available stock by 1
        //        return (paidMoney - price).ToString();
        //    }
        //    else if( paidMoney == price)
        //    {
        //        // need to deduct available stock by 1
        //        return "0";
        //    }
        //    return (price - paidMoney).ToString() + " still required to buy a can";
        //}

        ///// <summary>
        ///// Just for Display
        ///// </summary>
        ///// <returns></returns>
        //public List<string> GetCanFlavours()
        //{
        //    var flavours = new List<string>();
        //    flavours.Add("a");
        //    flavours.Add("b");
        //    flavours.Add("c");
        //    flavours.Add("d");
        //    flavours.Add("e");
        //    flavours.Add("f");
        //    flavours.Add("g");
        //    flavours.Add("h");
        //    flavours.Add("i");
        //    flavours.Add("j");
        //    return flavours;
        //}

        ///// <summary>
        ///// How many cans are still available in the machine
        ///// </summary>
        ///// <returns></returns>
        //public int GetCurrentCanStocks()
        //{
        //    // return total number of cans still available in machine
        //    return 0;
        //}

        //public void RestockMachine(int cans)
        //{
        //    // set the cash held in machine to 0
        //    // set the amount payed by credit card to 0
        //    // set number of cans sold
        //    // number of cans added to the availabkle cans
        //}
    }
}

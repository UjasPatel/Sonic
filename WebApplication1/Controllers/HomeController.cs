using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Core.Shared.Interface;
using Core.Shared.Enums;
using Core.Shared.Dto;
using System;

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
                    return StartPurchase(model);                    
                case "Restock":
                    return StartRestock(model);                    
                case "Complete Restock":
                    return CompleteRestock(model);                   
                case "Complete Purchase":
                    return CompletePurchase(model);                    
                case "Cash":
                    return StartCashTransaction(model);                    
                case "Credit Card":
                    return CreditCardTransaction(model);                   
                default:
                    return View(model);
            }            
        }

        #region "Helpers"
        /// <summary>
        /// When Credit Card transaction is selected it asks for amount
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult CreditCardTransaction(VendingMachineViewModel model)
        {
            ModelState.Clear();
            model.Operations = OperationEnum.Purchase;
            model.CashCredit = CashCreditEnum.credit;
            return View(model);
        }

        /// <summary>
        /// When Cash transaction is selected it asks for amount
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult StartCashTransaction(VendingMachineViewModel model)
        {
            ModelState.Clear();
            model.Operations = OperationEnum.Purchase;
            model.CashCredit = CashCreditEnum.cash;
            return View(model);
        }

        /// <summary>
        /// Completes purchase process
        /// reduces cans left by 1 and ejects a can
        /// Adds Cash or credit card amount.
        /// Adds 1 to number of cans sold
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult CompletePurchase(VendingMachineViewModel model)
        {     
            ModelState.Clear();
            // Call API to perform transaction
            model = TransferDtoToModel(_vendingMachineOperations.TakeMoneyAndRefund(ModelToTransferDto(model)));          
            return View(model);
        }

        /// <summary>
        /// Completes the restock process by adding number of cans
        /// entered by user to existing cans
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult CompleteRestock(VendingMachineViewModel model)
        {
            ModelState.Clear();
            // Call API to perform restock operation
            model = TransferDtoToModel(_vendingMachineOperations.Restock(ModelToTransferDto(model)));
            return View(model);
        }

        /// <summary>
        /// Starts restock operation, shows option to enter number of cans
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult StartRestock(VendingMachineViewModel model)
        {
            ModelState.Clear();
            model.Operations = OperationEnum.Restock;
            return View(model);
        }

        /// <summary>
        /// Starts Purchase operation, shows option to select Cash or credit card
        /// </summary>
        /// <param name="model">object that contains information</param>
        /// <returns></returns>
        private ActionResult StartPurchase(VendingMachineViewModel model)
        {
            ModelState.Clear();
            model.Operations = OperationEnum.Purchase;
            return View(model);
        }

        /// <summary>
        /// Mapping a TransferDto to View model for display on View
        /// </summary>
        /// <param name="transferDto"></param>
        /// <returns></returns>
        private VendingMachineViewModel TransferDtoToModel(TransferDto transferDto)
        {
            return new VendingMachineViewModel
            {
                TotalCansLeft = transferDto.TotalCansLeft,
                TotalCashCollected = transferDto.TotalCashCollected,
                TotalCreditCollected = transferDto.TotalCreditCollected,
                RefundMessage = transferDto.RefundMessage,
                RestockNumber = transferDto.RestockNumber,
                TotalCansSold = transferDto.TotalCansSold,
                CashEntered = transferDto.CashEntered,
                ErrorMessage = transferDto.ErrorMessage,
                Operations = transferDto.Operations,
                CashCredit = transferDto.CashCredit
            };
        }

        /// <summary>
        /// Mapping a View Model to TransferDto for performing operations
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private TransferDto ModelToTransferDto(VendingMachineViewModel model)
        {
            return new TransferDto
            {
                TotalCansLeft = model.TotalCansLeft,
                TotalCashCollected = model.TotalCashCollected,
                TotalCreditCollected = model.TotalCreditCollected,
                RefundMessage = model.RefundMessage,
                RestockNumber = model.RestockNumber,
                TotalCansSold = model.TotalCansSold,
                CashEntered = model.CashEntered,
                ErrorMessage = model.ErrorMessage,
                Operations = model.Operations,
                CashCredit = model.CashCredit
            };
        }
        #endregion
    }
}

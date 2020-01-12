using Core.Shared.Dto;
using Core.Shared.Enums;
using Core.Shared.Interface;

namespace Core.InterfaceImplementation
{
    public class VendingMachineOperations : IVendingMachineOperations
    {
        /// <summary>
        /// Restocks number of can specified by user inside the machine.
        /// Also resets counts and cash collection to 0.
        /// </summary>
        /// <param name="dto">An object that contains information</param>
        /// <returns></returns>
        public TransferDto Restock(TransferDto dto)
        {
            if (dto.RestockNumber == null)
            {
                dto.ErrorMessage = "Error: Please enter number of cans to restock and Try Again!!";
                return dto;
            }
            if (dto.TotalCansLeft + dto.RestockNumber > 20)
            {
                dto.ErrorMessage = "Error: Only 20 cans can be inserted in vending machine at a time";
                return dto;
            }

            dto.TotalCansLeft += dto.RestockNumber;
            dto.TotalCashCollected = 0;
            dto.TotalCreditCollected = 0;
            dto.TotalCansSold = 0;
            dto.Operations = OperationEnum.Home;
            dto.RefundMessage = $"{dto.RestockNumber} can/cans successfully restocked in the machine. Have a good day!!";
            return dto;
        }

        /// <summary>
        /// If money that is paid is more than price than return money to be refunded
        /// </summary>
        /// <param name="dto">An object which contains information.</param>
        /// <returns></returns>
        public TransferDto TakeMoneyAndRefund(TransferDto dto) 
        {
            // Some validation before approving the purchase
            if (dto.CashEntered == null)
            {
                dto.ErrorMessage = "Please enter an amount to buy a can.";
                return dto;
            }

            // Some validation before approving the purchase
            if (dto.CashEntered < 4.5)
            {
                dto.ErrorMessage = "Money entered was not enough. Please enter atleast 4.5$ in the machine. Please collect your change and try again!!";
                return dto;
            }

            // Some validation before approving the purchase
            if (dto.TotalCansLeft == 0)
            {
                dto.ErrorMessage = "Sorry for inconvenience!! We have no cans left in machine anymore.";
                return dto;
            }          

            dto.TotalCansLeft -= 1;
            dto.TotalCansSold += 1;
            if (dto.CashCredit == CashCreditEnum.cash)
            {
                dto.TotalCashCollected += 4.5;
            }
            else if (dto.CashCredit == CashCreditEnum.credit)
            {
                dto.TotalCreditCollected += 4.5;
            }
            
            if (dto.CashEntered > 4.5)
            {
                dto.RefundMessage = "Payment Successful. Please Collect your can and change " + (dto.CashEntered - 4.5).ToString() + "$ from the machine. Thanks for your purchase!!";
                return dto;
            }
            else
            {
                dto.RefundMessage = "Payment Successful. Please collect your can. Thanks for your purchase!!";
                return dto;
            }
        }
    }
}

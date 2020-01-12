using Core.Shared.Enums;

namespace WebApplication1.Models
{
    public class VendingMachineViewModel
    {
        public int? TotalCansLeft { get; set; }

        public double? TotalCashCollected { get; set; }

        public double? TotalCreditCollected { get; set; }

        public string RefundMessage { get; set; }

        public int? RestockNumber { get; set; }

        public int? TotalCansSold { get; set; }

        public double? CashEntered { get; set; } = 0;

        public string ErrorMessage { get; set; }

        public OperationEnum Operations { get; set; } = OperationEnum.Home;

        public CashCreditEnum CashCredit { get; set; } = CashCreditEnum.none;
    }
}

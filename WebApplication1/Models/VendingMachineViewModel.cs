using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class VendingMachineViewModel
    {
        public int? TotalCansLeft { get; set; }

        public double? TotalCashCollected { get; set; }

        public double? TotalCreditCollected { get; set; }

        public string RefundMessage { get; set; }
    }
}

using Core.InterfaceImplementation;
using Core.Shared.Dto;
using Xunit;

namespace XUnitTestProject1
{
    public class RestockTests
    {
        [Fact]
        public void Success_WhenAllDataCorrect()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 18,
                TotalCansSold = 2,
                TotalCashCollected = 4.5,
                TotalCreditCollected = 4.5,
                RestockNumber = 2
            };

            var ops = new VendingMachineOperations();
            var answer = ops.Restock(TransferDto);

            Assert.True(answer.RefundMessage == $"{TransferDto.RestockNumber} can/cans successfully restocked in the machine. Have a good day!!");
            Assert.True(answer.TotalCansLeft == 20);
            Assert.True(answer.TotalCansSold == 0);
            Assert.True(answer.TotalCashCollected == 0);
            Assert.True(answer.TotalCreditCollected == 0);
        }

        [Fact]
        public void Error_WhenRestockAmount_Null()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 18,
                TotalCansSold = 2,
                TotalCashCollected = 4.5,
                TotalCreditCollected = 4.5,
                RestockNumber = null
            };

            var ops = new VendingMachineOperations();
            var answer = ops.Restock(TransferDto);

            Assert.True(answer.ErrorMessage == "Error: Please enter number of cans to restock and Try Again!!");            
        }

        [Fact]
        public void Error_WhenRestockTotal_GreaterThan_20()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 18,
                TotalCansSold = 2,
                TotalCashCollected = 4.5,
                TotalCreditCollected = 4.5,
                RestockNumber = 3
            };

            var ops = new VendingMachineOperations();
            var answer = ops.Restock(TransferDto);

            Assert.True(answer.ErrorMessage == "Error: Only 20 cans can be inserted in vending machine at a time");
        }
    }
}

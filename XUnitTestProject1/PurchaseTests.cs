using Core.InterfaceImplementation;
using Core.Shared.Dto;
using Xunit;

namespace XUnitTestProject1
{
    public class PurchaseTests
    {
        [Fact]
        public void ErrorMessage_When_Amountlessthan_Required()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 20,
                TotalCansSold = 0,
                TotalCashCollected = 0,
                TotalCreditCollected = 0,
                CashEntered = 3,
            };

            var ops = new VendingMachineOperations();
            var answer = ops.TakeMoneyAndRefund(TransferDto);

            Assert.True(answer.ErrorMessage == "Money entered was not enough. Please enter atleast 4.5$ in the machine. Please collect your change and try again!!");
        }

        [Fact]
        public void ErrorMessage_When_Amount_Null()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 20,
                TotalCansSold = 0,
                TotalCashCollected = 0,
                TotalCreditCollected = 0,
                CashEntered = null,
            };

            var ops = new VendingMachineOperations();
            var answer = ops.TakeMoneyAndRefund(TransferDto);

            Assert.True(answer.ErrorMessage == "Please enter an amount to buy a can.");
        }

        [Fact]
        public void ErrorMessage_When_NoCansLeft()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 0,
                TotalCansSold = 0,
                TotalCashCollected = 0,
                TotalCreditCollected = 0,
                CashEntered = 5,
            };

            var ops = new VendingMachineOperations();
            var answer = ops.TakeMoneyAndRefund(TransferDto);

            Assert.True(answer.ErrorMessage == "Sorry for inconvenience!! We have no cans left in machine anymore.");
        }

        [Fact]
        public void Success_OnRightAmount_WithRefund_Cash()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 20,
                TotalCansSold = 0,
                TotalCashCollected = 0,
                TotalCreditCollected = 0,
                CashEntered = 6,
                CashCredit = Core.Shared.Enums.CashCreditEnum.cash
            };

            var ops = new VendingMachineOperations();
            var answer = ops.TakeMoneyAndRefund(TransferDto);

            Assert.True(answer.RefundMessage == "Payment Successful. Please Collect your can and change " + (TransferDto.CashEntered - 4.5).ToString() + "$ from the machine. Thanks for your purchase!!");
            Assert.True(answer.TotalCansLeft == 19);
            Assert.True(answer.TotalCashCollected == 4.5);
            Assert.True(answer.TotalCreditCollected == 0);
        }

        [Fact]
        public void Success_OnRightAmount_WithRefund_Credit()
        {
            var TransferDto = new TransferDto
            {
                TotalCansLeft = 20,
                TotalCansSold = 0,
                TotalCashCollected = 0,
                TotalCreditCollected = 0,
                CashEntered = 6,
                CashCredit = Core.Shared.Enums.CashCreditEnum.credit
            };

            var ops = new VendingMachineOperations();
            var answer = ops.TakeMoneyAndRefund(TransferDto);

            Assert.True(answer.RefundMessage == "Payment Successful. Please Collect your can and change " + (TransferDto.CashEntered - 4.5).ToString() + "$ from the machine. Thanks for your purchase!!");
            Assert.True(answer.TotalCansLeft == 19);
            Assert.True(answer.TotalCashCollected == 0);
            Assert.True(answer.TotalCreditCollected == 4.5);
        }
    }
}

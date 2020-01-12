using Core.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Shared.Interface
{
    public interface IVendingMachineOperations
    {
        /// <summary>
        /// If money that is paid is more than price than return money to be refunded
        /// </summary>
        /// <param name="dto">An object which contains information.</param>
        /// <returns></returns>
        TransferDto TakeMoneyAndRefund(TransferDto transferDto);

        /// <summary>
        /// Restocks number of can specified by user inside the machine.
        /// Also resets counts and cash collection to 0.
        /// </summary>
        /// <param name="dto">An object that contains information</param>
        /// <returns></returns>
        TransferDto Restock(TransferDto transferDto);
    }
}

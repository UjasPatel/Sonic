﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interface
{
    public interface IVendingMachineOperations
    {
        string TakeMoneyAndRefund(string canFlavour, double price, double paidMoney);
    }
}

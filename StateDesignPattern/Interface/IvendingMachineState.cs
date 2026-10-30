using StateDesignPattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.Interface
{
    internal interface IvendingMachineState
    {
        void InsertMoney(VendingMachine machine);
        void SelectProduct(VendingMachine machine);
    }
}

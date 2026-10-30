using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Context;
using StateDesignPattern.Interface;

namespace StateDesignPattern.State
{
    internal class ProductDispensedState : IvendingMachineState
    {
        public void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Please reset the machine first");
            
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product has already been dispensed Please reset the machine first.");
        }
            
    }
}

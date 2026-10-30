using StateDesignPattern.Context;
using StateDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.State
{
    internal class MoneyInsertedState : IvendingMachineState
    {
        void InsertMoney(VendingMachine machine)
        {
            Console.WriteLine("Money inserted Succesfully. Please Procees for product selection");
           
        }

        public void SelectProduct(VendingMachine machine)
        {
            Console.WriteLine("Product selected..... Dispensing product");
            machine.SetState(new ProductDispensedState());
                }
    }
}

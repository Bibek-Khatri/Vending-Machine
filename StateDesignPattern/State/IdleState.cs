using System;
using System.Collections.Generic;
using System.Text;
using StateDesignPattern.Context;
using StateDesignPattern.Interface;


namespace StateDesignPattern.State
{

    internal class IdleState : IvendingMachineState
    {
        public void InsertMoney(VendingMachine machine)
        {
            throw new NotImplementedException();
        }

        public void SelectProduct(VendingMachine machine)
        {
            throw new NotImplementedException();
        }
    }
}

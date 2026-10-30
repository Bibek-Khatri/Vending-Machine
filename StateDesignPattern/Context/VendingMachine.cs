using StateDesignPattern.Interface;
using StateDesignPattern.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateDesignPattern.Context
{
    internal class VendingMachine
    {
        private IvendingMachineState _currentstate;

        public VendingMachine()
        {
            _currentstate = new IdleState();
        }

        public void InsertMoney(VendingMachine vendingMachine)
        {
        _currentstate: InsertMoney(this);
        }
        public void SelectProduct(VendingMachine vendingMachine)
        {
        _currentstate: SelectProduct(this);
        
        }

        public void Reset()
        {
            Console.WriteLine("Machine Resset Successfuly");
            _currentstate = new IdleState();

        }

        internal void SelectProduct()
        {
            throw new NotImplementedException();
        }

        internal void InsertMoney()
        {
            throw new NotImplementedException();
        }
    }
}

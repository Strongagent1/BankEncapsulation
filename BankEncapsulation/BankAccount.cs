using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {

        private double _balance = 500;
        public double Deposit(double depAmount)
        {
           return _balance += depAmount;
        }
        public void Withdrawal(double amount)
        {
            _balance -= amount;
        }
        public double GetBalance()
        {
            return _balance; 
        }

        


    }   
}

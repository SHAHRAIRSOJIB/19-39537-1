using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject1
{
    public class Account
    {
        private string accName;
        private string acid;
        private int balance;
        
        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
         public string Acid
        {
            set { acid = value; }
            get { return acid; }

        }
         public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
         public Account() { }

          public Account(string accName, string acid, int balance)
        {
            this.AccName = accName;
            this.Acid = acid;
            this.Balance = balance;
        }
         public void Deposit(int amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(int amount)
        {
            if(this.Balance < amount)
            {
                Console.WriteLine("[Error]: Amount is higher than balance!!");
            }
            else
            {
                this.Balance += amount;
            }

        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject1
{
    class Account
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

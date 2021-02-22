using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_Week_5__22._2_inheritance
{

    class Program
    {
        static void Main(string[] args)
        {

    //fixed

            Fixed f1 = new Fixed("abc", "001", 45000, 2);
            Fixed f2 = new Fixed("xyz", "002", 4000, 3);
            f1.Withdraw(620);
            f1.Deposit(200);
            f1.Transfer(500, f2);

            f1.ShowInfo();
            f2.ShowInfo();

         //special current
            SpecialCurrent sc1 = new SpecialCurrent("RHUL", "0060", 3000);
            SpecialCurrent sc2 = new SpecialCurrent("Amin", "0026", 2000);
            sc1.Withdraw(1000);
            sc1.Deposit(1250);
            sc1.Transfer(9000, sc2);

            sc1.ShowInfo();
            sc2.ShowInfo();

         

   //over draft

            OverDraft od1 = new OverDraft("abd", "1203", 5000);
            OverDraft od2 = new OverDraft("def", "1110", 4000);
            od1.Withdraw(500);
            od1.Deposit(1000);
            od1.Transfer(5000, od2);

            od1.ShowInfo();
            od2.ShowInfo();

            //Savings
            Savings s1 = new Savings("abir", "2211", 4000);
            Savings s2 = new Savings("rahman", "7890", 1500);
            s1.Withdraw(500);
            s1.Deposit(1000);
            s1.Transfer(1000, s2);

            s1.ShowInfo();
            s2.ShowInfo();
        }
    }
}
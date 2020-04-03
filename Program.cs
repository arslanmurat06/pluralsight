using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account myAccount = new Account();
            //myAccount.HesabaYatır(125);
            //myAccount.HesaptanCek(10);
            //myAccount.FreezeAccount();
            //myAccount.CloseAccount();


            AdvancedAccount myAccount = new AdvancedAccount();
            myAccount.HesabaYatır(125);
            myAccount.HesapDurum();
            myAccount.HesaptanCek(10);
            myAccount.FreezeAccount();
            myAccount.HesapDurum();
            myAccount.CloseAccount();
            myAccount.HesapDurum();

            Console.ReadLine();
        }
    }

}

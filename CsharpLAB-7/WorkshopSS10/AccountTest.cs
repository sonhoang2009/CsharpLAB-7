using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;

namespace BankTest
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account objAccount = new Account();

            if (objAccount.AcceptDetails())
                objAccount.DisplayDetails();
            Console.ReadKey();
        }
    }
}

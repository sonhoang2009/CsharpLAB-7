using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        int[] accountNumber = new int[2];
        string[] accountType = new string[2];
        double[] balance = new double[2];

        public bool Deposit(int accNumber, double amount)
        {
            for(int i =0;i<accountNumber.Length; i++)
            {
                if(accountNumber[i] == accNumber)
                {
                    balance[i] = balance[i] + amount;
                    return true;
                }
            }
            return false;
        }

        public bool Withdraw(int accNumber, double amount)
        {
            for (int i=0; i<accountNumber.Length;i++)
            {
                if(accountNumber[i] == accNumber)
                {
                    if(amount > balance[i] -1)
                    {
                        balance[i] = balance[i];
                        Console.WriteLine("Insufficiton balance");
                        Console.WriteLine("Minium balance must be one dolla");
                    }
                    else
                    {
                        balance[i] = balance[i] - amount;
                        return true;
                    }
                }
            }
            return false;
        }

        public int Search(int accNo)
        {
            for(int i=0;i<accountNumber.Length; i++)
            {
                if (accNo == accountNumber[i])
                    return i;
            }
            return -1;
        }

        public bool AcceptDetails()
        {
            int accNo;
            string accType;
            double bal;
            for(int i=0; i<accountNumber.Length;i++)
            {
                Console.Write("Enter the account number : ");
                accNo = Convert.ToInt32(Console.Read());
                if(accNo<=0)
                {
                    Console.WriteLine("invalid account ");
                    return false;
                }

                Console.Write("Enter account type [Fixed/Saving]/[F/S] : ");
                string input = Console.ReadLine();
                if(input =="F" || input == "Fixed" || input == "f")
                {
                    accType = "Fixed";
                }
                else if (input == "S" || input == "Savings" || input == "s")
                {
                    accType = "Savings";
                }
                else
                {
                    Console.WriteLine("Invalid Data Entry ");
                    return false;
                }

                int index = Search(accNo);
                if(index != -1)
                {
                    Console.WriteLine("Current balance : {0} ", balance[index]);
                    accountNumber[i] = accNo;
                    accountType[i] = accType;
                }
                else
                {
                    Console.Write("enter currnet  balance : ");
                    bal = Convert.ToDouble(Console.ReadLine());
                    if(bal < 1)
                    {
                        Console.WriteLine("Minimum balance must be 1 dolla");
                        return false;
                    }
                    accountNumber[i] = accNo;
                    accountType[i] = accType;
                    balance[i] = bal;
                }

                Console.WriteLine("Enter transcation type :");
                Console.WriteLine("1. Deposit \n2. Withdraval");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.Write("Enter amount to be deposited : ");
                        input = Console.ReadLine();
                        if(Convert.ToDouble(input)>1)
                        {
                            if(Deposit(accountNumber[i],Convert.ToDouble(input)))
                            {
                                Console.WriteLine("Amount deposited seccussfully..");
                            }
                            else
                            {
                                Console.WriteLine("Error in updating balance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount");
                            return false;
                        }
                        break;

                    case 2:
                        Console.Write("Enter amount to be withdraw : ");
                        input = Console.ReadLine();
                        if(Convert.ToDouble(input) > 1)
                        {
                            if(Withdraw(accountNumber[i], Convert.ToDouble(input)))
                            {
                                Console.WriteLine("Amount successfully withdraw ...");
                            }
                            else
                            {
                                return false;
                            }

                        }
                        else
                        {
                            Console.WriteLine("invalid Amount");
                            return false;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        return false;

                }
                Console.WriteLine();
            }
            return true;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nAccount Details : \n");
            Console.WriteLine("A/c No. \tA/c Type Balance {$}");
            Console.Write("{0} \t", accountNumber[0]);
            Console.WriteLine("{0}\t {1}\t", accountType[0], balance[0]);
            for(int i=1; i< accountNumber.Length; i++)
            {
                bool found = false;
                for(int j =0; j< i; j++)
                {
                    if (accountNumber[i] == accountNumber[j])
                        found = true;
                }
                if(!found)
                {
                    Console.WriteLine("{0} \t ", accountNumber[i]);
                    Console.WriteLine("{0} \t {1}\t ", accountType[i], balance[i]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall
{
    public delegate double Rebate(double val);

    public delegate bool Call();



    public class ElectronicStore
    {
        internal string ItemName;

        internal float Rate;

        internal double ItemPrice = 0;

        internal int Quantity = 0;

        public bool ChooseProduct()
        {
            bool flag = true;

            int value;

            Console.WriteLine("Select the products sold ");
            Console.WriteLine(" 1. Air Conditioner\n 2. Television\n 3. Washing Machine   ");
            Console.Write("Enter your choice : ");
            value = Convert.ToInt32(Console.ReadLine());
            
            switch(value)
            {
                case 1:
                    ItemName = "Air Conditiner";
                    break;
                case 2:
                    ItemName = "Television";
                    break;
                case 3:
                    ItemName = "Washing Machine";
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    flag = false;
                    break;
            }

            if(flag)
            {
                AcceptDetails();
            }
            else
            {
                return false;
            }
            return true;
        }

        void AcceptDetails()
        {
        Start:
            Console.Write("Enter the product price : ");
            try
            {
                ItemPrice = Convert.ToDouble(Console.ReadLine());

                if(ItemPrice < 0)
                {
                    Console.WriteLine("Value of product cannot be negative");
                    goto Start;
                }
            }
            catch(FormatException objFormatOne)
            {
                Console.WriteLine("Error:  " + objFormatOne.Message);
            }

        Next:
            Console.Write("Enter the quantity sold : ");
            try
            {
                Quantity = Convert.ToInt32(Console.ReadLine());

                if(Quantity < 0)
                {
                    Console.WriteLine("Quantity cannot be nagative ");
                    goto Next;
                }
            }
            catch(FormatException objFormatTwo)
            {
                Console.WriteLine("Error : " + objFormatTwo.Message);
            }
        }

        public double Discount (double val)
        {
            double discount;

            if(val <= 1000)
            {
                discount = val * 0.1;
                Rate = 10;
            }
            else if ((val > 1000) && (val <= 2000))
            {
                discount = val * 0.2;
                Rate = 20;
            }
            else if ((val > 2000) && (val <= 3000))
            {
                discount = val * 0.3;
                Rate = 30;
            }
            else
            {
                discount = val * 0.5;
                Rate = 50;
            }
            return discount;

        }
        public double ValueOfGoods()
        {
            double value = Quantity * ItemPrice;
            return value;
        }


    }
}

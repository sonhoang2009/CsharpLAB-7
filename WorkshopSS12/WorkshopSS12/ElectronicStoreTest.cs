using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall
{
    class ElectronicStoreTest
    {
        ElectronicStore objStore = new ElectronicStore();

        bool Display()
        {
            Rebate objRebate = new Rebate(objStore.Discount);

            double total = objStore.ValueOfGoods();

            double value = objRebate(total);
            double netValue = total - value;

            Console.WriteLine();
            Console.WriteLine("Product Name: \t\t" + objStore.ItemName);
            Console.WriteLine("Price per unit: \t " + objStore.ItemPrice);
            Console.WriteLine("Number of Units sold: \t" + objStore.Quantity);
            Console.WriteLine("Total Price : \t\t" + total);
            Console.WriteLine("Discount Rate : \t\t" + objStore.Rate + "%");
            Console.WriteLine("Discount: \t\t"+ value);
            Console.WriteLine("Net Value: \t\t" + netValue);

            return true;

        }


        static void Main(string[] args)
        {
            ElectronicStoreTest objTest = new ElectronicStoreTest();

            Call objCall = new Call(objTest.objStore.ChooseProduct);

            if(objCall())
            {
                objCall -= new Call(objTest.objStore.ChooseProduct);

                objCall += new Call(objTest.Display);

                objCall();
            }    
            else
            {
                return;
            }

            Console.ReadKey();
        }
    }
}

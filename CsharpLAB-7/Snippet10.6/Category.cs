using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automovie
{
    public class Category
    {
        string _category;
        public Category()
        {
            _category = "multi utility Vechile";
        }
        public void Display()
        {
            Console.WriteLine("Category " + _category);
        }
    }
}

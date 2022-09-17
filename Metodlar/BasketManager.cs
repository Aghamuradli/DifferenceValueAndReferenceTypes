using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    public class BasketManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations . Added basket : " + product.Name);
        }
        public void Add2(string name , string description , double price , int stocked)
        {
            Console.WriteLine("Congratulations . Added basket : " + name);

        }
    }
}

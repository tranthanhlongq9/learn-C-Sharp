using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            double total = product.GetTotal(50000, 10);
            Console.WriteLine("Total of order: " + total);

            Console.ReadKey();
        }
    }

    interface IProduct //interface : 1 - luôn là public
                                  // 2 - không định nghĩa đc thân hàm
                                  // 3 - 1 class có thể kế thừa nhìu interface
    {
        double GetTotal(double price, int quantity);

    }
    class Product : IProduct
    {
        public double GetTotal(double price, int quantity)
        {
            return price * quantity;
        }
    }

}

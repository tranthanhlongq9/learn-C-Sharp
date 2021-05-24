using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int i = 1;
            while(i < 10)
            {
                Console.WriteLine("biến số i: " + i);
                i += 1;
            }

            Console.ReadKey();
        }
    }
}

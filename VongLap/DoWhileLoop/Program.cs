using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int i = 0;

            do
            {
                i++;
                Console.WriteLine("number: " + i);
                
            } while (i < 10);

            Console.ReadKey();

        }
    }
}

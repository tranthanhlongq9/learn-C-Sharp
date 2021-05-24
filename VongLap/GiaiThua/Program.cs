using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tính giai thừa của 1 số  ( số giai thừa: 2! )

            Console.WriteLine("Nhập số: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int sup = 1;

            for(int i = number; i >= 1; i--)
            {
                sup = sup * i;
            }
            Console.WriteLine(sup);
            Console.ReadKey();

        }
    }
}

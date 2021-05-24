using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhập vào 1 số và cho biết đó là số lẻ hay chẵn
            Console.OutputEncoding = Encoding.UTF8; //in ra viết dấu 

            Console.WriteLine("Nhập số: ");
            string numbers = Console.ReadLine();
            int num = int.Parse(numbers);

            if(num %2 == 0)
            {
                Console.WriteLine("-> Đây là số chẵn");
            }
            else
            {
                Console.WriteLine("-> Đây là số lẻ");
            }

            
            Console.ReadKey();
        }
    }
}

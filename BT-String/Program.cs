using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //mời ng dùng nhập 2 chuỗi sau đó ghép lại và show ra..

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Mời nhập chuỗi 1: ");
            string str1 = Console.ReadLine();          

            Console.WriteLine("Mời nhập chuỗi 2: ");
            string str2 = Console.ReadLine();

            Console.WriteLine("KQ nối 2 chuỗi: " + string.Concat(str1," ",str2));

            Console.ReadKey();

        }
    }
}

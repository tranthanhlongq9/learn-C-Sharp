using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tìm số chẵn, số lẻ trong mảng
            for(int i = 0; i <= 10; i++)
            {
                //số chẵn
                //if (i %2 == 0) 
                //{ 
                //Console.WriteLine("Các bước lặp chẵn: " + i);
                //}

                //số lẻ
                if (i % 2 != 0)
                {
                    Console.WriteLine("các bước lặp chẵn: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}

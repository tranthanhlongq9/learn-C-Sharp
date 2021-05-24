using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //tính tổng của cả mảng sau:
            int sum = 0;
            foreach(int item in arr)
            {
                sum += item;
                Console.WriteLine("sum tăng lên qua mỗi lần lặp là: " + sum);
            }
            Console.WriteLine("Tổng cả mảng là: {0}", sum);

            Console.ReadKey();
        }
    }
}

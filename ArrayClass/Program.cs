using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //dùng Array class có sẵn

            int[] arr = new int[] {9, 4, 6, 1, 8, 5 };

            foreach (int item in arr)
            {
                
                Console.WriteLine("mảng chưa sắp xếp: " + item);
            }

            Console.WriteLine("---------------------------");

            Array.Sort(arr); //1 phương thức sắp xếp có sẵn trong class Array

            foreach(int item in arr)
            {
                Console.WriteLine("mảng khi đc sắp xếp: " + item);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Chiều dài mảng: " + arr.Length); // " .Length " là chiều dài của mảng


            Console.ReadKey();

        }
    }
}

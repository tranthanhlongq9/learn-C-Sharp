using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayType
{
    class Program
    {
        static void Main(string[] args)
        {
            //mảng 1 chiều

            //1. Initialize
                //--c1:
            int[] number = new int[6]; // khởi tạo bộ nhớ cho mảng = 10
            number[0] = 0;
            number[1] = 10;
            number[2] = 1;
            number[3] = 5;
            number[4] = 2;

                //--c2:
            string[] names = new string[] { "Anh", "Long", "Na" }; //khởi tạo bộ nhớ rồi truyền thẳng giá trị vào

            //2. Access arrays - truy cập mảng(có thể truy cập ngẫu nhiên)
            Console.WriteLine("number so 2 trong array: " + number[1]);
            Console.WriteLine("---------------------------");
            Console.WriteLine("name so 2 trong array: " + names[1]);

            Console.WriteLine("---------------------------");

            //bt : lấy tất cả name có trong mảng
            foreach (string name in names)
            {
                Console.WriteLine("Ten trong Array lan luot la: " + name);
            }
            Console.WriteLine("---------------------------");

            //bt: xuất ra các số có trong mảng
            for (int i =0; i < number.Length; i++)
            {
                Console.WriteLine("vi tri thứ i = {0}, number[{1}] = {2}", i, i, number[i]);
            }


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhập tuổi để xác dịnh
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số tuổi");

            //biến để lưu dữ liệu nhập vào
            string age = Console.ReadLine();
            //biến để ép kiểu
            byte numAge = Convert.ToByte(age);

            if(numAge < 1)
            {
                Console.WriteLine("Tuổi không hợp lệ");

            }else if (numAge <= 18)
            {
                Console.WriteLine("Tuổi vị thành niên");

            }else if(numAge <= 40)
            {
                Console.WriteLine("Tuổi thanh niên");

            }else if(numAge <= 60)
            {
                Console.WriteLine("Tuổi trung niên");
            }
            else
            {
                Console.WriteLine("Tuổi già");
            }


            Console.ReadKey();
        }
    }
}

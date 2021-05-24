using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //nhập code vào và biết loại sp gì
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập code (Viết hoa): ");

            string code = Console.ReadLine();

            switch(code)
            {
                case "A":
                    Console.WriteLine("Sp công nghệ");
                    break;
                case "B":
                    Console.WriteLine("Sp thời trang");
                    break;
                case "C":
                    Console.WriteLine("Sp sinh học");
                    break;
                case "D":
                    Console.WriteLine("Sp y tế");
                    break;
                default:
                    Console.WriteLine("Code không hợp lệ !!");
                    break;
            }

            Console.ReadLine();

        }
    }
}

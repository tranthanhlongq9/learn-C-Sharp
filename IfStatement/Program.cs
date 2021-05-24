using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter \" hi \" ");

            name = Console.ReadLine(); //readline nhận dữ liệu từ bàn phím
            //if
            if (name == "hi")
            {
                Console.WriteLine("xin chào ^..^ ");
            }
            else
            {
                Console.WriteLine("Enter \" hi \" nhaa !! ");
            }
            

            Console.ReadKey();
        }
    }
}

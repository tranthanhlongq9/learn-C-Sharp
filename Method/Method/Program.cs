using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Calculation calculation = new Calculation();

            //Console.WriteLine(calculation.FindMax(2,5)); // cách 1 truyền thẳng tham số

            //cách 2: cách này sẽ khai báo biến chứa tham số bên ngoài rồi sau đó gọi phương thức và truyền biến tham số vào
            int num1 = 20;
            int num2 = 35;
            Console.WriteLine(calculation.FindMax(num1, num2));

            Console.ReadKey();
        }
    }

    public class Calculation
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if(num1 > num2)
            {
                result = num1;
               
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
}


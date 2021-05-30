using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQuy
{
    class Program
    {
        //Đệ quy là dùng lại hàm bên trong hàm đó
        //Tính giai thừa bằng đệ quy

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Calculation cal = new Calculation();
            int result = cal.GetGiaiThua(3);
            Console.WriteLine("Số giai thừa = " + result);

            Console.ReadKey();
        }
    }

    public class Calculation
    {
        public int GetGiaiThua(int number)
        {
            int numGT = 1;
            if(number == 1)
            {
                return 1;
            }
            else
            {
                numGT = GetGiaiThua(number - 1) * number; // đệ quy
                return numGT;
            }
        }
    }
}

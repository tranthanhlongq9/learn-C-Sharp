using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Calculation cal = new Calculation();

            int a;
            //int b = 200;
            //Console.WriteLine("Trước khi swap: a = {0}, b = {1}", a, b);

            //cal.Swap(ref a, ref b);
            //Console.WriteLine("Sau khi swap: a = {0}, b = {1}", a, b);

            cal.GetValue(out a); //out cũng giống vs ref nhưng nó không cần khởi tạo giá trị cho biến
            Console.WriteLine("a = " + a);

            Console.ReadKey();

        }
    }

    public class Calculation
    {
        public void Swap(ref int a, ref int b) //ref vs out sẽ thay đổi thẳng vào bộ nhớ biến mà không tạo 1 bộ nhớ khác
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        public void GetValue(out int a)
        {
            int temp = 5;
            a = temp;
        }
    }
}

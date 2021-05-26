using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //initial strings 
            string name = "Tran Thanh Long "; //lenght = 16
        
            Console.WriteLine("Lenght: " + name.Length);
            Console.WriteLine("-----------------------------");

            //nối chuỗi bằng --> string.concat("chuỗi","chuỗi","chuỗi","chuỗi"); : có thể nối nhiều chuỗi lại với nhau
            //giống với dấu " + "
            Console.WriteLine("Nối chuỗi bằng concat: " + string.Concat("Viet", " ", "Nam"));
            Console.WriteLine("-----------------------------");

            //ToUpper(): Viết hoa chuỗi
            Console.WriteLine("Viết hoa cả chuỗi: -->  " + name.ToUpper());
            Console.WriteLine("-----------------------------");

            // Substring( .. truyền vị trí muốn cắt vào ..): cắt chuỗi 
            Console.WriteLine("Cắt chuỗi tại vị trí 3: -->  " + name.Substring(3));
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Cắt chuỗi vs split(' ') ");
            //split(): dùng để cắt .. ('char'): truyền kiểu char vào trong -> ' ' ..  sau đó sẽ cắt bỏ cái phần giá trị truyền vào này.
            string[] arr = name.Split(' ');
            
            foreach(var item in arr) //var là kiểu khai báo linh hoạt .. 
                                // khai báo liền là sử dụng đc lun.. phải gán liền dữ liệu cho nó.
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");


            char[] kytu = new char[] { 'a', 'b', 'c' };
            string strKyTu = new string(kytu);
            //so sánh chuỗi
            Console.WriteLine("so sánh bằng (Equals): " + strKyTu.Equals("ahhh")); //false vì ko giống nhau
            Console.WriteLine("so sánh bằng (Equals): " + strKyTu.Equals("abc")); //true vì giống nhau

            Console.ReadKey();
        }
    }
}

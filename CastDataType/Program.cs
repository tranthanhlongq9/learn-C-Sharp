using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // chuyển đổi kiểu ngầm định ( implicity )
            byte a = 1;
            int b;
            b = a;

            Console.WriteLine(b);

            //chuyển đổi kiểu chủ định ( explicity )
            int a1 = 121;
            byte b1;            

            //ép kiểu cách 1 ( casting )
            b1 = (byte)a1;
            Console.WriteLine(b1);

            //ép kiểu cách 2 ( dùng hàm convert )       
            string name = "12312";
            int nameInt = Convert.ToInt32(name);
            Console.WriteLine(nameInt);

            string date = "12/30/2021";
            DateTime dateNormal = Convert.ToDateTime(date);
            Console.WriteLine(dateNormal.ToLongDateString());

            //ép kiểu cách 3 ( parse )
            string x1 = "12345";
            int x2 = int.Parse(x1);
            Console.WriteLine(x2);

            string x3 = "true";
            bool x4 = bool.Parse(x3);
            Console.WriteLine(x4);

            //ép kiểu cách 4 ( try parse ) dùng try parse sẽ vẫn trả về kq là 0 nếu parse sai, trành dừng chường trình 
            string number = "11a2233";
            int resultNumber;

            bool parseResult = int.TryParse(number, out resultNumber);

            Console.WriteLine(string.Format("ket qua: {0}, number tra ve: {1}", parseResult, resultNumber));


            
            Console.ReadKey();

        }
    }
}

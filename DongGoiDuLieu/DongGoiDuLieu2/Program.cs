using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongGoiDuLieu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Rectangle rec = new Rectangle(); //khởi tạo 1 obj
            rec.SetHeight(30); // gán giá trị
            rec.SetWidth(20); // gán giá trị

            int area = rec.GetArea(); //khai báo 1 biến lưu giá trị của phương thức GetArea()

            Console.WriteLine("Diện tích hình chữ nhật: " + area); //in ra màn hình kết quả

            Console.ReadKey();
        }
    }

    public class Rectangle  //hình chữ nhật
    {
        private int _width;
        private int _height;

        public void SetWidth(int width) //gán giá trị đc truyền vào
        {
            _width = width;
        }

        public void SetHeight(int height) //gán giá trị đc truyền vào
        {
            _height = height;
        }

        public int GetArea() //phương thức tính diện tích
        {
            return _height * _width;
        }
    }

}

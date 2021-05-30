using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape_Hinh shape = new Shape_Hinh();
            Rectangle_HCN rec = new Rectangle_HCN();
            rec.SetHeight(30);
            rec.SetWidth(12);

            Console.WriteLine("Dien Tich: " + rec.GetArea());
            Console.WriteLine("Perimeter (Chu Vi): " + rec.GetPerimeter());

            Console.ReadKey();
        }
    }
    
    class Shape_Hinh
    {
        protected int _width;
        protected int _height;
        

        public void SetWidth(int width) //protected thì chỉ class nào kế thừa mới được sử dụng
        {
            _width = width;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }
    }


    interface ICalculation //interface 
    {
        int GetPerimeter();
    }
   
    class Rectangle_HCN : Shape_Hinh, ICalculation  //kế thừa ở C# là " : " ,ở java là extend
                                 //đa kế thừa
    {
        public int GetArea()
        {
            return _width * _height;
        }

        public int GetPerimeter() //phải gọi lại pt của interface ko thì sẽ báo lỗi
        {
            return (_width + _height) * 2;
        }
    }
   
}

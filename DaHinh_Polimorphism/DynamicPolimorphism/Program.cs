using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolimorphism
{
    //đa hình động

    class Program
    {
        static void Main(string[] args)
        {
            Caller caller = new Caller();
            Rectangle rec = new Rectangle(3,4);
            Triangle tri = new Triangle(43,54);

            
            Console.WriteLine("Dien tich HCN: " + caller.GetArea(rec));

            Console.WriteLine("------------------------");

            Console.WriteLine("Dien tich Tam Giac: " + caller.GetArea(tri));


            Console.ReadKey();
        }
    }

    class Shape
    {
        protected int _width;
        protected int _height;

        protected Shape(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public virtual int GetArea()  //virtual: phương thức ảo
        {
            Console.WriteLine("this is parent method");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {

        }

        public override int GetArea() //pham vi truy cập của class cha là gì thì class con cũng phải là kiểu đấy
        {
            Console.WriteLine("Rectangle area: ");
            return _width * _height;
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a, int b) : base(a,b)
        {

        }

        public override int GetArea() //override : ghi đè phương thức virtual ở class cha
        {
            Console.WriteLine("Triangle area: ");
            return (_width * _height) / 2;
        }
    }

    class Caller
    {
        public int GetArea(Shape shape)
        {
            int area = shape.GetArea();
            return area;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialBaseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(13,43);

            table.Display();

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _height = height;
            _width = width;
        }

        public double GetArea()
        {
            return _width * _height;
        }

        public void Display()
        {
            Console.WriteLine("Width: " + _width);
            Console.WriteLine("Height: " + _height);
            Console.WriteLine("Area: " + GetArea());
        }
    }

    class Table : Rectangle
    {
        public Table(int width, int height) : base(width, height) //base là contructor kế thừa từ class cha
        {

        }

        public double GetCost()
        {
            double cost;
            cost = GetArea();
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: " + GetCost());
        }
    }

}

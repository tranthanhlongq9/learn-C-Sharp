using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.SetBreadth(3);
            box1.SetHeight(4);
            box1.SetWidth(5);

            Console.WriteLine("Box 1 volumne = " + box1.GetVolunme());

            Box box2 = new Box();
            box1.SetBreadth(6);
            box1.SetHeight(5);
            box1.SetWidth(7);

            Console.WriteLine("Box 2 volumne = " + box2.GetVolunme());

            Box box3 = box1 + box2;
            Console.WriteLine("Box 3 volumne = " + box3.GetVolunme());


            Console.ReadKey();
        }
    }

    class Box
    {
        private int _width, _height, _breadth;

        public void SetWidth(int width)
        {
            _width = width;
        }
        public void SetHeight(int height)
        {
            _height = height;
        }
        public void SetBreadth(int breadth)
        {
            _breadth = breadth;
        }


        public int GetVolunme()
        {
            return _width * _height * _breadth;
        }

        public static Box operator+ (Box box1, Box box2)
        {
            Box box3 = new Box();

            box3.SetWidth(box1._width + box2._width);
            box3.SetHeight(box1._height + box2._height);
            box3.SetBreadth(box1._breadth + box2._breadth);

            return box3;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Persion per = new Persion();
            per.Say();              // đễ rỗng
            per.Say("Long");        // truyền tham số tên
            per.Say(8);             // truyền tham số điểm
            per.Say("Long",8);      // truyền tham số tên và điểm

            Console.ReadKey();
        }
    }

    class Persion
    {
        //đa hình tĩnh

        public void Say() //khởi tạo phương thức tên say
        {
            Console.WriteLine("No name");
        }

        public void Say(string name) //vẫn là phương thức tên say nhưng khác tham số nên khởi tạo đcc.. vậy đây chính là tính đa hình
        {
            Console.WriteLine("My name is " + name);
        }

        public void Say(int mark) //đây là đa hình
        {
            Console.WriteLine("Mark is: " + mark);
        }

        public void Say(string name, int mark) //đây là đa hình
        {
            Console.WriteLine("My name is " + name + " --- and Mark is: " + mark);
        }
    }
}

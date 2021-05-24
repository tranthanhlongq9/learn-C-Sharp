using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongGoiDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Persion persion1 = new Persion(); // có thể truyền vào cho nó giá trị tham số tương ứng vs các constructor..
            persion1.SetName("Long nè");
            Console.WriteLine(persion1.SayName());
            

            Console.ReadKey();
        }
    }

    //class persion
    class Persion
    {
        public Persion() //Phải có 1 constructor trống để obj ko yêu cầu truyền tham số vào.
        {     
            
        }

        public Persion(float height) //khởi tạo 1 constructor
        {
            _height = height;
        }
        public Persion(string name) //có thể khởi tạo nhiều constructor vs các giá trị tham số khác nhau
        {
            _name = name;
        }

        private string _name; //biến chứa giá trị
        public float _height;

        protected void Run() //các phương thức
        {
            Console.WriteLine("class Persion is running..");
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string SayName() //các phương thức
        {
            return _name;
        }

        public float SayHeight() //các phương thức
        {
            return _height;
        }
    }
}

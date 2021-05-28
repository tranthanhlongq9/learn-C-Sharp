using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLession
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student student1 = new Student();
            Student student2 = new Student("B",7);

            Student.dantoc = "Kinh";


            student1.SetName("A");
            student1.SetMark();
            student1.GetInfo();
            student1.GetDanToc();

            Console.WriteLine("________________");

            //student2.SetName("B");
            student2.GetInfo();
            student2.GetDanToc();
            

            //student.SetName("AAAA");
            //student.SetMark();

            //student.GetInfo();



            Console.ReadKey();
        }
    }

    public class Student
    {
        public static string dantoc; //biến static là biến dùng chung .. các obj đều có thể dùng chung

        private string _name;
        private byte _mark;
        //khởi tạo constructor là trùng tên vs tên class
        public Student()
        {
            Console.WriteLine("Khoi tao Constructor rỗng thanh cong");
        }
        public Student(string name)
        {
            _name = name;
            Console.WriteLine("Khoi tao Constructor 1 tham số thanh cong");
        }
        public Student(string name, byte mark)
        {
            _name = name;
            _mark = mark;

            Console.WriteLine("Khoi tao Constructor 2 tham số thanh cong");
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public byte SetMark()
        {
            _mark = 5;
            return _mark;
        }

        public string GetName()
        {
            
            return _name;
        }

        public void GetDanToc()
        {
            Console.WriteLine("Dân tộc: " + dantoc);
        }

        public void GetInfo()
        {
            Console.WriteLine("Học sinh: " + _name + " được: " + _mark + " điểm");
        }


        //destructor : là gọi khi mà đối tượng bị hủy
        //khi cần hủy đối tượng thì gọi phần tử này
        //cái phần tử này sẽ giúp thu hồi bộ nhớ , hoặc các thao tác khi obj bị hủy.
        //phần tử này k thể ghi đè hay kế thừa.
        ~Student()
        {
            Console.WriteLine("Object bị phá hủy");
        }

    }
}

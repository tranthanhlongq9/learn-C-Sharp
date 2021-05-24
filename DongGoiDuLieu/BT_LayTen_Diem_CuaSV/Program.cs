using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LayTen_Diem_CuaSV
{
    class Program
    {
        //BT: lấy điểm, tên của sv , set lại điểm và tên.
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //SinhVien sinhvien = new SinhVien("Long Thành",9); //cách 1 dùng constructor và truyển thẳng tham số vào
            SinhVien sinhvien = new SinhVien(); // cách 2 là gọi đến từng phương thức và truyền vào
            sinhvien.SetName("Long A");
            sinhvien.SetDiem(10);

            Console.WriteLine("Tên SV: " + sinhvien.GetName());
            Console.WriteLine("Điểm tb: " + sinhvien.GetDiemSV());

            Console.ReadKey();
        }
    }

    public class SinhVien
    {
        public SinhVien()
        {

        }
        public SinhVien(string name, byte diem)
        {
            _nameSV = name;
            _diem = diem;
        }

        private byte _diem = 8;
        private string _nameSV = "Tran A B C";

        public int GetDiemSV()
        {
           // _diem = 8;
            return _diem;
        }
        public string GetName()
        {
           // _nameSV = "Tran A B C";
            return _nameSV;
        }

        public void SetName(string name)
        {
            _nameSV = name;
        }
        public void SetDiem(byte diem)
        {
            _diem = diem;
        }

    }
}

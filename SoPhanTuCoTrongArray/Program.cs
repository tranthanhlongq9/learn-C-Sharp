using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoPhanTuTrongArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //BT: tính tổng các phần tử trong mảng

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };  // =15

            ParamArray sumArr = new ParamArray();

            int sum = sumArr.AddElement(1, 2, 3, 4, 5); // tổng mảng = 15

            //Console.WriteLine("Tổng phần tử trong mảng: " + sumArr.AddElement(arr));
            Console.WriteLine("Tổng phần tử trong mảng: " + sum);

            Console.ReadKey();

        }
    }

    class ParamArray
    {
        public int AddElement(params int[] arr) //tham số được truyền vào đi kèm với từ khóa "params" chỉ được phép là mảng một chiều.
                                //params : -->  Trường hợp chúng ta muốn viết một phương thức mà không biết trước được số lượng tham số người dùng sẽ truyền vào là bao nhiêu 
                                   //thì sẽ phải làm thế nào ? Tức là trong trường hợp này, người dùng truyền vào bao nhiêu tham số cũng được, 
                                        //bên trong phương thức sẽ sử dụng bấy nhiêu tham số đó để thực hiện tính toán rồi output kết quả mong muốn.
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}

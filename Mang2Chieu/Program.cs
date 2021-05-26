using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muliple dimentional ( mảng 2 chiều )
            //1,2,3,4,5,6,7,8
            //8,7,6,5,4,3,2,1

            int[,] mangHaiChieu = new int[3, 4] // mảng có 3 dòng và 4 cột
                                        //mảng 2 chiều là mảng của các mảng 1 chiều
                                        //ta sẻ có 3 mảng 1 chiều và mỗi mảng có 4 phần tử
            {
                {1,3,4,5},
                {4,5,6,7},
                {3,4,1,5}
            };

            //truy cập vào mảng 2 chiều:
            //-bt: xuất ra các số có trong mảng 2 chiều:
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("So trong mang 2 chieu: arr[" + i + "," + j + "]: " + mangHaiChieu[i,j] );
                }
            }


            Console.ReadKey();

        }
    }
}

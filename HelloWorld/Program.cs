using System;

namespace HelloWorld
{
    class HelloWorld
    {
        /// <summary>
        ///     phương thức main của class HelloWorld
        ///     
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //in dòng chữ hello world lên màn hình
            Console.WriteLine("Hello World");
            //dừng màn hình để xem kết quả
            Console.ReadKey();

            //sẻ ko in aa ra màn hình vì ReadKey đã dừng màn hình.
            Console.WriteLine("aa");
        }
    }
}
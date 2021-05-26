using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] numbers = new int[] { 1, 3, 43, 2, 5, 6, 4, 75, 78 }; //chiều dài mảng 9

            AverageArray avg = new AverageArray();

            float average = avg.GetAverage(numbers, 9);

            Console.WriteLine("Tính trung bình của mảng: " + average);

            Console.ReadKey();
        }
    }

    class AverageArray
    {
        public float GetAverage(int[] arr, int size)
        {
            int sum = 0;
            for(int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            float average = sum / size;

            return average;
        }
    }
}

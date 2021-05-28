using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    class Program
    {
        static void Main(string[] args)
        {
            //struct là 1 kiểu value type (kiểu giá trị) còn class là 1 kiểu tham chiếu (reference type)
            // kiểu tham trị ( giá trị của nó--biến sẽ trỏ thẳng đến giá trị của nó nằm trên bộ nhớ stack)
            //kiểu tham chiếu ( chỉ có địa chỉ bộ nhớ của nó nằm trên bộ nhớ stack, còn giá trị thực nằm trên bộ nhớ heap )

            Contact contact1 = new Contact();
            contact1.Address = "Q9 TPHCM";
            contact1.CreditCard = 121341;
            contact1.Gender = true;
            contact1.Birthday = DateTime.Parse("05/27/2021");

            contact1.Print();

            Console.ReadKey();
        }
    }

    //struct giống 1 class nhưng nó ko có hỗ trợ kế thừa
    // cũng ko hỗ trợ tạo 1 default constructor như class
    //vẫn có thể kế thừa từ ng khác

    public struct Contact
    {
        public string Address;
        public int CreditCard;
        public bool Gender;
        public DateTime Birthday;

        public void Print()
        {
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("CreditCard: " + CreditCard);
            Console.WriteLine("Gender: " + (Gender?"Male":"Female"));
            Console.WriteLine("Birthday: " + Birthday.ToString("dd/MM/yyyy"));
        }
    }
}

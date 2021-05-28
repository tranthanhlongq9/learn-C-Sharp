using EnumType.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your role: ");
            string input = Console.ReadLine();

            if((int)Role.Administrator == int.Parse(input))
            {
                Console.WriteLine("Your role: " + Role.Administrator.ToString());
            }
            else if((int)Role.Editor == int.Parse(input))
            {
                Console.WriteLine("Your role: " + Role.Editor.ToString());
            }

            Console.ReadKey();
        }
    }

}

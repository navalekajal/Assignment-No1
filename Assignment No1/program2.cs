using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No1
{
    internal class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(" Given Number is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine(" Given Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }

        }
    }
}

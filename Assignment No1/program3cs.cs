using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_No1
{
    internal class program3cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter is Character");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == '0' || ch == 'U')
            {
                Console.WriteLine("Character is Vowel");
            }

            else
            {
                Console.WriteLine("Character is Consonant");

            }

        }
    }
}
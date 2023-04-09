using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{   //using recursion
    public class Reverse_NO
    {
        public static int Reverse(int number, int reverse)  //recursive function reverse
        {
            if (number == 0)
            {
                return reverse;
            }
            else
            {
                int digit = number % 10;
                reverse = (reverse * 10) + digit;
                return Reverse(number / 10, reverse);
            }
        }

        static void Main(string[] args)
        {
            int number, reverse = 0;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            reverse = Reverse(number, reverse);

            Console.WriteLine("Reverse of {0} is {1}", number, reverse);
        }
    }
}

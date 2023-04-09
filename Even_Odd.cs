using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class Even_Odd
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an even number.", num);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", num);
            }
        }
    }
}

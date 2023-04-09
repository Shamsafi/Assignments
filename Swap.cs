using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class Swap
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number = {0}", num1);
            Console.WriteLine("Second number = {0}", num2);
        }
    }
}

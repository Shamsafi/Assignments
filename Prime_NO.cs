using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Prime_NO
    {
        static void Main(string[] args)
        {
            int limit;

            Console.Write("Enter the limit: ");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers up to {0}:", limit);

            for (int i = 2; i <= limit; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}

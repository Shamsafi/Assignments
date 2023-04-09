using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Perfect_NO
    {
        static void Main(string[] args)
        {
            int limit, sum;

            Console.Write("Enter the upper limit: ");
            limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect numbers:");

            for (int i = 1; i <= limit; i++)
            {
                sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }

                if (sum == i)
                    Console.Write("{0} ", i);
            }
        }
    }
}

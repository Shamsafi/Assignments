using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Coupon_NO
    {
        static void Main(string[] args)
        {
            int length = 10; // length of the coupon number
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // characters to use in the coupon number


            char[] coupon = new char[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                coupon[i] = chars[random.Next(chars.Length)];
            }

            string couponNumber = new string(coupon);

            Console.WriteLine("Coupon number: {0}", couponNumber);
        }

    }
}

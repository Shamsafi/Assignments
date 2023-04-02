namespace Leap_Year
{      //Leap_Year
    internal class Leap_Year_Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 4-digit year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);

            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }

            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
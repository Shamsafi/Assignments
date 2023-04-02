namespace testcase2
{      //Prime Factor
    internal class Prime_Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime factor of {0}:", n);

            for (int i=2; i<=n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine("{0}", i);
                    n /= i;
                }
            }
        }
    }
}
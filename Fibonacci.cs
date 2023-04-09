namespace Logical_Programs
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n, first = 0, second = 1, next;

            Console.Write("Enter the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write("{0} ", next);
            }
        }
    }

}
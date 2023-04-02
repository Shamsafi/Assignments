namespace Harmonic
{       //Nth Harmonic Number
    internal class Harmonic_Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer N: ");
            int N = int.Parse(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("N cannot be 0.");
                return;
            }

            double harmonic = 0;
            for (int i = 1; i <= N; i++)
            {
                harmonic += 1.0 / i;
            }

            Console.WriteLine($"The {N}th harmonic number is {harmonic}.");

        }
    }
}
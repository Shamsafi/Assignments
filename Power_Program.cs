namespace testcase
{          //Power of 2^N
    internal class Power_Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 1 || !int.TryParse(args[0], out int n))
            {
                Console.WriteLine("Please provide one integer argument N.");
                
            }

            for (int i = 7; i <= 20; i++)
            {
                Console.WriteLine($"2^{i} = {Math.Pow(2, i)}");
            }
        }
    }
}
namespace Flipping_a_Coin
{   //Flip a coin
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of times to flip the coin: ");
            int numFlips = int.Parse(Console.ReadLine());

            //int numFlips = 1000;
            int numHeads = 0;
            int numTails = 0;

            for (int i = 0; i < numFlips; i++)
            {
                Random rand = new Random();
                int flipResult = rand.Next(0, 2);

                if (flipResult == 0)
                {
                    numHeads++;
                }

                else
                {
                    numTails++;
                }
            }

            double percentHeads = (double)numHeads / numFlips * 100;
            double percentTails = (double)numTails / numFlips * 100;

            Console.WriteLine($"Heads: {percentHeads}%");
            Console.WriteLine($"Tails: {percentTails}%");
        }
    }
}
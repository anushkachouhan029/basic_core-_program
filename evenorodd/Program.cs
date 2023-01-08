class FlipCoin
{
    static void Main(String[] args)
    {
        double tails = 0;
        double heads = 0;
        int loopCount = 1;

        while (loopCount <= 10000)
        {
            Random random = new Random();
            double coinFlip = random.Next(0, 2);

            if (coinFlip < 0.5)
            {
                tails++;
            }
            else
            {
                heads++;
            }

            loopCount = loopCount + 1;
        }
        double percentTails = (tails / loopCount) * 100;
        double percentHeads = (heads / loopCount) * 100;

        Console.WriteLine("The percentage of heads is: " + percentHeads + " % ");
        Console.WriteLine("The percentage of tails is: " + percentTails + " % ");
        Console.ReadLine();
    }
}
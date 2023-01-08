class HarmonicNumber
{
    static void Main(String[] args)
    {
        float count;
        float sum = 0;

        Console.WriteLine("Enter the value of N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        for (count = 1; count <= N; count++)
        {
            Console.WriteLine("1/{0} + ", count);
            sum += 1 / count;
        }
        Console.WriteLine("Sum of series of {0} terms: {1}", N, sum);
        Console.ReadLine();
    }
}
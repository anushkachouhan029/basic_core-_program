class VowelOrConsonant
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter any Alphabet: ");
        char alphabet = Convert.ToChar(Console.ReadLine().ToLower());

        switch (alphabet)
        {
            case 'a':
                Console.WriteLine("Alphabet is Vowel");
                break;
            case 'e':
                Console.WriteLine("Alphabet is Vowel");
                break;
            case 'i':
                Console.WriteLine("Alphabet is Vowel");
                break;
            case 'o':
                Console.WriteLine("Alphabet is Vowel");
                break;
            case 'u':
                Console.WriteLine("Alphabet is Vowel");
                break;
            default:
                Console.WriteLine("Alphabet is Consonant");
                break;
        }
        Console.ReadLine();
    }
}
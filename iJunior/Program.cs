namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int baseNumber = 2;
        int degree = 0;
        int resultNumber = 1;
        Random random = new Random();
        int targetNumber = random.Next(0, 2_000_000_000);

        while (resultNumber < targetNumber)
        {
            degree += 1;
            resultNumber *= baseNumber;
        }

        Console.WriteLine($"Target number: {targetNumber}. ResultNumer: {resultNumber}. Degree: {degree} ");
    }
}

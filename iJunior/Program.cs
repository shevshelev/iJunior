namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int minNumber = 5;
        int maxNumber = 103;
        int stepNumber = 7;

        for (int currentNumber = minNumber; currentNumber <= maxNumber; currentNumber += stepNumber) {
            Console.WriteLine(currentNumber);
        }
    }
}

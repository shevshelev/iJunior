namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int imagesInRow = 3;
        int numbersOfImages = 52;

        Console.WriteLine($"Количество рядов по 3 картины: {numbersOfImages / imagesInRow} \nКартин сверх меры: {numbersOfImages % imagesInRow}");
    }
}


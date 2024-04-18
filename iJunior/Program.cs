namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое значение");
        string firstValue = Console.ReadLine();

        Console.WriteLine("Введите второе значение");
        string secondValue = Console.ReadLine();

        Console.WriteLine($"Вы ввели: {firstValue} и {secondValue}");

        string var = firstValue;
        firstValue = secondValue;
        secondValue = var;

        Console.WriteLine($"Мы пометяли: {firstValue} и {secondValue}");
    }
}


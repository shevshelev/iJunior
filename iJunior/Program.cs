namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string message;

        Console.WriteLine("Введите сообщение");

        message = Console.ReadLine();

        Console.WriteLine("Введите количество повторений");

        for (int repeatCounter = Convert.ToInt32(Console.ReadLine()), repeatCounter > 0, repeatCounter--) {
            Console.WriteLine(message);
        }
    }
}

namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int repeatCounter;
        string message;

        Console.WriteLine("Введите сообщение");

        message = Console.ReadLine();

        Console.WriteLine("Введите количество повторений");

        repeatCounter = Convert.ToInt32(Console.ReadLine());

        while (repeatCounter -- > 0) {
            Console.WriteLine(message);
        }
    }
}

namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string message;
        int repeatCounter;

        Console.WriteLine("Введите сообщение");

        message = Console.ReadLine();

        Console.WriteLine("Введите количество повторений");

        repeatCounter = Convert.ToInt32(Console.ReadLine());

        for (int i = repeatCounter; i > 0; i--) {
            Console.WriteLine(message);
        }
    }
}

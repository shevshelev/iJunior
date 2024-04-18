namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int minutesInHour = 60; 
        int timePerPatient = 10;

        Console.WriteLine("Введите количество пациентов перед вами:");
        int totalTime = Convert.ToUInt16(Console.ReadLine()) * timePerPatient;

        int numberOfHour = totalTime / minutesInHour;
        int remainingMinutes = totalTime % minutesInHour;

        Console.WriteLine($"Вам осталось ждать {numberOfHour} часов и {remainingMinutes} минут");
    }
}

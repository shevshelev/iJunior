namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string planet;
        string age;

        Console.WriteLine("Имя введи своё");
        name = Console.ReadLine();
        Console.WriteLine("Планеты ты с какой?");
        planet = Console.ReadLine();
        Console.WriteLine("Возраста каого ты?");
        age = Console.ReadLine();

        Console.WriteLine($"Поздравляю {name}, {age} лет от роду, с планеты {planet} тебя, джедай ты!");
    }
}


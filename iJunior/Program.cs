namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string name;
        char symbol;
        string outerLine;

        Console.WriteLine("Please enter name");

        name = Console.ReadLine();

        Console.WriteLine("Please enter symbol");

        symbol = Console.ReadKey(true).KeyChar;
        outerLine = Convert.ToString(symbol);

        for (int i = 0; i <= name.Length; i++) {
            outerLine += symbol;
        }

        Console.WriteLine(outerLine);
        Console.WriteLine($"{symbol}{name}{symbol}");
        Console.WriteLine(outerLine);
    }
}

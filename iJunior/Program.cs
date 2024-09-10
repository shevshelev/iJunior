namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string symbol;
        int totalSymbolsInString;

        string outerLine = String.Empty;
        int nuberOfAdditionSymbols = 2;

        Console.WriteLine("Please enter name");

        name = Console.ReadLine();

        Console.WriteLine("Please enter symbol");

        symbol = Console.ReadLine();

        totalSymbolsInString = name.Length + nuberOfAdditionSymbols;
        for (int i = 1; i <= totalSymbolsInString; i++) {
            outerLine += symbol;
        }

        Console.WriteLine(outerLine);
        Console.WriteLine($"{symbol}{name}{symbol}");
        Console.WriteLine(outerLine);
    }
}

namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int goldPrice = 10;

        Console.WriteLine("Сколько у вас золота?");
        int numbersOfGold = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine($"Один кристалл стоит {goldPrice} золота, сколько хотите купить?");
        int numbersOfCristall = Convert.ToUInt16(Console.ReadLine());

        int orderPrice = numbersOfCristall * goldPrice;
        int canBuy = Convert.ToUInt16(numbersOfGold >= orderPrice);

        Console.WriteLine($"Вы купили {canBuy * numbersOfCristall} кристаллов и у вас осталось {numbersOfGold % orderPrice} золота");
    }
}


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
        int purchasedСrystals = Convert.ToUInt16(numbersOfGold >= orderPrice) * numbersOfCristall;
        int remainingGold = numbersOfGold % orderPrice;

        Console.WriteLine($"Вы купили {purchasedСrystals} кристаллов и у вас осталось {remainingGold} золота");
    }
}


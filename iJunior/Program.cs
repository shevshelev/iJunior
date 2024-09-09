namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int minimum = 0;
        int maximum = 100;
        int firstDivider = 3;
        int secondDivider = 5;
        int number = random.Next(minimum, maximum);
        int sum = 0;

        for (int i = 0; i <= number; i++) {
            if (i % firstDivider == 0 || i % secondDivider == 0) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}

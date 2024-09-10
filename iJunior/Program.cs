namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        
        int minNumber = 10;
        int maxNumber = 25;
        int minLimit = 50;
        int maxLimit = 150;
        int counter = 0;
        string greetingMessage = $"Please enter a number between 10 and 25.";
        string errorMessage = "The entered value is incorrect";

        Console.WriteLine(greetingMessage);

        userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput >= minNumber && userInput <=  maxNumber)
        {
            for (int i = 0; i <= maxLimit; i += userInput)
            {
                if (i >= minLimit)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Answer: {counter}");
        }
        else
        {
            Console.WriteLine(errorMessage);
        }
    }
}

namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        const string CommandShowGreeting = "1";
        const string CommandShowGoodbay = "2";
        const string CommandShowRandomNumber = "3";
        const string CommandClean = "4";
        const string CommandExit = "5";

        const string commandsText = "Available commands:";
        const string greetingText = "Show greeting";
        const string goodbayText = "Show goodbay";
        const string randomNumberText = "Show random number";
        const string cleanText = "Clean console";
        const string exitTextCommand = "Exit";
        const string enterCommand = "Enter command number:";

        const string greeting = "Hi There!!!";
        const string goodbay = "Goodbay!";
        const string exitText = "Program completed";
        const string unknownCommand = "Unknown comand";
        const int minLimitForRandomNumber = 0;
        const int maxLimitForRandomNumber = 1000;

        Random random= new Random();
        bool isWork = true;
        string userInput;

        while (isWork) {
            Console.WriteLine(commandsText);
            Console.WriteLine($"{CommandShowGreeting}. {greetingText}");
            Console.WriteLine($"{CommandShowGoodbay}. {goodbayText}");
            Console.WriteLine($"{CommandShowRandomNumber}. {randomNumberText}");
            Console.WriteLine($"{CommandClean}. {cleanText}");
            Console.WriteLine($"{CommandExit}. {exitTextCommand}");
            Console.WriteLine(enterCommand);

            userInput = Console.ReadLine();

            switch (userInput) {
                case CommandShowGreeting:
                    Console.WriteLine(greeting);
                    break;
                case CommandShowGoodbay:
                    Console.WriteLine(goodbay);
                    break;
                case CommandShowRandomNumber:
                    int number = random.Next(minLimitForRandomNumber, maxLimitForRandomNumber);
                    Console.WriteLine(number);
                    break;
                case CommandClean:
                    Console.Clear();
                    break;
                case CommandExit:
                    isWork = false;
                    Console.WriteLine(exitText);
                    break;
                default:
                    Console.WriteLine(unknownCommand);
                    break;
            }
        }

        Console.ReadKey();
    }
}

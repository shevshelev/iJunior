namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        const string CommandConvertRUBToUSD = "1";
        const string CommandConvertUSDToRUB = "2";
        const string CommandConvertRUBToEUR = "3";
        const string CommandConvertEURToRUB = "4";
        const string CommandConvertUSDToEUR = "5";
        const string CommandConvertEURToUSD = "6";
        const string CommandExit = "7";

        string greeting = "Hellol, you have:";
        string availableExchange = "\nAvailable exchanges:";
        string enterExchange = "Please enter exchange command.";
        string RUBText = "RUB";
        string USDText = "USD";
        string EURText = "EUR";
        string RUBToUSDText = $"Convert {RUBText} to {USDText}";
        string USDToRUBText = $"Convert {USDText} to {RUBText}";
        string RUBToEURText = $"Convert {RUBText} to {EURText}";
        string EURToRUBText = $"Convert {EURText} to {RUBText}";
        string USDToEURText = $"Convert {USDText} to {EURText}";
        string EURToUSDText = $"Convert {EURText} to {USDText}";
        string RUBExchangeText = $"How many {RUBText} do you want exchange?";
        string USDExchangeText = $"How many {USDText} do you want exchange?";
        string EURExchangeText = $"How many {EURText} do you want exchange?";
        string exitText = "Exit";
        string completed = "Operation completed.";
        string error = "The specified amount exceeds amount in account.";
        string anyKey = "Please press any key.";
        string programCompleted = "Program completed";
        string unknownCommand = "Unknown command";

        double USDAccount = 123;
        double RUBAccount = 100_000;
        double EURAccount = 6_000_000;

        double USDToRUBRate = 100;
        double EURToRUBRate = 120;
        double EURToUSDRate = EURToRUBRate / USDToRUBRate;
        double RUBToUSDRate = 1 / USDToRUBRate;
        double RUBToEURRate = 1 / EURToRUBRate;
        double USDToEURRate = 1 /EURToUSDRate ;

        bool isWork = true;

        string userInput;

        while (isWork) {
            double desiredAmount;

            Console.WriteLine(greeting);
            Console.WriteLine($"{USDAccount} {USDText}");
            Console.WriteLine($"{RUBAccount} {RUBText}");
            Console.WriteLine($"{EURAccount} {EURText}");
            Console.WriteLine(availableExchange);
            Console.WriteLine($"{CommandConvertRUBToUSD}. {RUBToUSDText}");
            Console.WriteLine($"{CommandConvertUSDToRUB}. {USDToRUBText}");
            Console.WriteLine($"{CommandConvertRUBToEUR}. {RUBToEURText}");
            Console.WriteLine($"{CommandConvertEURToRUB}. {EURToRUBText}");
            Console.WriteLine($"{CommandConvertUSDToEUR}. {USDToEURText}");
            Console.WriteLine($"{CommandConvertEURToUSD}. {EURToUSDText}");
            Console.WriteLine($"{CommandExit}. {exitText}");
            Console.Write(enterExchange);

            userInput = Console.ReadLine();

            switch (userInput) {
                case CommandConvertRUBToUSD:
                    Console.WriteLine(RUBExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (RUBAccount >= desiredAmount) {
                        RUBAccount -= desiredAmount;
                        USDAccount += desiredAmount * RUBToUSDRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandConvertUSDToRUB:
                    Console.WriteLine(USDExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (USDAccount >= desiredAmount) {
                        USDAccount -= desiredAmount;
                        RUBAccount += desiredAmount * USDToRUBRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandConvertRUBToEUR:
                    Console.WriteLine(RUBExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (RUBAccount >= desiredAmount) {
                        RUBAccount -= desiredAmount;
                        EURAccount += desiredAmount * RUBToEURRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandConvertEURToRUB:
                    Console.WriteLine(EURExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (EURAccount >= desiredAmount) {
                        EURAccount -= desiredAmount;
                        RUBAccount += desiredAmount * EURToRUBRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandConvertUSDToEUR:
                    Console.WriteLine(USDExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (USDAccount >= desiredAmount) {
                        USDAccount -= desiredAmount;
                        EURAccount += desiredAmount * USDToEURRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandConvertEURToUSD:
                    Console.WriteLine(EURExchangeText);

                    desiredAmount = Convert.ToDouble(Console.ReadLine());

                    if (EURAccount >= desiredAmount) {
                        EURAccount -= desiredAmount;
                        USDAccount += desiredAmount * EURToUSDRate;

                        Console.WriteLine(completed);
                        Console.WriteLine(anyKey);
                        Console.ReadKey();
                    } else {
                        Console.WriteLine(error);
                    }

                    break;

                case CommandExit:
                    isWork = false;
                    Console.WriteLine(programCompleted);
                    break;
                default:
                    Console.WriteLine(unknownCommand);
                    break;
            }
        }


        
    }
}

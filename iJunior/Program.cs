namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        
        int attemptsNumber = 3;
        string passsword = "SomePassword";
        string secretMessage = "You are amazing!";
        string greetingMessage = "Please enter password";
        string incorrectMessage = "Password is incorrect. Please try again.";

        for (int currentAttempt = 1; currentAttempt <= attemptsNumber; currentAttempt++)
        {
            Console.WriteLine(greetingMessage);

            userInput = Console.ReadLine();

            if (userInput == passsword)
            {
                Console.WriteLine(secretMessage);
                break;
            } 
            else 
            {
                Console.WriteLine(incorrectMessage);
                Console.WriteLine($"You have {attemptsNumber - currentAttempt} attempts left.");
                continue;
            }
        }
    }
}

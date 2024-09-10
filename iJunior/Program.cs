namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int attemptsNumber = 3;
        int currentAttempt = 0;
        string passsword = "SomePassword";
        string secretMessage = "You are amazing!";
        string greetingMessage = "Please enter password";
        string incorrectMessage = "Password is incorrect. Please try again.";

        while (currentAttempt < attemptsNumber)
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
                currentAttempt += 1;
                Console.WriteLine(incorrectMessage);
                Console.WriteLine($"You have {attemptsNumber - currentAttempt} attempts left.");
                continue;
            }
        }
    }
}

namespace iJunior;

class Program
{
    static void Main(string[] args)
    {
        string message = "";
        string exitMessage = "exit";

        while (message !=  exitMessage) {
            Console.WriteLine("Для выхода введие \"exit\" ");
            
            message = Console.ReadLine();
        }
    }
}

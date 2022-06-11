
namespace ValidateChecker.Messages
{
    public static class Info
    {
        public static void Print(string who, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(who + ": ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(message);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

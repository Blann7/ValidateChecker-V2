namespace ValidateChecker.Messages
{
    public static class Error
    {
        public static void Print(string who, string err_message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(who + ": ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(err_message);

            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

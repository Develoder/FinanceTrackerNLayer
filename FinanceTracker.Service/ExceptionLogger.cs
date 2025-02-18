namespace FinanceTracker.Service;

public static class ExceptionLogger
{
    public static void Log(Exception e)
    {
        Console.WriteLine($"Ошибка: {e.Message}");
    }
}
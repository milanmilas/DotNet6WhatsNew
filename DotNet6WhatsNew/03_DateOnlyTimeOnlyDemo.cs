namespace DotNet6WhatsNew;

internal static class DateOnlyTimeOnlyDemo
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 DateOnlyTimeOnlyDemo 8<---");

        DateOnly minDate = DateOnly.MinValue;
        Console.WriteLine($"min date {minDate}");

        Console.WriteLine($"current date {DateOnly.FromDateTime(DateTime.Now)}");
        Console.WriteLine($"current time {TimeOnly.FromDateTime(DateTime.Now)}");
    }
}


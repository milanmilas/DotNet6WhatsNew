namespace DotNet6WhatsNew;

internal static class LINQRangesSupportDemo
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 LINQRangesSupportDemo 8<---");

        var items = Enumerable.Range(0, 15);

        Console.WriteLine("0, 1, 2 ... 13, 14");

        // TakeLast(5)
        Console.WriteLine($"items.Take(^5..): {string.Join(' ', items.Take(^5..))}"); // 10 11 12 13 14

        // Take(5).Skip(2)
        Console.WriteLine($"items.Take(2..5): {string.Join(' ', items.Take(2..5))}"); // 2 3 4

        // SkipLast(5)
        Console.WriteLine($"items.Take(..^5): {string.Join(' ', items.Take(..^5))}"); // 0 1 2 3 4 5 6 7 8 9

        // TakeLast(10).SkipLast(5)
        Console.WriteLine($"items.Take(^10..^5): {string.Join(' ', items.Take(^10..^5))}"); // 5 6 7 8 9
    }
}

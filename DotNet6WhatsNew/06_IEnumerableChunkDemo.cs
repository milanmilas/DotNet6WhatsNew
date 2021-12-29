namespace DotNet6WhatsNew;

internal static class IEnumerableChunkDemo
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 IEnumerableChunkDemo 8<---");

        var items = Enumerable.Range(0, 100);

        foreach (var chunk in items.Chunk(10))
        {
            Console.WriteLine($"Chunk with items: '{string.Join(' ', chunk)}'");
        }
    }
}

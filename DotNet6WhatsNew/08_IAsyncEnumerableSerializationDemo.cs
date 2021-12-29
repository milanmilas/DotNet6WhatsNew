
using System.Text.Json;

namespace DotNet6WhatsNew;

internal static class IAsyncEnumerableSerializationDemo
{
    public static async Task Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 IAsyncEnumerableSerializationDemo 8<---");

        async IAsyncEnumerable<int> GetNumbersAsync(int n)
        {
            for (int i = 0; i < n; i++) yield return i;
        }

        using Stream stream = Console.OpenStandardOutput();
        var data = new { Data = GetNumbersAsync(10) };
        await JsonSerializer.SerializeAsync(stream, data);
    }
}

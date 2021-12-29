namespace DotNet6WhatsNew;

public static class PriorityQueueDemo
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 PriorityQueueDemo 8<---");

        // Comparation could run when Enqueue and when Enqueue ...
        var queue = new PriorityQueue<object, int>();
        queue.Enqueue("first", 2);
        queue.Enqueue("second", 1);
        queue.Enqueue("3rd", 10);

        var element = queue.Dequeue();
        Console.WriteLine($"dequeue top priority element '{element}'");
        // "second"

        var queue2 =
            new PriorityQueue<string, string>(
                Comparer<string>.Create(
                    (x, y) => x.Length > y.Length ? 1 : -1)); // -1 higher
        queue2.Enqueue("first", "first");
        queue2.Enqueue("second", "second");
        queue2.Enqueue("3rd", "3rd");

        element = queue2.Dequeue();
        Console.WriteLine($"dequeue2 top priority element '{element}'");
        // "3rd"
    }
}

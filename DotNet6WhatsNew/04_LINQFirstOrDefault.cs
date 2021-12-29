namespace DotNet6WhatsNew
{
    internal static class LINQFirstOrDefault
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("--->8 LINQFirstOrDefault 8<---");

            var values = new List<int?> { 1, 2, 3, 4, 5 };
            var searchValue = 100;

            var result = values.FirstOrDefault(x => x == searchValue, -1);

            Console.WriteLine($"Missing value found as '{result}'");
            // -1
        }
    }
}

namespace DotNet6WhatsNew;

internal static class LINQMaxByMinBy
{
    record Person(string Name, int Age);

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 LINQMaxByMinBy 8<---");

        List<Person> people = new List<Person> {
            new Person("Young Boy", 20),
            new Person("Old Man", 30)
        };

        Console.Write(people.MaxBy(x => x.Age));
        // Person { Name = Old Man, Age = 30 }
    }

}


namespace DotNet6WhatsNew;

internal static class LINQDistinctByDemo
{
    record Person(string Name, int Age);

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 LINQDistinctByDemo 8<---");

        List<Person> people = new List<Person> {
            new Person("Young Boy", 20),
            new Person("Old Man", 30),
            new Person("Older Man", 40),
            new Person("Oldest Man", 40),
            new Person("Young Boy", 30)
        };

        Console.WriteLine("All");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("DistinctBy Age");
        foreach (var person in people.DistinctBy(x => x.Age))
        {
            Console.WriteLine(person);
        }
        // Person { Name = Young Boy, Age = 20 }
        // Person { Name = Old Man, Age = 30 }
        // Person { Name = Older Man, Age = 40
        
        Console.WriteLine("DistinctBy Name");
        foreach (var person in people.DistinctBy(x => x.Name))
        {
            Console.WriteLine(person);
        }
        // Person { Name = Young Boy, Age = 20 }
        // Person { Name = Old Man, Age = 30 }
        // Person { Name = Older Man, Age = 40 }
        // Person { Name = Oldest Man, Age = 40 }
    }
}


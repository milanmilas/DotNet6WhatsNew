
namespace DotNet6WhatsNew;

internal class ExtendedPropertyPatternDemo
{
    class Person
    {
        public string FirstName { get; set; } = "Jack";
        public string LastName { get; set; } = "Straw";
        public Address HomeAddress { get; set; } = new Address();
    }

    class Address
    {
        public string City { get; set; } = "Dallas";
        public string State { get; set; } = "TX";

    }

    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 ExtendedPropertyPatternDemo 8<---");
        
        var person = new Person();

        if(person is { FirstName: "Jack", HomeAddress.City: "Dallas" })
        {
            Console.WriteLine($"Pattern matching works for property  HomeAddress.City: 'Dallas'");
        }

    }
}


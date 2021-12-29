using System;

namespace DotNet6WhatsNew;

internal class ArgumentNullExceptioniDemo
{
    public static void Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 ArgumentNullExceptioniDemo 8<---");
        
        try
        {
            ArgumentNullException.ThrowIfNull(null);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);            
        }
    }
}


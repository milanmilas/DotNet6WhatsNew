using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6WhatsNew;

internal class WaitAsyncDemo
{
    public static async Task Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 WaitAsyncDemo 8<---");

        var cancellationToken = new CancellationToken();
        var timeout = TimeSpan.FromSeconds(2);

        // new method for Task
        try
        {
            await Task.Run(() => Task.Delay(10000)).WaitAsync(timeout, cancellationToken);
        }
        catch (TimeoutException)
        {

            Console.WriteLine("TimeOut Exception");
        }
        
    }
}


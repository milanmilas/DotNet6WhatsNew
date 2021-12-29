namespace DotNet6WhatsNew;

internal static class PeriodicTimerDemo
{
    public static async Task Run()
    {
        Console.WriteLine();
        Console.WriteLine("--->8 PeriodicTimerDemo 8<---");

        // .Net 5
        //System.Threading.Timer
        //System.Timers.Timer
        //System.Windows.Forms.Timer
        //System.Web.UI.Timer
        //System.Windows.Threading.DispatcherTimer

        // Timer that will fire repeatedly, for fire once Task can be used Task.Delay
        // Timer will be paused and user code will be executing
        // Can be stopped with CancellationToken
        // Excecution context is not captured

        using var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(200));
        var counter = 1;
        while (counter < 5 && await timer.WaitForNextTickAsync())
        {
            Console.WriteLine($"Tick {counter++}");
        }
    }
}


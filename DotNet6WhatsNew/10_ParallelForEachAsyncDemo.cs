using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6WhatsNew
{
    internal static class ParallelForEachAsyncDemo
    {
        public static async Task Run()
        {
            Console.WriteLine();
            Console.WriteLine("--->8 ParallelForEachAsyncDemo 8<---");

            IEnumerable<int> GetNumbers(int n)
            {
                for (int i = 0; i < n; i++) yield return i;
            }

            //var semaphore = new SemaphoreSlim(2);
            //var tasks = GetNumbers(5)
            //    .Select(async message =>
            //    {
            //        await semaphore.WaitAsync();

            //        try
            //        {
            //            await Task.Delay(1000);
            //            Console.WriteLine(message);
            //        }
            //        finally
            //        {
            //            semaphore.Release();
            //        }
            //    });

            //await Task.WhenAll(tasks);

            var parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 2
            };

            await Parallel.ForEachAsync(GetNumbers(5),
                parallelOptions,
                async (message, cancellationToken) =>
                {
                    await Task.Delay(200);
                    Console.WriteLine(message);
                });
        }
    }
}

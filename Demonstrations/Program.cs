using System;
using System.Threading.Tasks;
using Singleton;

namespace Demonstrations
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            SingletonExample();
        }

        private static void SingletonExample()
        {
            const int amount = 10;
            var tasks = new Task[amount];
            for (var i = 0; i < amount; i++)
            {
                tasks[i] = Task.Run(Cache.CreateMemoryCache);
            }

            Task.WaitAll(tasks);
            
            // Single thread
            // Cache.CreateMemoryCache();
            // // Multi thread
            // MultiThreadedCache.CreateMemoryCache();
        }
    }
}
using System;

namespace Singleton
{
    public class Cache
    {
        private static int _index = 0;
        private static Cache _instance;

        private Cache()
        {
            Console.WriteLine($"Singleton created - single thread {_index++}");
        }

        public static Cache CreateMemoryCache() => _instance ??= new Cache();
    }
}

// This example is single threaded processes 
// Cache.CreateMemoryCache()

using System;

namespace Singleton
{
    public class MultiThreadedCache
    {
        private static int _index = 0;
        private static MultiThreadedCache _instance;
        
        static MultiThreadedCache()
        {
            _instance = new MultiThreadedCache();
        }
         
        private MultiThreadedCache()
        {
            Console.WriteLine($"Multi Threaded Cache created {_index++}");
        }
        public static MultiThreadedCache CreateMemoryCache() => _instance;

    }
}
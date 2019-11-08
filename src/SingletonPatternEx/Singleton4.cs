using System;

namespace SingletonPatternEx
{
    //not quite as lazy, but thread-safe without using locks
    public sealed class Singleton4
    {
        private static readonly Singleton4 instance = new Singleton4();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton4() { }

        private Singleton4() { }

        public static Singleton4 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

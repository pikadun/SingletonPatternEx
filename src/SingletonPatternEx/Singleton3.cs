using System;

namespace SingletonPatternEx
{
    // attempted thread-safety using double-check locking
    public sealed class Singleton3
    {
        private static Singleton3 instance = null;
        private static readonly object padlock = new object();

        Singleton3() { }

        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

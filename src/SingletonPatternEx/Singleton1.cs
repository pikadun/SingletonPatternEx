using System;

namespace SingletonPatternEx
{
    // not thread-safe
    public sealed class Singleton1
    {
        private static Singleton1 instance = null;

        private Singleton1() { }

        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
        // 另一种写法
        // public static Singleton1 Instance { get; set; } = new Singleton1();
    }
}

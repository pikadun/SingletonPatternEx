using System;
using System.Collections.Generic;
using SingletonPatternEx;
using System.Threading.Tasks;


namespace Test
{
    static class Test5
    {
        public static void Run()
        {
            var tasks = new List<Task>();
            // var objs = new List<Object>();

            for (var i = 0; i < 10; i++)
            {
                void action()
                {
                    var singleton = Singleton5.Instance;
                    Console.WriteLine($"Hash code is:{singleton.GetHashCode()}");
                    // objs.Add(singleton);
                }

                tasks.Add(Task.Run(action));
            }

            Task.WaitAll(tasks.ToArray());

            // for (var i = 1; i < objs.Count; i++)
            // {
            //     if (!objs[i].Equals(objs[i - 1]))
            //     {
            //         Console.WriteLine($"第{i - 1}个元素与第{i}个元素不是同一个实例");
            //     }
            // }
        }
    }
}
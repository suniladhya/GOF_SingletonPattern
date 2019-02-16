using SimpleSingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadSafeSingletonPattern;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSingletonPattern.Singleton obj1 = Singleton.Instance;
            SimpleSingletonPattern.Singleton obj2 = Singleton.Instance;

            if (obj1 == obj2)
            {
                Console.WriteLine("SingleTon Successful");
            }

            ThreadSafeSingletonPattern.ThreadSafeSingleton obj3 = ThreadSafeSingleton.Instance;
            ThreadSafeSingletonPattern.ThreadSafeSingleton obj4 = ThreadSafeSingleton.Instance;

            if (obj3 == obj4)
            {
                Console.WriteLine("SingleTon Successful");
            }
        }
    }
}

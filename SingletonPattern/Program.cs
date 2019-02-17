using Lazy_Singleton_;
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
            Singleton obj1 = Singleton.Instance;
            Singleton obj2 = Singleton.Instance;

            if (obj1 == obj2)
            {
                Console.WriteLine("SingleTon Successful");
            }

            ThreadSafeSingleton obj3 = ThreadSafeSingleton.Instance;
            ThreadSafeSingleton obj4 = ThreadSafeSingleton.Instance;

            if (obj3 == obj4)
            {
                Console.WriteLine("SingleTon Successful");
            }
            LazySingleton obj5 = LazySingleton.Instance;
            LazySingleton obj6 = LazySingleton.Instance;

            if (obj5 == obj6)
            {
                Console.WriteLine("SingleTon Successful");
            }
        }
    }
}

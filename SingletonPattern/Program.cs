using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleSingletonPattern.Singleton obj1 = SimpleSingletonPattern.Singleton.Instance;
            SimpleSingletonPattern.Singleton obj2 = SimpleSingletonPattern.Singleton.Instance;

            if (obj1 == obj2)
            {
                Console.WriteLine("SingleTon Successful");
            }

        }
    }
}

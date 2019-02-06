using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class SingletonLazyLoading
    {
        private static SingletonLazyLoading instance = null;

        private SingletonLazyLoading()
        {
        }

        public static SingletonLazyLoading Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonLazyLoading();
                }
                return instance;
            }
        }
    }
}

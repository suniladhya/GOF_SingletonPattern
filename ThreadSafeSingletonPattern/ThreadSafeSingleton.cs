using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingletonPattern
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static readonly object padlock = new object();

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}

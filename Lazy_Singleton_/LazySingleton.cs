using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Singleton_
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazy =
            new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance { get { return lazy.Value; } }

        private LazySingleton()
        {
        }
    }
}

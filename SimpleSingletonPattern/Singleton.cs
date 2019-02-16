using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSingletonPattern
{
    //Default Eager Loading
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();
        //why static?
        //If not static, than the public"Instance" can't return "instance".
        //As a static method can not instance variable, without instantiating the instance of the class

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
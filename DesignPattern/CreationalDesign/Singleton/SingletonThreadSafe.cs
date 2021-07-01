using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonThreadSafe
    {
        SingletonThreadSafe() { }
        private static readonly object lockThread = new object ();  
        private static SingletonThreadSafe instance = null;
        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (lockThread)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                    }
                    return instance;
                }
            }
        }
    }
}

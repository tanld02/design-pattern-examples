using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonNoThreadSafe
    {
        private SingletonNoThreadSafe() { }
        private static SingletonNoThreadSafe instance = null;
        public static SingletonNoThreadSafe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonNoThreadSafe();
                }
                return instance;
            }
        }
    }
}

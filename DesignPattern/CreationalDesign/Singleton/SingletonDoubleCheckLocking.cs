using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonDoubleCheckLocking
    {
        SingletonDoubleCheckLocking() { }
        private static readonly object lockObject = new object ();  
        private static SingletonDoubleCheckLocking instance = null;
        public static SingletonDoubleCheckLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                        {
                            if (instance == null)
                            {
                                instance = new SingletonDoubleCheckLocking();
                            }
                        }
                }
                return instance;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatterns
{
    class SingletonDoubleLock
    {
        private static SingletonDoubleLock instance = new SingletonDoubleLock();

        private SingletonDoubleLock() { }

        private static object lockThis = new object();

        public static SingletonDoubleLock getInstance()
        {
             
            lock (lockThis){
            if (instance == null)
                {
                    instance = new SingletonDoubleLock();
                }
                return instance;
            }
        }
    }
}

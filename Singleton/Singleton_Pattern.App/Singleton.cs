using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.App
{
    public sealed class Singleton
    {
        //private static readonly Singleton uniqeInstanceSingleton = new Singleton();
        //private static Singleton uniqeInstanceSingleton;
        private static readonly Lazy<Singleton> uniqeInstanceSingleton = new Lazy<Singleton>();
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            //if (uniqeInstanceSingleton is null)
            //{
            //    uniqeInstanceSingleton = new Singleton();
            //}
            //return uniqeInstanceSingleton;
            return uniqeInstanceSingleton.Value;
        }
    }
}

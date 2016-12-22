using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternSingleClassExample
{
    public class SynchronizedSingletonClass
    {
        private static SynchronizedSingletonClass UniqueInstance { get; set; }
        private SynchronizedSingletonClass()
        {

        }

        [MethodImpl(MethodImplOptions.Synchronized)] //This is the equivalent of synchronized in C#, you can use lock too!
        //http://stackoverflow.com/questions/541194/c-sharp-version-of-javas-synchronized-keyword
        public static  SynchronizedSingletonClass GetInstance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new SynchronizedSingletonClass();
            }
            return UniqueInstance;
        }
        //This ensures that GetInstance is being accessed by only 1 thread at a time
        //However, using synchronized is expensive! Can decrease performance by factor of 100
        //Synchronized is truly only needed when the object is actually null, ie - the first time, after that it is not needed and is unncessary overhead.
    }

    //Other alternatives listed below
    public class SynchronizedSingletonClass1
    {
        private static SynchronizedSingletonClass1 UniqueInstance = new SynchronizedSingletonClass1();
        private SynchronizedSingletonClass1()
        {

        }
        
        public static SynchronizedSingletonClass1 GetInstance()
        {
            return UniqueInstance;
        }
       
    }
}

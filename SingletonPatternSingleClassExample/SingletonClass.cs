using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternSingleClassExample
{
    public class SingletonClass
    {
        private static SingletonClass UniqueInstance { get; set; }
        private SingletonClass()
        {

        }

        public static SingletonClass GetInstance()
        {
           if(UniqueInstance ==null)
            {
                UniqueInstance = new SingletonClass();
            }
            return UniqueInstance;
        }
    }
}

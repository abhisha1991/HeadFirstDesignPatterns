using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternSingleClassExample
{
    public class ChocolateBoiler
    {
        private bool Empty { get; set; }
        private bool Boiled { get; set; }
        private static ChocolateBoiler UniqueBoiler { get; set; }
        public static ChocolateBoiler GetUniqueBoiler()
        {
            if(UniqueBoiler == null) //Imagine 2 threads that are trying to get a single unique instance of UniqueBoiler, both may check for this condition at nearly the same time in which case they both make a new Chocolate boiler object, that could cause a problem when calling the other methods - FILL, BOIL, DRAIN etc.
            {
                UniqueBoiler = new ChocolateBoiler();
            }
            return UniqueBoiler;
        }
        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }
        public void Fill()
        {
            if(Empty)
            {
                Empty = false;
                Boiled = false;
                Console.WriteLine("Empty container, Starting to fill...");
                return;
            }
            if(!Empty)
            {
                Console.WriteLine("Full container, cannot fill anything!");
            }
            
        }
        public void Drain()
        {
            if(Empty == false)
            {
                Console.WriteLine("Container is full, Starting to drain...");
                Empty = true;
                Boiled = false;
                return;
            }
            if (Empty == false && Boiled == true)
            {
                Console.WriteLine("Container is full and boiled, Starting to drain...");
                Empty = true;
                Boiled = false;
                return;
            }
            if(Empty ==true)
            {
                Console.WriteLine("Empty container, cannot drain anything!");
            }
            
        }
        public void Boil()
        {
            if(Empty == true)
            {
                Console.WriteLine("Empty container, cannot boil anything!");
                return;
            }
            if(Boiled == true)
            {
                Console.WriteLine("Hot container, cannot boil more!");
                return;
            }
            if(Empty == false && Boiled == false)
            {
                Console.WriteLine("Container is full, Starting to boil...");
                Boiled = true;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHomeTheaterExample.PrincipleOfLeastKnowledge
{
    /// <summary>
    /// Read page 278 of head first design patterns
    /// </summary>
    public class Car
    {
        /*
         * The principle provides some guidelines: take any object; now from any method in that object, the principle tells us that we should only invoke methods that belong to:
            1. The object itself
            2. Objects passed in as a parameter to the method
            3. Any object the method creates or instantiates
            4. Any components of the object
         */

        Engine engine;
        // other instance variables
        public Car()
        {
            // initialize engine, etc.
        }
        public void Start(Key key)
        {
            Doors doors = new Doors();
            bool authorized = key.Turns(); //Uses point number 2 - this method belongs to Key which is a parameter in this function
            if (authorized)
            {
                engine.EngineMethod(); //Uses point number 4 - engine is a component of the car (data member)
                UpdateDashboardDisplay(); //Uses point number 1 - this method belongs to the car object itself
                doors.Lock(); //Uses point number 3 - the Start() method creates the doors object and then uses some function of the doors class.
            }
        }
        public void UpdateDashboardDisplay()
        {
            // update display
        }
    }
}
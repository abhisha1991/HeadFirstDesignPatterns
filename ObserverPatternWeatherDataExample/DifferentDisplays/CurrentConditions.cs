using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public class CurrentConditions : InterfaceDisplay, InterfaceObserver
    {
        private float Temp { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private InterfaceSubject Subject { get; set; }
        public CurrentConditions(InterfaceSubject WeatherDataSubject)
        {
            this.Subject = WeatherDataSubject; 
            //'Subject' is being used because if we were to delete this observer from the subject laster on, we would know what source to de-subscribe from!
            WeatherDataSubject.RegisterObserver(this);

        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Display CurrentConditions!");
            Console.WriteLine(Temp);
            Console.WriteLine(Humidity);
            Console.WriteLine(Pressure);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
            Console.WriteLine("Update for CurrentConditions reached");
            Display();
            
        }
    }
}

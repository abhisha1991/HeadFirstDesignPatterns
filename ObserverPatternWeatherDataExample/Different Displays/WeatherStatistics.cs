using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public class WeatherStatistics : InterfaceDisplay, InterfaceObserver
    {
        private float Temp { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private InterfaceSubject Subject { get; set; }
        public WeatherStatistics(InterfaceSubject WeatherDataSubject)
        {
            this.Subject = WeatherDataSubject;
            WeatherDataSubject.RegisterObserver(this);

        }

        public void Display()
        {
            Console.WriteLine("Display WeatherStatistics!");
            Console.WriteLine(Temp);
            Console.WriteLine(Humidity);
            Console.WriteLine(Pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
            Console.WriteLine("Update for WeatherStatistics reached");
            Display();
        }
    }
}

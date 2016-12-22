using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public class WeatherForecast : InterfaceDisplay, InterfaceObserver
    {
        private float Temp { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }
        private InterfaceSubject Subject { get; set; }
        public WeatherForecast(InterfaceSubject WeatherDataSubject)
        {
            this.Subject = WeatherDataSubject;
            WeatherDataSubject.RegisterObserver(this);

        }

        public void Display()
        {
            Console.WriteLine("Display WeatherForecast!");
            Console.WriteLine(Temp);
            Console.WriteLine(Humidity);
            Console.WriteLine(Pressure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
            Console.WriteLine("Update for WeatherForecast reached");
            Display();
        }
    }
}

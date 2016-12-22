using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public class WeatherData : InterfaceSubject
    {
        private float Temp;
        private float Pressure;
        private float Humidity;
        private List<InterfaceObserver> Observers;
        public WeatherData()
        {
            Observers = new List<InterfaceObserver>();
            
        }
        public void NotifyObservers()
        {
           foreach(var ob in Observers)
            {
                ob.Update(Temp,Humidity,Pressure);
            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObserver(InterfaceObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(InterfaceObserver o)
        {
            Observers.Remove(o);
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temp = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }


}

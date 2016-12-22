
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public interface InterfaceObserver
    {
        void Update(float temp, float humidity, float pressure);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternWeatherDataExample
{
    public interface InterfaceSubject
    {
        void RegisterObserver(InterfaceObserver o);
        void RemoveObserver(InterfaceObserver o);
        void NotifyObservers();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void NotifyObserver(string key);

    public abstract class ObservableObject
    {
        public event NotifyObserver NotifyObserverEvent;

        public void AddObserver(NotifyObserver ob)
        {
            NotifyObserverEvent += ob;
        }

        public void RemoveObserver(NotifyObserver ob)
        {
            NotifyObserverEvent -= ob;
        }

        public void Notify(string kidName)
        {
            if (NotifyObserverEvent != null)
            {
                NotifyObserverEvent(kidName);
            }
        }
    }
}

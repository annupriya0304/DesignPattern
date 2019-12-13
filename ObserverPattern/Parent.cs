using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Parent
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string,>();

        public Dictionary<string, Kid> Kids
        {
            get { return _kids; }
            set { _kids = value; }
        }

        public void DailyStatusUpdate(string key)
        {
            Console.WriteLine("Parents received {0}'s daily status. " +
                              "updated on {1}, Notes: {2} ",
                              Kids[key].Name, Kids[key].DailyStatus.,
                              Kids[key].DailyStatus.);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Kid
    {
        public string Name { get; set; }

        private Status _dailyStatus;

        public Status DailyStatus
        {
            get { return _dailyStatus; }
            set
            {
                _dailyStatus = value;
                Notify(this.Name);
            }
        }
    }
}

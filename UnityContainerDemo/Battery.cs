using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerDemo
{
    class Battery : IBattery
    {
        public bool SelfCheck()
        {
            return true;
        }

        public int ChargeRemaining()
        {
            return 70;
        }

        public string Manufacturer()
        {
            return "Wayne Enterprises";
        }

        public string SerialNumber()
        {
            return "123XXGDASJ2345";
        }
    }
}

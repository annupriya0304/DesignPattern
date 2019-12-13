using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerDemo
{
    class Dial
    {
        public string TypeOfDial { get; set; }

        public Dial(string typeOfDial)
        {
            TypeOfDial = typeOfDial;
        }

        public string DialType()
        {
            return TypeOfDial;
        }
    }
}

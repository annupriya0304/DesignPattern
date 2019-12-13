using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class FamilyDoctor
    {
        private Dictionary<string, Kid> _kids = new Dictionary<string,>();

        public Dictionary<string, Kid> Patients
        {
            get { return _kids; }
            set { _kids = value; }
        }


        public void ReciveNotes(string patientName)
        {
            Console.WriteLine("Family Doctor received {0}'s new daily status. " +
                              "updates on: {1} . Notes:{2}",
                              Paitients[patientName].Name,
                              Paitients[patientName].DailyStatus.UpdatedOn,
                              Paitients[patientName].DailyStatus.Description);
        }
    }
}

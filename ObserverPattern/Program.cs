using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           // Two kids been created
             Kid kid1 = new Kid();
            Kid kid2 = new Kid();

            kid1.Name = "Aimee";
            kid2.Name = "Elizabeth";

            //one parent object created. 
            //this parent has two kids in this case. 
            Parent parent1 = new Parent();
            parent1.Kids.Add(kid1.Name, kid1);
            parent1.Kids.Add(kid2.Name, kid2);

            //one family doctor object created
            //this doctor is kid2's family doctor, 
            //and I am going to send the note when kid2 isn't well
            FamilyDoctor doc1 = new FamilyDoctor();
            doc1.Patients.Add(kid2.Name, kid2);

            //I want to send notes to the parents.
            kid1.AddObserver(new NotifyObserver(parent1.DailyStatusUpdate));
            kid2.AddObserver(new NotifyObserver(parent1.DailyStatusUpdate));

            //Update status for both Kids. 
            //Parents will receive the notes at the same time
            kid1.DailyStatus = new Status(String.Format("{0} is happy", kid1.Name));
            kid2.DailyStatus = new Status(String.Format("{0} is fuzzy", kid2.Name));

            //Updates the status after 5 secs
            Thread.Sleep(5000);

            //after 5 secs, kid2 doesn't feel well. need to get doctor involved
            kid2.AddObserver(new NotifyObserver(doc1.ReciveNotes));

            //update two kids' status. 
            //Parent will recive two kids status
            //Doc1 start reciving kid2 's status
            kid1.DailyStatus = new Status(String.Format("{0} is happy", kid1.Name));
            kid2.DailyStatus = new Status(String.Format("{0} is sick. " +
                                          "Tempture : 39.7", kid2.Name));

            //Updates the status after 5 secs
            Thread.Sleep(5000);

            //update two kids' status
            kid1.DailyStatus = new Status(String.Format("{0} is happy", kid1.Name));
            kid2.DailyStatus = new Status(String.Format("{0} is back to normal. " +
                                          "she is happy now", kid2.Name));


            //Updates the status after 5 secs
            Thread.Sleep(5000);


            //since kid2 is fine. I am going to deattach the doc1's observation
            kid2.RemoveObserver(new NotifyObserver(doc1.ReciveNotes));

            //update two kids' status
            kid1.DailyStatus = new Status(String.Format("{0} is happy. " +
                                   "Just had a big lunch", kid1.Name));
            kid2.DailyStatus = new Status(String.Format("{0} is happy. " +
                                   "Playing with her best friend Kevin", kid2.Name));

            Console.WriteLine("Daily Report End!");
            Console.Read();
        }
    }
}

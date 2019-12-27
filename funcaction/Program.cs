using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaction
{
    class Program
    {
        public delegate double CalulateHraDelegate(int a);
        static void Main(string[] args)
        {
            //wen no return type use action
            Action<string> action = new Action<string>(Display);
            action("Hello!!!");
            //wen return type use func
            Func<int, double> func = new Func<int, double>(CalculateHra);

            // this is equivalent to the above
            CalulateHraDelegate c = new CalulateHraDelegate(CalculateHra);

            //predicate is used to generally compare in colelctions



            Console.Read();
        }

        static void Display(string message)
        {
            Console.WriteLine(message);

        }
        static double CalculateHra(int basic)
        {
            return (double)(basic * .4);
        }


    }
}

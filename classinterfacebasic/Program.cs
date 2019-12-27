using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classinterfacebasic
{
    class Program
    {
        static void Main(string[] args)
        {
            c2 c2 = new c2();
            c2.Sum(2, 3);

            c1 c1 = new c2();
            c1.Sum(2, 3);
            c1.print();


            i1 i1 = new c1();

            i1.Sum(3, 4);
            i1.print();


            i1 i2 = new c2();

            i2.Sum(3, 4);
            i2.print();
        }
    }

   public interface i1
    {
       int Sum(int a, int b);
        void print();
    }

    class c1: i1
    {
       public int Sum(int a, int b)
        {
            return a + b;
        }

        public virtual void print()
        {
            Console.WriteLine("c1 called");
        }
        
    }


    class c2 : c1
    {
        public int Sum(int a, int b)
        {
            return a * b;
        }

        public override void print()
        {
            Console.WriteLine("c2 called");
        }
    }
}

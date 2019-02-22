using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class BubbleSort : ISorting
    {
        public List<T> sort<T>(List<T> ts)
        {
            Console.WriteLine("List has been sorted by bubble sort");
            return ts;
        }
    }

    class SelectionSort : ISorting
    {
        public List<T> sort<T>(List<T> ts)
        {
            Console.WriteLine("List has been sorted by Selection sort");
            return ts;
        }
    }

    class HeapSort : ISorting
    {
        public List<T> sort<T>(List<T> ts)
        {
            Console.WriteLine("List has been sorted by Heap sort");
            return ts;
        }
    }
}

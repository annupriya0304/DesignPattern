using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingStarategy sortingStarategy = new SortingStarategy();
            Console.WriteLine("Enter the integer list to sort. Enter all elements with spaces and then press enter key ");
            List<int> lst = Array.ConvertAll( Console.ReadLine().Split(' '), Int32.Parse).ToList();
            Console.WriteLine("Enter which way u want to sort"); 
            string input = Console.ReadLine();

            switch (input)
            {
                case "Heap":
                    sortingStarategy.Sorting(new HeapSort());
                    sortingStarategy.sort(lst);
                    break;

                case "Bubble":
                    sortingStarategy.Sorting(new BubbleSort());
                    sortingStarategy.sort(lst);
                    break;

                case "Selection":
                    sortingStarategy.Sorting(new SelectionSort());
                    sortingStarategy.sort(lst);
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SortingStarategy
    {
        private ISorting _sortStrategy;     

        public void Sorting(ISorting sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void sort<T>(List<T> ts)
        {
            _sortStrategy.sort(ts);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventsanddelegate
{
    public delegate void PriceChangedHandler(decimal oldPrice,decimal newPrice);
    public class Stock
    {
        string symbol;
        decimal price;
        public Stock(string symbol) { this.symbol = symbol; }
        public event PriceChangedHandler PriceChanged;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return; // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;

                if (PriceChanged != null) // If invocation list not
                    PriceChanged(oldPrice, price); // empty, fire event.
            }
        }
    }
}

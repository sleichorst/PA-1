using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Stock
    {
        public string Company
        {
            get;
            private set;
        }

        /*-------------------------------
         * value when stock was purchased.
        --------------------------------*/
        public decimal Value
        {
            get;
            private set;
        }

        public uint Quantity
        {
            get;
            private set;
        }

        public Stock(string c, decimal v, uint q)
        {
            Company = c;
            Value = v;
            Quantity = q;
        }
    }
}

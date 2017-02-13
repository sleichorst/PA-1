using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ticker501
{
    class Market
    {
        private Dictionary<string, decimal> d;
        private Dictionary<string, string>  codes;

        public Market()
        {
            d = new Dictionary<string, decimal>();
            RefreshPrices();
        }

        /*----------------------------------------
         * Read data from db file
        -----------------------------------------*/
        public void RefreshPrices()
        {
            string text = System.IO.File.ReadAllText(@"Ticker.txt");
            foreach(char ch in text)
            {
                //finish this
            }
        }

        public decimal GetCurrentPrice(string company)
        {
            return d[company];
        }
    }
}

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
            codes = new Dictionary<string, string>();
            RefreshPrices();
        }

        /*----------------------------------------
         * Read data from db file
        -----------------------------------------*/
        public void RefreshPrices()
        {
            string[] text = System.IO.File.ReadAllLines(@"Ticker.txt");
            foreach(string line in text)
            {
                string[] stock = line.Split('-');
                if(stock.Length != 3)
                {
                    continue;
                }
                string code = stock[0];
                string name = stock[1];
                string sPrice = stock[2];
                decimal price = Decimal.Parse(sPrice.Substring(1, sPrice.Length - 1));

                d[code] = price;
                codes[code] = name;
            }
        }

        public decimal GetCurrentPrice(string company)
        {
            return d[company];
        }

        public string GetCompanyName(string code)
        {
            return codes[code];
        }
    }
}

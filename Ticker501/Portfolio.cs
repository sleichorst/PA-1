using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Portfolio
    {
        private string name;
        //private List<Tuple<string, decimal>> stocks; /* string is company code, decimal is price stock was purchased at */
        private Dictionary<string, int> stocks ;
        private decimal netMoneySpent;

        public Portfolio(string n)
        {
            name = n;
            netMoneySpent = 0;
            stocks = new Dictionary<string, int>();
        }

        public string GetName()
        {
            return name;
        }

        public void BuyStock(string code, int number, decimal price)
        {
            stocks[code] = number;
            netMoneySpent += price;
        }
    }
}

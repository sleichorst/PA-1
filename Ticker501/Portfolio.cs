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
        private List<Tuple<string, decimal>> stocks; /* string is company code, decimal is price stock was purchased at */
        public Portfolio(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }
}

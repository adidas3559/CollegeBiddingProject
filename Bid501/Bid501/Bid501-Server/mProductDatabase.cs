
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501_Server
{
    public class mProductDatabase
    {
        public IList<mProduct> _productList;

        public mProductDatabase(IList<mProduct> products)
        {
            _productList = new List<mProduct>();
            foreach (var p in products)
            {
                _productList.Add(p);
            }
        }
    }
}

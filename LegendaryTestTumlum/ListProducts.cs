using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryTestTumlum
{
    class ListProducts
    {
        private Product[] lstProduct;

        public ListProducts()
        {
            lstProduct = new Product[5];
        }
        public Product this[int index]
        {
            get
            {
                return lstProduct[index];
            }
            set
            {
                lstProduct[index] = value;
            }
        }
    }
}

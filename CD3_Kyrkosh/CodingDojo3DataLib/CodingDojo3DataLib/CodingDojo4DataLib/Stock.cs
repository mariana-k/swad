using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo4DataLib
{
    public class Stock
    {
        public List<StockEntry> OnStock { get; set; }

        public Stock()
        {
            OnStock = new List<StockEntry>();
        }
    }
}

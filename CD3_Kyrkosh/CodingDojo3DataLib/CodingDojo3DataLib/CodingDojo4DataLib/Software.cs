using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo4DataLib
{
    public class Software
    {

        public string Name { get; set; }
        public double SalesPrice { get; set; }
        public double PurchasePrice { get; set; }
        public Group Category { get; set; }
        static Random rand = new Random();


        public Software(string name)
        {
           
            this.Name = name;
            this.PurchasePrice = rand.Next(70, 800);
            this.SalesPrice = PurchasePrice * rand.Next(10, 20) / 10;
        }

        public Software(string name, Group category) : this(name)
        {
            this.Category = category;
        }

    }
}

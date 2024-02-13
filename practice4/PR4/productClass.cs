using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    public class productClass
    {
        public int id { get; set; }
        public int fabricator_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int amount { get; set; }
        public byte discount { get; set; }
        public decimal cost { get; set; }

        public productClass(int id, int fabricator_id, string title, string desc, string image, int amount, byte discount, decimal cost)
        {
            this.id = id;
            this.fabricator_id = fabricator_id;
            this.title = title;
            this.description = desc;
            this.image = image;
            this.amount = amount;
            this.discount = discount;
            this.cost = cost;

        }

    }
}

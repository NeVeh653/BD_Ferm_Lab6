using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_app
{
    class Product
    {
        public int id_product { get; set; }
        public string type { get; set; }
        public float volume { get; set; }
        public string quality { get; set; }
        public float cost { get; set; }

        public Product(int id, string type, float volume, string quality, float cost)
        {
            this.id_product = id;
            this.type = type;
            this.volume = volume;
            this.quality = quality;
            this.cost = cost;

        }
    }
}

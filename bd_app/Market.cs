using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_app
{
    class Market
    {
        public int id_market { get; set; }
        public float trade_turnover { get; set; }
        public int number_od_shops_for_sale { get; set; }
        public float square { get; set; }
        public int id_product { get; set; }

        public Market(int id_market, float trade_turnover, int number_od_shops_for_sale, float square, int id_product)
        {
            this.id_market = id_market;
            this.trade_turnover = trade_turnover;
            this.number_od_shops_for_sale = number_od_shops_for_sale;
            this.square = square;
            this.id_product = id_product;
        }
    }
}

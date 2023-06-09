using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_app
{
    public partial class AddMarketForm : Form
    {

        private readonly MainForm _parent;
        public string id_market, trade_turnover, number_od_shops_for_sale, square, id_product;
        Product cle = new Product(0, "", 0, "", 0);

        private void id_product_text_TextChanged(object sender, EventArgs e)
        {
            cle = bd_logic.showProduct(id_product_text.Text);
            type_text.Text = cle.type;
            quality_text.Text = cle.quality;
            cost_text.Text = cle.cost.ToString();
        }
      
        public AddMarketForm(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ButSaveUp_Click(object sender, EventArgs e)
        {
           
            if (!(String.IsNullOrEmpty(trade_turnover_text.Text.ToString()) ||
                  String.IsNullOrEmpty(id_product_text.Text.ToString()) ) &&
                  !(String.IsNullOrEmpty(square_text.Text.ToString()) ||
                  String.IsNullOrEmpty(number_od_shops_for_sale_text.Text.ToString())))
            {
                if (ButSaveUp.Text == "Save")
                {
                    Market cle = new Market(0, Convert.ToSingle(trade_turnover_text.Text), Convert.ToInt32(number_od_shops_for_sale_text.Text), Convert.ToSingle(square_text.Text), Convert.ToInt32(id_product_text.Text));
                    bd_logic.AddMarket(cle);
                    Clear();
                }
                if (ButSaveUp.Text == "Update")
                {
                    Market cle = new Market(0, Convert.ToSingle(trade_turnover_text.Text), Convert.ToInt32(number_od_shops_for_sale_text.Text), Convert.ToSingle(square_text.Text), Convert.ToInt32(id_product_text.Text));
                    bd_logic.UpdateMarket(cle, id_market);

                }
                _parent.Display();
            }
            else MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        public void UpdateInfo()
        {
            ButSaveUp.Text = "Update";
            trade_turnover_text.Text = trade_turnover;
            square_text.Text = square;
            id_product_text.Text = id_product;
            number_od_shops_for_sale_text.Text = number_od_shops_for_sale;

            cle = bd_logic.showProduct(id_product);
            type_text.Text = cle.type;
            quality_text.Text = cle.quality;
            cost_text.Text = cle.cost.ToString();



        }

        //Установить режим добавления
        public void SaveInfo()
        {
            ButSaveUp.Text = "Save";
        }

        // Очищение строк для ввода данных
        public void Clear()
        {
            trade_turnover_text.Text = square_text.Text = id_product_text.Text = number_od_shops_for_sale_text.Text = string.Empty;
        }
    }
}

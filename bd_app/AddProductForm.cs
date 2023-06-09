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
    public partial class AddProductForm : Form
    {
        private readonly MainForm _parent;
        public string id, type, volume, quality, cost;

        private void AddProdForm_Load(object sender, EventArgs e)
        {

        }

        public AddProductForm(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Установить режим обновления 
        public void UpdateInfo()
        {
            BtnSave.Text = "Update";
            Type_text.Text = type;
            Volume_text.Text = volume;
            comboBox1.Text = quality;
            cost_text.Text = cost;
        }
        //Установить режим добавления
        public void SaveInfo()
        {
            BtnSave.Text = "Save";
        }

        //Очищение строк для ввода данных
        public void Clear()
        {
            Type_text.Text = Volume_text.Text = comboBox1.Text = cost_text.Text = string.Empty;
        }


        //Кнопака добавления\обновления 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(String.IsNullOrEmpty(Type_text.Text.ToString()) ||
                   String.IsNullOrEmpty(Volume_text.Text.ToString()) ||
                   String.IsNullOrEmpty(comboBox1.Text.ToString()) ||
                   String.IsNullOrEmpty(cost_text.Text.ToString())
                   ))
                {

                    if (BtnSave.Text == "Save")
                    {
                        Product std = new Product(0, Type_text.Text, Convert.ToSingle(Volume_text.Text), comboBox1.Text, Convert.ToSingle(cost_text.Text));
                        bd_logic.AddProduct(std);
                        Clear();
                    }
                    if (BtnSave.Text == "Update")
                    {
                        Product std = new Product(0, Type_text.Text, Convert.ToSingle(Volume_text.Text), comboBox1.Text, Convert.ToSingle(cost_text.Text));
                        bd_logic.UpdateProduct(std, id);

                    }
                    _parent.Display();
                }
                else
                { 
                 MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch 
            {
                MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

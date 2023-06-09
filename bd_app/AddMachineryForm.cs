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
    public partial class AddMachineryForm : Form
    {
        private readonly MainForm _parent;
        public string id_machinery, cost, status,type_of_machine;

        //Кнопка добавления\обнавления 
        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(cost_text.Text.ToString()) ||
                   String.IsNullOrEmpty(status_text.Text.ToString()) ||
                   String.IsNullOrEmpty(type_of_machine_text.Text.ToString()) 
                   ))
            {
                if (BtnSave.Text == "Save")
                {
                    Machinery cle = new Machinery(0, Convert.ToSingle(cost_text.Text), status_text.Text, type_of_machine_text.Text);
                    bd_logic.AddMachinery(cle);
                    Clear();
                }
                if (BtnSave.Text == "Update")
                {
                    Machinery cle = new Machinery(0, Convert.ToSingle(cost_text.Text), status_text.Text, type_of_machine_text.Text);
                    bd_logic.UpdateMachinery(cle, id_machinery);

                }
                _parent.Display();
            }
            else MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public AddMachineryForm(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        //Установить режим обновления 
        public void UpdateInfo()
        {
            BtnSave.Text = "Update";
            cost_text.Text = cost;
            status_text.Text = status;
            type_of_machine_text.Text = type_of_machine;
        }

        //Установить режим добавления
        public void SaveInfo()
        {
            BtnSave.Text = "Save";
        }

        // Очищение строк для ввода данных
        public void Clear()
        {
            cost_text.Text =  status_text.Text = type_of_machine_text.Text = string.Empty;
        }
    }
}

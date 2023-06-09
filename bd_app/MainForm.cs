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
    public partial class MainForm : Form
    {
        AddProductForm form;  // Форма добавления\обновления продукта
        AddMachineryForm form2; // Форма добавления\обновления клиента
        ExQuery form3; //Форма выполнения запросов
        AddMarketForm form4; //Форма добавления\обновления корзины 

        public string currentTable;  // Текущая таблица
        public string selectRow;  // Выбранная строка в таблице

        public MainForm()
        {
            // инициализация форм
            InitializeComponent();
            form = new AddProductForm(this); 
            form2 = new AddMachineryForm(this);
            form4 = new AddMarketForm(this);
            Choosetable.Text = "product";
            Choosetable.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Кнопка добавления записи , учитывая какая выбранна таблица
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentTable == "market")
            {
                form4.SaveInfo();
                form4.Clear();
                form4.ShowDialog();
            }
            if (currentTable == "product")
            {
                form.SaveInfo();
                form.Clear();
                form.ShowDialog();
            }
            if (currentTable == "machinery")
            {
                form2.SaveInfo();
                form2.Clear();
                form2.ShowDialog();
            }

        }

        // Отображение выбранной таблицы
        public void Display()
        {
            bd_logic.DisplayAndSearch(currentTable, searchtext.Text, dataGridView1);

            try
            {
                if (Convert.ToInt32(selectRow ) > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0];
                }
            }
            catch {}

            dataGridView1.Sort(dataGridView1.Columns[0] , ListSortDirection.Ascending);

        }

        // Функция вызываемая при изменении выбора текущей таблици 
        private void Choosetable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Запись названия выбранной таблицы
            currentTable = Choosetable.Text;

            //Очищение таблицы вывода
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
    

            selectRow = "0";
            //Очистка строки поиска
            searchtext.Clear();
            // Отображение выбранной таблицы
            
            Display();
        }

        //Загруска главной формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отображение выбранной таблицы
            Display();
        }

        //Изменение строки поиска
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //отображение таблици с учётом поиска
                Display();
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
            catch  { }

        }
        //Кнопка Обновления
        private void Upbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTable == "market")
                {
                    form4.Clear();
                    form4.id_market = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString();
                    form4.trade_turnover = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[1].Value.ToString();
                    form4.number_od_shops_for_sale = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[2].Value.ToString();
                    form4.square =dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[3].Value.ToString();
                    form4.id_product = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[4].Value.ToString();
                    form4.UpdateInfo();
                    form4.ShowDialog();
                }
                if (currentTable == "product")
                {
                    form.Clear();
                    form.id = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString();
                    form.type = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[1].Value.ToString();
                    form.volume = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[2].Value.ToString();
                    form.quality = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[3].Value.ToString();
                    form.cost = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[4].Value.ToString();
                    form.UpdateInfo();
                    form.ShowDialog();

                }
                if (currentTable == "machinery")
                {
                    form2.Clear();
                    form2.id_machinery = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString();
                    form2.cost = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[1].Value.ToString();
                    form2.status = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[2].Value.ToString();
                    form2.type_of_machine = dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[3].Value.ToString();
                    form2.UpdateInfo();
                    form2.ShowDialog();
                }
            }
            catch 
            {
                MessageBox.Show("Row not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Запись индекса выбранной строки
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = dataGridView1.SelectedRows[0].Index.ToString();
        }

        //Кнопка Удаления 
        private void delbut_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTable == "machinery" || currentTable == "product")
                {

                    if (MessageBox.Show("Are you wand to delete record? \n This can result in a cascading deletion in a tables.", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (currentTable == "product")
                        {
                            bd_logic.DeleteProduct(dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                        }
                        if (currentTable == "machinery")
                        {
                            bd_logic.DeleteMachinery(dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                        }
                        selectRow = (Convert.ToInt32(selectRow) - 1).ToString();
                        Display();
                    }

                }
                else if (MessageBox.Show("Are you wand to delete record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    if (currentTable == "market")
                    {
                        bd_logic.DeleteMarket(dataGridView1.Rows[Convert.ToInt32(selectRow)].Cells[0].Value.ToString());
                    }

                     selectRow = (Convert.ToInt32(selectRow) - 1).ToString();
                     Display();

                }  
                    
                   
               
            }
            catch{}   
        }


        //Кнопка выполнения запосров
        private void toExBut_Click(object sender, EventArgs e)
        {
            form3 = new ExQuery();
            form3.Clear();
            form3.Show();
        }

     
    }
}

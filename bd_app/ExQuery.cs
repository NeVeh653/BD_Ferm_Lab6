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
    public partial class ExQuery : Form
    {
        public ExQuery()
        {
            InitializeComponent();
        }

        public  void Clear()
        {
            One_text.Text = Two_text.Text = Result_text.Text = string.Empty;
        }

        private void ExBut_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(One_text.Text) || string.IsNullOrEmpty(Two_text.Text)))
            {
                Result_text.Text = bd_logic.QueryOne(One_text.Text, Two_text.Text);
            }
            else
            {
                MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ExButTwo_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(name_text.Text)))
            {
                Res_text_Two.Text = bd_logic.QueryTwo(name_text.Text);
            }
            else
            {
                MessageBox.Show("Data entered incorrectly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExQuery_Load(object sender, EventArgs e)
        {

        }

    
    }
}

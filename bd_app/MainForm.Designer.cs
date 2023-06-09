namespace bd_app
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Upbut = new System.Windows.Forms.Button();
            this.delbut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toExBut = new System.Windows.Forms.Button();
            this.Choosetable = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Upbut);
            this.panel1.Controls.Add(this.delbut);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.searchtext);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(24, 69);
            this.panel1.MinimumSize = new System.Drawing.Size(559, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 315);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Upbut
            // 
            this.Upbut.Location = new System.Drawing.Point(118, 15);
            this.Upbut.Name = "Upbut";
            this.Upbut.Size = new System.Drawing.Size(75, 23);
            this.Upbut.TabIndex = 3;
            this.Upbut.Text = "Update";
            this.Upbut.UseVisualStyleBackColor = true;
            this.Upbut.Click += new System.EventHandler(this.Upbut_Click);
            // 
            // delbut
            // 
            this.delbut.Location = new System.Drawing.Point(199, 14);
            this.delbut.Name = "delbut";
            this.delbut.Size = new System.Drawing.Size(75, 23);
            this.delbut.TabIndex = 2;
            this.delbut.Text = "Delete";
            this.delbut.UseVisualStyleBackColor = true;
            this.delbut.Click += new System.EventHandler(this.delbut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 56);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(537, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchtext
            // 
            this.searchtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchtext.Location = new System.Drawing.Point(394, 17);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(114, 20);
            this.searchtext.TabIndex = 1;
            this.searchtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toExBut);
            this.panel2.Controls.Add(this.Choosetable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(559, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 51);
            this.panel2.TabIndex = 1;
            // 
            // toExBut
            // 
            this.toExBut.Location = new System.Drawing.Point(186, 12);
            this.toExBut.Name = "toExBut";
            this.toExBut.Size = new System.Drawing.Size(75, 23);
            this.toExBut.TabIndex = 1;
            this.toExBut.Text = "Execute";
            this.toExBut.UseVisualStyleBackColor = true;
            this.toExBut.Click += new System.EventHandler(this.toExBut_Click);
            // 
            // Choosetable
            // 
            this.Choosetable.FormattingEnabled = true;
            this.Choosetable.Items.AddRange(new object[] {
            "product",
            "market",
            "machinery"});
            this.Choosetable.Location = new System.Drawing.Point(37, 12);
            this.Choosetable.Name = "Choosetable";
            this.Choosetable.Size = new System.Drawing.Size(121, 21);
            this.Choosetable.TabIndex = 0;
            this.Choosetable.SelectedIndexChanged += new System.EventHandler(this.Choosetable_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ROSinka Farm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button Upbut;
        private System.Windows.Forms.Button delbut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Choosetable;
        private System.Windows.Forms.Button toExBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


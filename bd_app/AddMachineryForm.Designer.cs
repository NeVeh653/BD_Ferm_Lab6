namespace bd_app
{
    partial class AddMachineryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMachineryForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cost_text = new System.Windows.Forms.TextBox();
            this.FIO_label = new System.Windows.Forms.Label();
            this.log_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status_text = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.type_of_machine_text = new System.Windows.Forms.TextBox();
            this.Pas_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 56);
            this.panel1.TabIndex = 1;
            // 
            // cost_text
            // 
            this.cost_text.Location = new System.Drawing.Point(112, 28);
            this.cost_text.Name = "cost_text";
            this.cost_text.Size = new System.Drawing.Size(233, 20);
            this.cost_text.TabIndex = 1;
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Location = new System.Drawing.Point(23, 77);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(37, 13);
            this.FIO_label.TabIndex = 0;
            this.FIO_label.Text = "Status";
            // 
            // log_label
            // 
            this.log_label.AutoSize = true;
            this.log_label.Location = new System.Drawing.Point(23, 31);
            this.log_label.Name = "log_label";
            this.log_label.Size = new System.Drawing.Size(28, 13);
            this.log_label.TabIndex = 0;
            this.log_label.Text = "Cost";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.status_text);
            this.panel2.Controls.Add(this.BtnSave);
            this.panel2.Controls.Add(this.type_of_machine_text);
            this.panel2.Controls.Add(this.cost_text);
            this.panel2.Controls.Add(this.Pas_label);
            this.panel2.Controls.Add(this.FIO_label);
            this.panel2.Controls.Add(this.log_label);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 359);
            this.panel2.TabIndex = 2;
            // 
            // status_text
            // 
            this.status_text.FormattingEnabled = true;
            this.status_text.Items.AddRange(new object[] {
            "good",
            "medium",
            "bad"});
            this.status_text.Location = new System.Drawing.Point(112, 77);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(233, 21);
            this.status_text.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(142, 330);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // type_of_machine_text
            // 
            this.type_of_machine_text.Location = new System.Drawing.Point(112, 116);
            this.type_of_machine_text.Name = "type_of_machine_text";
            this.type_of_machine_text.Size = new System.Drawing.Size(233, 20);
            this.type_of_machine_text.TabIndex = 1;
            // 
            // Pas_label
            // 
            this.Pas_label.AutoSize = true;
            this.Pas_label.Location = new System.Drawing.Point(20, 119);
            this.Pas_label.Name = "Pas_label";
            this.Pas_label.Size = new System.Drawing.Size(86, 13);
            this.Pas_label.TabIndex = 0;
            this.Pas_label.Text = "Type of machine";
            // 
            // AddMachineryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMachineryForm";
            this.Text = "Machinery";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cost_text;
        private System.Windows.Forms.Label FIO_label;
        private System.Windows.Forms.Label log_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox type_of_machine_text;
        private System.Windows.Forms.Label Pas_label;
        private System.Windows.Forms.ComboBox status_text;
    }
}
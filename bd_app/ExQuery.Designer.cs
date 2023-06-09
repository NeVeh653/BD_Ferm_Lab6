namespace bd_app
{
    partial class ExQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExQuery));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Result_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Two_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.One_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ExBut = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExButTwo = new System.Windows.Forms.Button();
            this.Res_text_Two = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.Result_text);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Two_text);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.One_text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ExBut);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Запрос 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Result_text
            // 
            this.Result_text.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result_text.Location = new System.Drawing.Point(3, 303);
            this.Result_text.Name = "Result_text";
            this.Result_text.Size = new System.Drawing.Size(334, 20);
            this.Result_text.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Результат";
            // 
            // Two_text
            // 
            this.Two_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Two_text.Location = new System.Drawing.Point(120, 89);
            this.Two_text.Name = "Two_text";
            this.Two_text.Size = new System.Drawing.Size(135, 20);
            this.Two_text.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата рождения\r\nпользователя";
            // 
            // One_text
            // 
            this.One_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.One_text.Location = new System.Drawing.Point(120, 63);
            this.One_text.Name = "One_text";
            this.One_text.Size = new System.Drawing.Size(135, 20);
            this.One_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя покупателя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "          \r\nВывод цены купленного продукта \r\nпо личным данным покупателя";
            // 
            // ExBut
            // 
            this.ExBut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExBut.Location = new System.Drawing.Point(3, 323);
            this.ExBut.Name = "ExBut";
            this.ExBut.Size = new System.Drawing.Size(334, 23);
            this.ExBut.TabIndex = 0;
            this.ExBut.Text = "Выполнить";
            this.ExBut.UseVisualStyleBackColor = true;
            this.ExBut.Click += new System.EventHandler(this.ExBut_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExButTwo);
            this.tabPage2.Controls.Add(this.Res_text_Two);
            this.tabPage2.Controls.Add(this.name_text);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(340, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Запрос 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExButTwo
            // 
            this.ExButTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExButTwo.Location = new System.Drawing.Point(6, 321);
            this.ExButTwo.Name = "ExButTwo";
            this.ExButTwo.Size = new System.Drawing.Size(329, 25);
            this.ExButTwo.TabIndex = 3;
            this.ExButTwo.Text = "Выполнить";
            this.ExButTwo.UseVisualStyleBackColor = true;
            this.ExButTwo.Click += new System.EventHandler(this.ExButTwo_Click);
            // 
            // Res_text_Two
            // 
            this.Res_text_Two.Location = new System.Drawing.Point(6, 295);
            this.Res_text_Two.Name = "Res_text_Two";
            this.Res_text_Two.Size = new System.Drawing.Size(326, 20);
            this.Res_text_Two.TabIndex = 2;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(124, 66);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 20);
            this.name_text.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Результат";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Имя работника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вывод стоимости техники,\r\n на которой работает указанный работник";
            // 
            // ExQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 375);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(364, 414);
            this.Name = "ExQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExQuery";
            this.Load += new System.EventHandler(this.ExQuery_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExBut;
        private System.Windows.Forms.TextBox Result_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Two_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox One_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExButTwo;
        private System.Windows.Forms.TextBox Res_text_Two;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label9;
    }
}
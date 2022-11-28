namespace Final
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbxTypeCountry = new System.Windows.Forms.GroupBox();
            this.cbxinter = new System.Windows.Forms.CheckBox();
            this.cbxNat = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEmpid = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbxTypeCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ship Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 26);
            this.textBox3.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(468, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 264);
            this.listBox1.TabIndex = 6;
            // 
            // gbxTypeCountry
            // 
            this.gbxTypeCountry.Controls.Add(this.cbxinter);
            this.gbxTypeCountry.Controls.Add(this.cbxNat);
            this.gbxTypeCountry.Location = new System.Drawing.Point(38, 224);
            this.gbxTypeCountry.Name = "gbxTypeCountry";
            this.gbxTypeCountry.Size = new System.Drawing.Size(200, 100);
            this.gbxTypeCountry.TabIndex = 7;
            this.gbxTypeCountry.TabStop = false;
            // 
            // cbxinter
            // 
            this.cbxinter.AutoSize = true;
            this.cbxinter.Location = new System.Drawing.Point(21, 58);
            this.cbxinter.Name = "cbxinter";
            this.cbxinter.Size = new System.Drawing.Size(124, 24);
            this.cbxinter.TabIndex = 1;
            this.cbxinter.Text = "International";
            this.cbxinter.UseVisualStyleBackColor = true;
            // 
            // cbxNat
            // 
            this.cbxNat.AutoSize = true;
            this.cbxNat.Location = new System.Drawing.Point(21, 15);
            this.cbxNat.Name = "cbxNat";
            this.cbxNat.Size = new System.Drawing.Size(93, 24);
            this.cbxNat.TabIndex = 0;
            this.cbxNat.Text = "National";
            this.cbxNat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee ID:";
            // 
            // cboEmpid
            // 
            this.cboEmpid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpid.FormattingEnabled = true;
            this.cboEmpid.Location = new System.Drawing.Point(144, 365);
            this.cboEmpid.Name = "cboEmpid";
            this.cboEmpid.Size = new System.Drawing.Size(83, 28);
            this.cboEmpid.TabIndex = 9;
            this.cboEmpid.SelectedIndexChanged += new System.EventHandler(this.cboEmpid_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(414, 369);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 45);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cboEmpid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbxTypeCountry);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbxTypeCountry.ResumeLayout(false);
            this.gbxTypeCountry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox gbxTypeCountry;
        private System.Windows.Forms.CheckBox cbxinter;
        private System.Windows.Forms.CheckBox cbxNat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEmpid;
        private System.Windows.Forms.Button btnReturn;
    }
}
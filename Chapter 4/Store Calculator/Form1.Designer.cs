namespace Store_Calculator
{
    partial class Form1
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
            this.txtscore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(129, 39);
            this.txtscore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(71, 20);
            this.txtscore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStotal
            // 
            this.txtStotal.Location = new System.Drawing.Point(129, 76);
            this.txtStotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStotal.Name = "txtStotal";
            this.txtStotal.ReadOnly = true;
            this.txtStotal.Size = new System.Drawing.Size(68, 20);
            this.txtStotal.TabIndex = 3;
            this.txtStotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtScount
            // 
            this.txtScount.Location = new System.Drawing.Point(129, 113);
            this.txtScount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtScount.Name = "txtScount";
            this.txtScount.ReadOnly = true;
            this.txtScount.Size = new System.Drawing.Size(68, 20);
            this.txtScount.TabIndex = 5;
            this.txtScount.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average:";
            // 
            // txtaverage
            // 
            this.txtaverage.Location = new System.Drawing.Point(129, 152);
            this.txtaverage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.ReadOnly = true;
            this.txtaverage.Size = new System.Drawing.Size(68, 20);
            this.txtaverage.TabIndex = 7;
            this.txtaverage.TabStop = false;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(110, 196);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(69, 27);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(284, 39);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(71, 28);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Location = new System.Drawing.Point(284, 196);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(71, 27);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnadd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(417, 291);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtScount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Score calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaverage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
    }
}


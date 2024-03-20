namespace BaiThucHanh1
{
    partial class BaiSo1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(249, 84);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(78, 16);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Số thứ nhất :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai :";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(350, 78);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(251, 22);
            this.txt1.TabIndex = 2;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(350, 169);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(251, 22);
            this.txt2.TabIndex = 3;
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // btnKQ
            // 
            this.btnKQ.BackColor = System.Drawing.Color.Chartreuse;
            this.btnKQ.ForeColor = System.Drawing.Color.Red;
            this.btnKQ.Location = new System.Drawing.Point(252, 258);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(75, 26);
            this.btnKQ.TabIndex = 4;
            this.btnKQ.Text = "Kết quả";
            this.btnKQ.UseVisualStyleBackColor = false;
            this.btnKQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(350, 258);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(251, 22);
            this.txt3.TabIndex = 5;
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BaiSo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Name = "BaiSo1";
            this.Text = "BaiSo1";
            this.Load += new System.EventHandler(this.BaiSo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.TextBox txt3;
    }
}
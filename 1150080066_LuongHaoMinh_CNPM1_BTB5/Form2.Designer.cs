
using System;
using System.Windows.Forms;

namespace Tim_USCLN_BSCNN
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbBSCNN = new System.Windows.Forms.RadioButton();
            this.rdbUSCLN = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(120, 80);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(120, 35);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 20);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số nguyên b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nguyên a:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.rdbBSCNN);
            this.groupBox2.Controls.Add(this.rdbUSCLN);
            this.groupBox2.Location = new System.Drawing.Point(360, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // rdbBSCNN
            // 
            this.rdbBSCNN.AutoSize = true;
            this.rdbBSCNN.Location = new System.Drawing.Point(35, 75);
            this.rdbBSCNN.Name = "rdbBSCNN";
            this.rdbBSCNN.Size = new System.Drawing.Size(62, 17);
            this.rdbBSCNN.TabIndex = 1;
            this.rdbBSCNN.Text = "BSCNN";
            this.rdbBSCNN.UseVisualStyleBackColor = true;
            // 
            // rdbUSCLN
            // 
            this.rdbUSCLN.AutoSize = true;
            this.rdbUSCLN.Checked = true;
            this.rdbUSCLN.Location = new System.Drawing.Point(35, 35);
            this.rdbUSCLN.Name = "rdbUSCLN";
            this.rdbUSCLN.Size = new System.Drawing.Size(61, 17);
            this.rdbUSCLN.TabIndex = 0;
            this.rdbUSCLN.TabStop = true;
            this.rdbUSCLN.Text = "USCLN";
            this.rdbUSCLN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(104, 220);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(250, 20);
            this.txtKetQua.TabIndex = 3;
            this.txtKetQua.TextChanged += new System.EventHandler(this.txtKetQua_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(395, 202);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 25);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(395, 247);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(570, 314);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của 2 số nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtB;
        private TextBox txtA;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdbBSCNN;
        private RadioButton rdbUSCLN;
        private Label label3;
        private TextBox txtKetQua;
        private Button btnTim;
        private Button btnThoat;
    }
}

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    partial class Form6
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lsbDaySo = new System.Windows.Forms.ListBox();
            this.lblChucNang = new System.Windows.Forms.Label();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnChanDau = new System.Windows.Forms.Button();
            this.btnLeCuoi = new System.Windows.Forms.Button();
            this.btnXoaChon = new System.Windows.Forms.Button();
            this.btnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaDaySo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Teal;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ứng dụng xử lý dãy số";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(30, 65);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(94, 16);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "Nhập số nguyên:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(140, 62);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(310, 60);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(100, 25);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lsbDaySo
            // 
            this.lsbDaySo.FormattingEnabled = true;
            this.lsbDaySo.ItemHeight = 16;
            this.lsbDaySo.Location = new System.Drawing.Point(30, 100);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new System.Drawing.Size(250, 180);
            this.lsbDaySo.TabIndex = 4;
            // 
            // lblChucNang
            // 
            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Location = new System.Drawing.Point(320, 100);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Size = new System.Drawing.Size(73, 16);
            this.lblChucNang.TabIndex = 5;
            this.lblChucNang.Text = "Chức năng:";
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(320, 120);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(200, 25);
            this.btnTang2.TabIndex = 6;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnChanDau
            // 
            this.btnChanDau.Location = new System.Drawing.Point(320, 150);
            this.btnChanDau.Name = "btnChanDau";
            this.btnChanDau.Size = new System.Drawing.Size(200, 25);
            this.btnChanDau.TabIndex = 7;
            this.btnChanDau.Text = "Chọn số chẵn đầu";
            this.btnChanDau.UseVisualStyleBackColor = true;
            this.btnChanDau.Click += new System.EventHandler(this.btnChanDau_Click);
            // 
            // btnLeCuoi
            // 
            this.btnLeCuoi.Location = new System.Drawing.Point(320, 180);
            this.btnLeCuoi.Name = "btnLeCuoi";
            this.btnLeCuoi.Size = new System.Drawing.Size(200, 25);
            this.btnLeCuoi.TabIndex = 8;
            this.btnLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnLeCuoi.UseVisualStyleBackColor = true;
            this.btnLeCuoi.Click += new System.EventHandler(this.btnLeCuoi_Click);
            // 
            // btnXoaChon
            // 
            this.btnXoaChon.Location = new System.Drawing.Point(320, 210);
            this.btnXoaChon.Name = "btnXoaChon";
            this.btnXoaChon.Size = new System.Drawing.Size(200, 25);
            this.btnXoaChon.TabIndex = 9;
            this.btnXoaChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaChon.UseVisualStyleBackColor = true;
            this.btnXoaChon.Click += new System.EventHandler(this.btnXoaChon_Click);
            // 
            // btnXoaDau
            // 
            this.btnXoaDau.Location = new System.Drawing.Point(320, 240);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new System.Drawing.Size(200, 25);
            this.btnXoaDau.TabIndex = 10;
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;
            this.btnXoaDau.Click += new System.EventHandler(this.btnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(320, 270);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(200, 25);
            this.btnXoaCuoi.TabIndex = 11;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(120, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 40);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Kết thúc ứng dụng";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaDaySo
            // 
            this.btnXoaDaySo.BackColor = System.Drawing.Color.Black;
            this.btnXoaDaySo.ForeColor = System.Drawing.Color.White;
            this.btnXoaDaySo.Location = new System.Drawing.Point(320, 310);
            this.btnXoaDaySo.Name = "btnXoaDaySo";
            this.btnXoaDaySo.Size = new System.Drawing.Size(180, 40);
            this.btnXoaDaySo.TabIndex = 13;
            this.btnXoaDaySo.Text = "Xóa dãy số";
            this.btnXoaDaySo.UseVisualStyleBackColor = false;
            this.btnXoaDaySo.Click += new System.EventHandler(this.btnXoaDaySo_Click);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(600, 370);
            this.Controls.Add(this.btnXoaDaySo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaCuoi);
            this.Controls.Add(this.btnXoaDau);
            this.Controls.Add(this.btnXoaChon);
            this.Controls.Add(this.btnLeCuoi);
            this.Controls.Add(this.btnChanDau);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.lsbDaySo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form6";
            this.Text = "Ứng dụng xử lý dãy số";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ListBox lsbDaySo;
        private System.Windows.Forms.Label lblChucNang;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnChanDau;
        private System.Windows.Forms.Button btnLeCuoi;
        private System.Windows.Forms.Button btnXoaChon;
        private System.Windows.Forms.Button btnXoaDau;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaDaySo;
    }
}

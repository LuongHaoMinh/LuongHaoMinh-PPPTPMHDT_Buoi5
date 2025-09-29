namespace PhongKhamNhaKhoa
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBocRang = new System.Windows.Forms.CheckBox();
            this.chkBeRang = new System.Windows.Forms.CheckBox();
            this.chkHanRang = new System.Windows.Forms.CheckBox();
            this.chkTayTrang = new System.Windows.Forms.CheckBox();
            this.chkLayCaoRang = new System.Windows.Forms.CheckBox();
            this.nupBocRang = new System.Windows.Forms.NumericUpDown();
            this.nupBeRang = new System.Windows.Forms.NumericUpDown();
            this.nupHanRang = new System.Windows.Forms.NumericUpDown();
            this.lblBocRang = new System.Windows.Forms.Label();
            this.lblBeRang = new System.Windows.Forms.Label();
            this.lblHanRang = new System.Windows.Forms.Label();
            this.lblTayTrang = new System.Windows.Forms.Label();
            this.lblCaoRang = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.BackColor = System.Drawing.Color.Green;
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(520, 40);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(130, 22);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(340, 22);
            this.txtTenKH.TabIndex = 1;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenKH_Validating);
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(10, 25);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(99, 17);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBocRang);
            this.groupBox2.Controls.Add(this.chkBeRang);
            this.groupBox2.Controls.Add(this.chkHanRang);
            this.groupBox2.Controls.Add(this.chkTayTrang);
            this.groupBox2.Controls.Add(this.chkLayCaoRang);
            this.groupBox2.Controls.Add(this.nupBocRang);
            this.groupBox2.Controls.Add(this.nupBeRang);
            this.groupBox2.Controls.Add(this.nupHanRang);
            this.groupBox2.Controls.Add(this.lblBocRang);
            this.groupBox2.Controls.Add(this.lblBeRang);
            this.groupBox2.Controls.Add(this.lblHanRang);
            this.groupBox2.Controls.Add(this.lblTayTrang);
            this.groupBox2.Controls.Add(this.lblCaoRang);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ tại phòng khám";
            // 
            // Các checkbox + label + numericupdown
            // 
            this.chkLayCaoRang.Location = new System.Drawing.Point(15, 25);
            this.chkLayCaoRang.Text = "Lấy cao răng";
            this.lblCaoRang.Location = new System.Drawing.Point(180, 27);
            this.lblCaoRang.Text = "50.000đ/2 hàm";

            this.chkTayTrang.Location = new System.Drawing.Point(15, 55);
            this.chkTayTrang.Text = "Tẩy trắng răng";
            this.lblTayTrang.Location = new System.Drawing.Point(180, 57);
            this.lblTayTrang.Text = "100.000đ/2 hàm";

            this.chkHanRang.Location = new System.Drawing.Point(15, 85);
            this.chkHanRang.Text = "Hàn răng";
            this.lblHanRang.Location = new System.Drawing.Point(180, 87);
            this.lblHanRang.Text = "100.000đ/1 răng";
            this.nupHanRang.Location = new System.Drawing.Point(350, 85);
            this.nupHanRang.Maximum = 32;

            this.chkBeRang.Location = new System.Drawing.Point(15, 115);
            this.chkBeRang.Text = "Bẻ răng";
            this.lblBeRang.Location = new System.Drawing.Point(180, 117);
            this.lblBeRang.Text = "10.000đ/1 răng";
            this.nupBeRang.Location = new System.Drawing.Point(350, 115);
            this.nupBeRang.Maximum = 32;

            this.chkBocRang.Location = new System.Drawing.Point(15, 145);
            this.chkBocRang.Text = "Bọc răng";
            this.lblBocRang.Location = new System.Drawing.Point(180, 147);
            this.lblBocRang.Text = "1.000.000đ/1 răng";
            this.nupBocRang.Location = new System.Drawing.Point(350, 145);
            this.nupBocRang.Maximum = 32;

            // 
            // groupBox3 - Chức năng
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.btnTinhTien);
            this.groupBox3.Location = new System.Drawing.Point(12, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(15, 25);
            this.btnTinhTien.Size = new System.Drawing.Size(100, 30);
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(130, 30);
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(150, 22);
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 25);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 390);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form4";
            this.Text = "Phòng khám nha khoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupBocRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBeRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHanRang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkLayCaoRang;
        private System.Windows.Forms.CheckBox chkTayTrang;
        private System.Windows.Forms.CheckBox chkHanRang;
        private System.Windows.Forms.CheckBox chkBeRang;
        private System.Windows.Forms.CheckBox chkBocRang;
        private System.Windows.Forms.Label lblCaoRang;
        private System.Windows.Forms.Label lblTayTrang;
        private System.Windows.Forms.Label lblHanRang;
        private System.Windows.Forms.Label lblBeRang;
        private System.Windows.Forms.Label lblBocRang;
        private System.Windows.Forms.NumericUpDown nupHanRang;
        private System.Windows.Forms.NumericUpDown nupBeRang;
        private System.Windows.Forms.NumericUpDown nupBocRang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.ErrorProvider err;
    }
}

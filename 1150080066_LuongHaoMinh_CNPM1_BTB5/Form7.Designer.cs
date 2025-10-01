namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    partial class Form7
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblLuaChon = new System.Windows.Forms.Label();
            this.lsbDanhSach = new System.Windows.Forms.ListBox();
            this.lsbLuaChon = new System.Windows.Forms.ListBox();
            this.btnChuyen1 = new System.Windows.Forms.Button();
            this.btnChuyenAll = new System.Windows.Forms.Button();
            this.btnXoa1 = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(30, 20);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(127, 13);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách các mặt hàng";
            // 
            // lblLuaChon
            // 
            this.lblLuaChon.AutoSize = true;
            this.lblLuaChon.Location = new System.Drawing.Point(360, 20);
            this.lblLuaChon.Name = "lblLuaChon";
            this.lblLuaChon.Size = new System.Drawing.Size(117, 13);
            this.lblLuaChon.TabIndex = 1;
            this.lblLuaChon.Text = "Các mặt hàng lựa chọn";
            // 
            // lsbDanhSach
            // 
            this.lsbDanhSach.FormattingEnabled = true;
            this.lsbDanhSach.Items.AddRange(new object[] {
            "CPU",
            "MainBoard",
            "RAM",
            "Keyboard",
            "Mouse",
            "NIC",
            "FAN"});
            this.lsbDanhSach.Location = new System.Drawing.Point(30, 50);
            this.lsbDanhSach.Name = "lsbDanhSach";
            this.lsbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbDanhSach.Size = new System.Drawing.Size(200, 173);
            this.lsbDanhSach.TabIndex = 2;
            this.lsbDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsbDanhSach_SelectedIndexChanged);
            // 
            // lsbLuaChon
            // 
            this.lsbLuaChon.FormattingEnabled = true;
            this.lsbLuaChon.Location = new System.Drawing.Point(360, 50);
            this.lsbLuaChon.Name = "lsbLuaChon";
            this.lsbLuaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbLuaChon.Size = new System.Drawing.Size(200, 173);
            this.lsbLuaChon.TabIndex = 3;
            // 
            // btnChuyen1
            // 
            this.btnChuyen1.Location = new System.Drawing.Point(260, 60);
            this.btnChuyen1.Name = "btnChuyen1";
            this.btnChuyen1.Size = new System.Drawing.Size(75, 25);
            this.btnChuyen1.TabIndex = 4;
            this.btnChuyen1.Text = ">";
            this.btnChuyen1.UseVisualStyleBackColor = true;
            this.btnChuyen1.Click += new System.EventHandler(this.btnChuyen1_Click);
            // 
            // btnChuyenAll
            // 
            this.btnChuyenAll.Location = new System.Drawing.Point(260, 95);
            this.btnChuyenAll.Name = "btnChuyenAll";
            this.btnChuyenAll.Size = new System.Drawing.Size(75, 25);
            this.btnChuyenAll.TabIndex = 5;
            this.btnChuyenAll.Text = ">>";
            this.btnChuyenAll.UseVisualStyleBackColor = true;
            this.btnChuyenAll.Click += new System.EventHandler(this.btnChuyenAll_Click);
            // 
            // btnXoa1
            // 
            this.btnXoa1.Location = new System.Drawing.Point(260, 130);
            this.btnXoa1.Name = "btnXoa1";
            this.btnXoa1.Size = new System.Drawing.Size(75, 25);
            this.btnXoa1.TabIndex = 6;
            this.btnXoa1.Text = "<";
            this.btnXoa1.UseVisualStyleBackColor = true;
            this.btnXoa1.Click += new System.EventHandler(this.btnXoa1_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(260, 165);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(75, 25);
            this.btnXoaAll.TabIndex = 7;
            this.btnXoaAll.Text = "<<";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // Form7
            // 
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa1);
            this.Controls.Add(this.btnChuyenAll);
            this.Controls.Add(this.btnChuyen1);
            this.Controls.Add(this.lsbLuaChon);
            this.Controls.Add(this.lsbDanhSach);
            this.Controls.Add(this.lblLuaChon);
            this.Controls.Add(this.lblDanhSach);
            this.Name = "Form7";
            this.Text = "Bài 7: ListBox chuyển dữ liệu";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblLuaChon;
        private System.Windows.Forms.ListBox lsbDanhSach;
        private System.Windows.Forms.ListBox lsbLuaChon;
        private System.Windows.Forms.Button btnChuyen1;
        private System.Windows.Forms.Button btnChuyenAll;
        private System.Windows.Forms.Button btnXoa1;
        private System.Windows.Forms.Button btnXoaAll;
    }
}

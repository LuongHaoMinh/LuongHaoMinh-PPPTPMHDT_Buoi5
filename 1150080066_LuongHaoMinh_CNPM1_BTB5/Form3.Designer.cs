namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    partial class Form3
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblKeyboard = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnRing = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lvLog = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 20);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(90, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(180, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // lblKeyboard
            // 
            this.lblKeyboard.AutoSize = true;
            this.lblKeyboard.Location = new System.Drawing.Point(20, 55);
            this.lblKeyboard.Name = "lblKeyboard";
            this.lblKeyboard.Size = new System.Drawing.Size(56, 13);
            this.lblKeyboard.TabIndex = 2;
            this.lblKeyboard.Text = "Keyboard:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(30, 80);
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(80, 80);
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(130, 80);
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(30, 130);
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(80, 130);
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(130, 130);
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(30, 180);
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 180);
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(130, 180);
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(230, 80);
            this.btnClear.Size = new System.Drawing.Size(60, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(230, 130);
            this.btnEnter.Size = new System.Drawing.Size(60, 40);
            this.btnEnter.Text = "Enter";
            this.btnEnter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnRing
            // 
            this.btnRing.Location = new System.Drawing.Point(230, 180);
            this.btnRing.Size = new System.Drawing.Size(60, 40);
            this.btnRing.Text = "RING";
            this.btnRing.BackColor = System.Drawing.Color.Red;
            this.btnRing.ForeColor = System.Drawing.Color.White;
            this.btnRing.UseVisualStyleBackColor = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 240);
            this.lblLog.Text = "Login Log:";
            // 
            // lvLog
            // 
            this.lvLog.Location = new System.Drawing.Point(20, 260);
            this.lvLog.Size = new System.Drawing.Size(270, 150);
            this.lvLog.View = System.Windows.Forms.View.Details;
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colTime, this.colGroup, this.colResult
            });
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            // 
            // colTime
            // 
            this.colTime.Text = "Ngày giờ";
            this.colTime.Width = 100;
            // 
            // colGroup
            // 
            this.colGroup.Text = "Nhóm";
            this.colGroup.Width = 90;
            // 
            // colResult
            // 
            this.colResult.Text = "Kết quả";
            this.colResult.Width = 70;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.lvLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnRing);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblKeyboard);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Name = "Form3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnRing;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colGroup;
        private System.Windows.Forms.ColumnHeader colResult;
    }
}

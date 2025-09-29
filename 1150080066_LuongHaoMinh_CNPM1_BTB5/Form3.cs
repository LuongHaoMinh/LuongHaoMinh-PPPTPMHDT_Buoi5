using System;
using System.Windows.Forms;

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtPassword.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text.Trim();
            string group = "";
            bool accepted = false;

            if (pass == "1496" || pass == "2673")
            {
                group = "Phát triển công nghệ";
                accepted = true;
            }
            else if (pass == "7462")
            {
                group = "Nghiên cứu viên";
                accepted = true;
            }
            else if (pass == "8884" || pass == "3842" || pass == "3383")
            {
                group = "Thiết kế mô hình";
                accepted = true;
            }

            string log = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - ";

            if (accepted)
            {
                log += $"{group} - CHẤP NHẬN";
                MessageBox.Show("Mật khẩu hợp lệ. Truy cập được chấp nhận.", "Thông báo");
            }
            else
            {
                log += "TỪ CHỐI";
                MessageBox.Show("Sai mật khẩu. Truy cập bị từ chối.", "Thông báo");
            }

            lvLog.Items.Add(log);
            txtPassword.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

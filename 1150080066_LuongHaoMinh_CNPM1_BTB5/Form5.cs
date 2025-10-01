using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhongKhamNhaKhoa
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string user = txtUsername.Text.Trim();
                string pass = txtPassword.Text.Trim();

                // Ở đây bạn có thể kiểm tra với DB hoặc giá trị cứng
                if (user == "admin" && pass == "123")
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Tên đăng nhập không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Mật khẩu không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
}

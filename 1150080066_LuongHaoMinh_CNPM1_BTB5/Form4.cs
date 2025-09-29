using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PhongKhamNhaKhoa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            double thanhTien = 0;

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (chkLayCaoRang.Checked)
                    thanhTien += 50000;

                if (chkTayTrang.Checked)
                    thanhTien += 100000;


                if (chkHanRang.Checked)
                    thanhTien += (int)nupHanRang.Value * 100000;

                if (chkBeRang.Checked)
                    thanhTien += (int)nupBeRang.Value * 10000;

                if (chkBocRang.Checked)
                    thanhTien += (int)nupBocRang.Value * 1000000;

                txtThanhTien.Text = thanhTien.ToString("N0") + " VNĐ";
            }
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                e.Cancel = true;
                txtTenKH.Focus();
                err.SetError(txtTenKH, "Tên khách hàng không được để trống!");
            }
            else
            {
                e.Cancel = false;
                err.SetError(txtTenKH, null);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

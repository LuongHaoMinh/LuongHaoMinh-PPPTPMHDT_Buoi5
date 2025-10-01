using System;
using System.Windows.Forms;

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtA.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a - b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                txtKetQua.Text = (a * b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());

                if (b == 0)
                {
                    MessageBox.Show("Mẫu số không được phép bằng 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtB.Clear();
                    txtB.Focus();
                    return;
                }

                txtKetQua.Text = (a / b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKetQua.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

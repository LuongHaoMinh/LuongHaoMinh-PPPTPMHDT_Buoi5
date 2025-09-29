using System;
using System.Windows.Forms;

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
            txtInput.Focus();
        }

        // Nhập số bằng nút
        private void btnNhap_Click(object sender, EventArgs e)
        {
            AddNumber();
        }

        // Nhập số bằng phím Enter
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddNumber();
                e.SuppressKeyPress = true; // tránh beep
            }
        }

        // Hàm chung để thêm số vào listbox
        private void AddNumber()
        {
            int a;
            string num = txtInput.Text.Trim();
            if (int.TryParse(num, out a))
            {
                lsbDaySo.Items.Add(a);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không phải số nguyên! Hãy nhập lại!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        // Nút: Tăng mỗi phần tử lên 2
        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = 0; i < lsbDaySo.Items.Count; i++)
                {
                    lsbDaySo.Items[i] = (int)lsbDaySo.Items[i] + 2;
                }
            }
        }

        // Nút: Chọn số chẵn đầu tiên
        private void btnChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = 0; i < lsbDaySo.Items.Count; i++)
                {
                    if ((int)lsbDaySo.Items[i] % 2 == 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        // Nút: Chọn số lẻ cuối
        private void btnLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
                {
                    if ((int)lsbDaySo.Items[i] % 2 != 0)
                    {
                        lsbDaySo.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        // Nút: Xóa phần tử đang chọn
        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else if (lsbDaySo.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn số cần xóa!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (lsbDaySo.SelectedIndex != -1)
                {
                    lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
                }
            }
        }

        // Nút: Xóa phần tử đầu tiên
        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                lsbDaySo.Items.RemoveAt(0);
            }
        }

        // Nút: Xóa phần tử cuối cùng
        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0)
            {
                MessageBox.Show("Dãy số đang trống. Vui lòng nhập dữ liệu!",
                    "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
            }
        }

        // Nút: Xóa toàn bộ dãy số
        private void btnXoaDaySo_Click(object sender, EventArgs e)
        {
            lsbDaySo.Items.Clear();
        }

        // Nút: Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thoát?",
                "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

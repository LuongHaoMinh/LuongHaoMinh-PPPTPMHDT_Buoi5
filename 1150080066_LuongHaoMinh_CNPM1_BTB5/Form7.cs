using System;
using System.Windows.Forms;

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu mẫu vào listbox trái
            lsbDanhSach.Items.AddRange(new object[] {
            });
        }

        // > chuyển các item được chọn từ trái sang phải
        private void btnChuyen1_Click(object sender, EventArgs e)
        {
            while (lsbDanhSach.SelectedItems.Count > 0)
            {
                var item = lsbDanhSach.SelectedItems[0];
                lsbLuaChon.Items.Add(item);
                lsbDanhSach.Items.Remove(item);
            }
        }

        // >> chuyển tất cả từ trái sang phải
        private void btnChuyenAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbDanhSach.Items)
            {
                lsbLuaChon.Items.Add(item);
            }
            lsbDanhSach.Items.Clear();
        }

        // < chuyển các item được chọn từ phải sang trái
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            while (lsbLuaChon.SelectedItems.Count > 0)
            {
                var item = lsbLuaChon.SelectedItems[0];
                lsbDanhSach.Items.Add(item);
                lsbLuaChon.Items.Remove(item);
            }
        }

        // << chuyển toàn bộ từ phải sang trái
        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lsbLuaChon.Items)
            {
                lsbDanhSach.Items.Add(item);
            }
            lsbLuaChon.Items.Clear();
        }

        private void lsbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace _1150080066_LuongHaoMinh_CNPM1_BTB5
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ✅ Kiểm tra tên Form chính xác
            Application.Run(new Form7());
        }
    }
}

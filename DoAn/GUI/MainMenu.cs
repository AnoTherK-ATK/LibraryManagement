using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.GUI.YeuCau1;
using DoAn.GUI.YeuCau2;
using DoAn.GUI.YeuCau3;
using DoAn.GUI.YeuCau4;
using DoAn.GUI.YeuCau5;


namespace DoAn
{
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void YC1btn_Click(object sender, EventArgs e)
        {
            new YeuCau1().Show();
        }

        private void TimNhanVienBtn_Click(object sender, EventArgs e)
        {
            new GUI_TimNhanVien().Show();
        }

        private void UpdateNhanVienBtn_Click(object sender, EventArgs e)
        {
            new GUI_CapNhatNhanVien().Show();
        }

        private void DelNhanVienBtn_Click(object sender, EventArgs e)
        {
            new GUI_XoaNhanVien().Show();
        }

        private void YeuCau2Btn_Click(object sender, EventArgs e)
        {
            new YeuCau2().Show();
        }

        private void TimTheDocGiaBtn_Click(object sender, EventArgs e)
        {
            new GUI_TimTheDocGia().Show();

        }

        private void UpdateTheDocGiaBtn_Click(object sender, EventArgs e)
        {
            new GUI_CapNhatTheDocGia().Show();

        }

        private void DelDocGiaBtn_Click(object sender, EventArgs e)
        {
            new GUI_XoaTheDocGia().Show();
        }

        private void TiepNhanSachMoiBtn_Click(object sender, EventArgs e)
        {
            new YeuCau3().Show();
        }

        private void TimSachBtn_Click(object sender, EventArgs e)
        {
            new YeuCau4().Show();
        }

        private void CapNhatSachBtn_Click(object sender, EventArgs e)
        {
            new GUI_CapNhatSach().Show();
        }

        private void XoaSachBtn_Click(object sender, EventArgs e)
        {
            new GUI_XoaSach().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new YeuCau5().Show();
        }
    }
}

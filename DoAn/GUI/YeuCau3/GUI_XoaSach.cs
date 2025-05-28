using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.BUS;
using DoAn.DTO;

namespace DoAn.GUI.YeuCau3
{
    public partial class GUI_XoaSach: Form
    {

        BUS_Sach BUS_Sach = new BUS_Sach();
        DTO_Sach Sach;
        public GUI_XoaSach()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (YeuCau4.YeuCau4 form = new YeuCau4.YeuCau4())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string maSach = form.MaSachReturn;
                    MaSachTxt.Text = maSach;
                    Sach = BUS_Sach.LayThongTinSach(maSach);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {Sach.TenSach} không?", "Xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSach = MaSachTxt.Text.Trim();
                if (BUS_Sach.XoaSach(maSach))
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

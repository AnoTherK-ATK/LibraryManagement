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

namespace DoAn.GUI.YeuCau1
{
    public partial class GUI_XoaNhanVien: Form
    {

        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        DTO_NhanVien NhanVien;
        public GUI_XoaNhanVien()
        {
            InitializeComponent();
        }

        private void TimNhanVienBtn_Click(object sender, EventArgs e)
        {
            using (GUI_TimNhanVien form = new GUI_TimNhanVien())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string maNV = form.MaNVReturn;
                    MaNhanVienTxt.Text = maNV;
                    NhanVien = BUS_NhanVien.LayThongTinNhanVien(maNV);
                }
            }
        }

        private void DeleteBtb_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa {NhanVien.TenNhanVien} không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maNV = MaNhanVienTxt.Text.Trim();
                if (BUS_NhanVien.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

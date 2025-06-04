using DoAn.BUS;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.GUI.YeuCau7
{
    public partial class GUI_TimPhieuThu: Form
    {
        BUS_PhieuThuTienPhat BUS_PhieuThuTienPhat = new BUS_PhieuThuTienPhat();
        public GUI_TimPhieuThu()
        {
            InitializeComponent();
        }

        private void GUI_TimPhieuMuon_Load(object sender, EventArgs e)
        {

        }

        private void TimPM_Click(object sender, EventArgs e)
        {
            Phieuthutien.Rows.Clear();
            string maPM = MaPM_text.Text.Trim();
            string maDocGia = Name_text.Text.ToLower().Trim();
            List<DTO_PhieuThuTienPhat> ListDTO_PhieuThuTienPhat = BUS_PhieuThuTienPhat.LayTatCaPhieuThu(maPM, maDocGia);
            foreach (var phieuthu in ListDTO_PhieuThuTienPhat)
            {
                int rowIndex = Phieuthutien.Rows.Add();
                DataGridViewRow row = Phieuthutien.Rows[rowIndex];
                row.Cells["maPhieuThu"].Value = phieuthu.MaPhieuThuTienPhat;
                row.Cells["maNhanVien"].Value = phieuthu.MaNhanVien;
                row.Cells["maDocGia"].Value = phieuthu.MaDocGia;

            }
        }
    }
}

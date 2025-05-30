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
namespace DoAn.GUI.YeuCau5
{
    public partial class GUI_TimPhieuMuon : Form
    {
        private BUS_PhieuMuonSach PhieuMuonSach = new BUS_PhieuMuonSach();
        private BUS_ThongTinSachMuon ThongTinSachMuon = new BUS_ThongTinSachMuon();
        public GUI_TimPhieuMuon()
        {
            InitializeComponent();
            SetUpDataGridView();
            NgayMuon.Format = DateTimePickerFormat.Custom;
            NgayMuon.CustomFormat = " ";
        }
        private void SetUpDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MaPhieuMuon", "Mã phiếu mượn");
            dataGridView1.Columns.Add("MaSach", "Mã sách");
            dataGridView1.Columns.Add("MaDocGia", "Mã độc giả");
            dataGridView1.Columns.Add("NgayMuon", "Ngày mượn");
            dataGridView1.Columns.Add("NgayTra", "Ngày trả");

            dataGridView1.Columns.Add("TrangThai", "Trạng thái");

            // set up size for columns
            dataGridView1.Columns["MaPhieuMuon"].Width = 150;
            dataGridView1.Columns["MaSach"].Width = 100;
            dataGridView1.Columns["MaDocGia"].Width = 120;
            dataGridView1.Columns["NgayMuon"].Width = 120;
            dataGridView1.Columns["NgayTra"].Width = 120;
            dataGridView1.Columns["TrangThai"].Width = 100;

        }
        private void TimPM_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string maPM = MaPM_text.Text.Trim();
            string hoTen = Name_text.Text.ToLower().Trim();
            DateTime? ngayMuon = null;
            if (NgayMuon.CustomFormat != " ")
            {
                ngayMuon = NgayMuon.Value;
            }
            var listPhieuMuon = PhieuMuonSach.TimPhieuMuonSach(maPM, hoTen, ngayMuon);
            foreach (var phieuMuon in listPhieuMuon)
            {
                List<string> sach = ThongTinSachMuon.LayTatCaSachTheoPhieuMuon(phieuMuon.MaPhieuMuonSach);
                foreach(var s in sach)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["MaPhieuMuon"].Value = phieuMuon.MaPhieuMuonSach;
                    row.Cells["MaDocGia"].Value = phieuMuon.MaDocGia;
                    row.Cells["NgayMuon"].Value = phieuMuon.ngayMuon.ToString("dd/MM/yyyy");
                    row.Cells["NgayTra"].Value = phieuMuon.hanTraSachStr;
                    row.Cells["TrangThai"].Value = ThongTinSachMuon.LayTrangThaiPhieuMuon(phieuMuon.MaPhieuMuonSach);
                    row.Cells["MaSach"].Value = s;
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NgayMuon.CustomFormat = " ";
            MaPM_text.Text = string.Empty;
            Name_text.Text = string.Empty;
            dataGridView1.Rows.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValueChange(object sender, EventArgs e)
        {
            NgayMuon.Format = DateTimePickerFormat.Custom;
            NgayMuon.CustomFormat = "dd/MM/yyyy";
        }
    }
}

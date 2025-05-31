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

namespace DoAn.GUI.YeuCau6
{
    public partial class YeuCau6: Form
    {
        BUS_PhieuMuonSach BUS_PhieuMuonSach = new BUS_PhieuMuonSach();
        BUS_ThongTinSachMuon BUS_ThongTinSachMuon = new BUS_ThongTinSachMuon();
        BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        BUS_Sach BUS_Sach = new BUS_Sach();
        public YeuCau6()
        {
            InitializeComponent();
        }

        private void YeuCau6_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTenDocGia();
            NgayTradate.Value = DateTime.Now;
            Danhsachsachmuon.RowsAdded += addRow;
            //Danhsachsachmuon.CellValidating += Danhsachsachmuon_CellValidating;

        }

        private void HienThiDanhSachTenDocGia()
        {
            TenDocGiaCombo.SelectedIndexChanged -= TenDocGiaCombo_SelectedIndexChanged;
            Danhsachsachmuon.Rows[0].Cells["stt"].Value = 1;
            List<string> listMaDocGia = BUS_PhieuMuonSach.LayTatCaMaDocGia();
            List<string> listTenDocGia = BUS_TheDocGia.LayTatCaTenDocGiaTheoMaDocGia(listMaDocGia);
            var sortedList = listTenDocGia
                .OrderBy(ten => ten)
                .ToList();
            TenDocGiaCombo.DataSource = null;
            TenDocGiaCombo.DataSource = sortedList;
            TenDocGiaCombo.SelectedIndex = -1;
            TenDocGiaCombo.SelectedIndexChanged += TenDocGiaCombo_SelectedIndexChanged;

        }

        private void TenDocGiaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TenDocGia = TenDocGiaCombo.SelectedItem?.ToString();
            string MaDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);
            DTO_TheDocGia DTO_TheDocGia = BUS_TheDocGia.LayThongTinTheDocGia(MaDocGia);
            TongNoTxt.Text = DTO_TheDocGia.TongNo.ToString();
            HienThiDanhSachSach();
        }

        private void HienThiDanhSachSach()
        {
            string maDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGiaCombo.SelectedItem.ToString());
            List<string> listmaPM = BUS_PhieuMuonSach.LayTatCaMaPMTheoDocGia2(maDocGia);
            List<string> listMaSach = BUS_ThongTinSachMuon.LayTatCaSachTheoListPhieuMuon(listmaPM);
            List<string> listTenSach = BUS_Sach.LayTenSachTheoListMaSach(listMaSach);
            tenSach.DataSource = listTenSach;

        }
        private void addRow(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int rowIndex = e.RowIndex;
            Danhsachsachmuon.Rows[rowIndex].Cells["stt"].Value = rowIndex + 1;
        }

        private void Danhsachsachmuon_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (Danhsachsachmuon.Columns[e.ColumnIndex].Name == "tenSach")
            {
                string newValue = e.FormattedValue?.ToString();
                if (string.IsNullOrEmpty(newValue))
                    return;

                // Kiểm tra trùng lặp ở các hàng khác
                for (int i = 0; i < Danhsachsachmuon.Rows.Count; i++)
                {
                    if (i == e.RowIndex) continue; // Bỏ qua hàng hiện tại
                    var cell = Danhsachsachmuon.Rows[i].Cells["tenSach"];
                    if (cell.Value != null && cell.Value.ToString() == newValue)
                    {
                        MessageBox.Show("sách này đã được chọn ở hàng khác. Vui lòng chọn mã khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void Danhsachsachmuon_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            string TenSach = Danhsachsachmuon.Rows[e.RowIndex].Cells["tenSach"].Value?.ToString();
            string MaSach = BUS_Sach.LayMaSachTheoTenSach(TenSach);
            string MaPhieuMuonSach = BUS_ThongTinSachMuon.LayMaPMTheoMaSach(MaSach);
            DTO_PhieuMuonSach DTO_PhieuMuonSach = BUS_PhieuMuonSach.LayThongTinPhieuMuon(MaPhieuMuonSach);
            Danhsachsachmuon.Rows[e.RowIndex].Cells["ngayMuon"].Value = DTO_PhieuMuonSach.ngayMuonStr;
            Danhsachsachmuon.Rows[e.RowIndex].Cells["hanTraSach"].Value = DTO_PhieuMuonSach.hanTraSachStr;

        }
    }
}

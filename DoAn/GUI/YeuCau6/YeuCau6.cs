using DoAn.BUS;
using DoAn.DTO;
using DoAn.GUI.YeuCau5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace DoAn.GUI.YeuCau6
{
    public partial class YeuCau6 : Form
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
            TienPhatKiNayTxt.Text = "0";
            TenDocGiaCombo.SelectedIndexChanged += TenDocGiaCombo_SelectedIndexChanged;

        }



        private void TenDocGiaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongNo();
            Danhsachsachmuon.Enabled = true;
        }
        private void TinhTongNo( float tongNo = 0)
        {
            string TenDocGia = TenDocGiaCombo.SelectedItem?.ToString();
            string MaDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);
            DTO_TheDocGia DTO_TheDocGia = BUS_TheDocGia.LayThongTinTheDocGia(MaDocGia);
            TongNoTxt.Text = (DTO_TheDocGia.TongNo + tongNo).ToString();
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
            if (TenSach != null)
            {   
                TenDocGiaCombo.Enabled = false;
                string MaSach = BUS_Sach.LayMaSachTheoTenSach(TenSach);
                string MaPhieuMuonSach = BUS_ThongTinSachMuon.LayMaPMTheoMaSach(MaSach);
                DTO_PhieuMuonSach DTO_PhieuMuonSach = BUS_PhieuMuonSach.LayThongTinPhieuMuon(MaPhieuMuonSach);
                Danhsachsachmuon.Rows[e.RowIndex].Cells["ngayMuon"].Value = DTO_PhieuMuonSach.ngayMuonStr;
                Danhsachsachmuon.Rows[e.RowIndex].Cells["hanTraSach"].Value = DTO_PhieuMuonSach.hanTraSachStr;
                
                DateTime date = DateTime.ParseExact(DTO_PhieuMuonSach.hanTraSachStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TimeSpan timeLate = DateTime.Now - date;
                int soNgayTre = (int)timeLate.TotalDays;
                if (soNgayTre < 0)
                {
                    soNgayTre = 0;
                }
                float tienPhatTre = soNgayTre * BUS_ThamSo.LayTienPhatTraTreMoiNgay();
                Danhsachsachmuon.Rows[e.RowIndex].Cells["tienPhat"].Value = tienPhatTre.ToString();
                DateTime dateMuon = DateTime.ParseExact(DTO_PhieuMuonSach.ngayMuonStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int SoNgayMuon = (int)(DateTime.Now - dateMuon).TotalDays;
                Danhsachsachmuon.Rows[e.RowIndex].Cells["soNgayMuon"].Value = SoNgayMuon.ToString();
                TienPhatKiNayTxt.Text = (float.Parse(TienPhatKiNayTxt.Text) + tienPhatTre).ToString();
                TienNoTxt.Enabled = true;
                

            }
        }

        private void TienNoTxt_TextChanged(object sender, EventArgs e)
        {
            //float tienNo;
            if (float.Parse(TienNoTxt.Text) > float.Parse(TienPhatKiNayTxt.Text))
            {
                MessageBox.Show("Số tiền nợ vượt  quá tiền phạt kì này. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TienNoTxt.Text = "0";
            }
            else
            {
                TinhTongNo(float.Parse(TienNoTxt.Text));
            }
        }

        private void ClearContent()
        {
            TenDocGiaCombo.SelectedIndex = -1;
            HienThiDanhSachTenDocGia();
            NgayTradate.Value = DateTime.Now;
            Danhsachsachmuon.Rows.Clear();
            Danhsachsachmuon.RowsAdded += addRow;
            TienPhatKiNayTxt.Text = "0";
            TongNoTxt.Text = "";
            TienNoTxt.Text = "0";
            TenDocGiaCombo.Enabled = true;
            Danhsachsachmuon.Enabled = false;
            TienNoTxt.Enabled = false;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string TenDocGia = TenDocGiaCombo.SelectedItem?.ToString();
            string MaDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);


            try
            {
                if (Danhsachsachmuon.Rows.Cast<DataGridViewRow>().Count(row => !row.IsNewRow) == 0)
                {
                    MessageBox.Show("Vui lòng thêm sách  trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (BUS_TheDocGia.CapNhatTongNo(MaDocGia, float.Parse(TongNoTxt.Text)))
                     {
                        bool toend = false;
                        foreach (DataGridViewRow row in Danhsachsachmuon.Rows)
                        {
                            //if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng

                            var cellValue = row.Cells["tenSach"].Value;
                            if (cellValue != null)
                            {
                                string maSach = BUS_Sach.LayMaSachTheoTenSach(cellValue.ToString());
                                string trangThai = "Đã Trả";
                                List<string> listmaPM = BUS_PhieuMuonSach.LayTatCaMaPMTheoDocGia2(MaDocGia);
                                foreach (string maPM in listmaPM)
                                {
                                    List<string> listMaSach = BUS_ThongTinSachMuon.LayTatCaSachTheoPhieuMuon(maPM);
                                    if (listMaSach.Contains(maSach))
                                    {
                                        if ((BUS_ThongTinSachMuon.CapNhatNgayTraSach(maPM, maSach, trangThai)))
                                        {
                                            if (BUS_Sach.CapNhatTinhTrangSach(maSach, "Chưa mượn"))
                                            {

                                                toend = true;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                            
                        }
                        if (toend)
                        {
                            MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            
                        //
                    }

                     }
                    else
                    {
                        MessageBox.Show("Trả sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi Thêm phiếu mượn sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearContent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace DoAn.GUI.YeuCau2
{
    public partial class YeuCau2 : Form
    {
        private BUS_NhanVien busNhanVien = new BUS_NhanVien();
        private BUS_LoaiBoPhan busLoaiBoPhan = new BUS_LoaiBoPhan();
        private BUS_LoaiDocGia busLoaiDocGia = new BUS_LoaiDocGia();
        private BUS_ThamSo busThamSo = new BUS_ThamSo();
        private BUS_TheDocGia busTheDocGia = new BUS_TheDocGia();
        private bool check_Open = false; 

        public YeuCau2()
        {
            InitializeComponent();
        }



        private void YeuCau2_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMaNhanVien();
            HienThiDanhSachMaLoaiDocGia();
            CapNhatNgayLapTheVaNgayHetHan();
            HienThiMaTheDocGiaMoi();
        }
            

        private void HienThiDanhSachMaNhanVien()
        {
            List<string> listMaNhanVien = busNhanVien.LayTatCaMaNhanVien();
            var sortedList = listMaNhanVien
            .OrderBy(ma => int.Parse(ma.Substring(2))) 
            .ToList();
            MaNhanVienCombo.DataSource = null;
            MaNhanVienCombo.DataSource = sortedList;
            MaNhanVienCombo.SelectedIndex = -1; 
        }

        private void HienThiDanhSachMaLoaiDocGia()
        {
            List<DTO_LoaiDocGia> listLoaiDocGia = busLoaiDocGia.LayDanhSachLoaiDocGia();
            LoaiDocGiaCombo.DataSource = listLoaiDocGia;
            LoaiDocGiaCombo.DisplayMember = "TenLoaiDocGia";
            LoaiDocGiaCombo.ValueMember = "MaLoaiDocGia";
        }

        private void CapNhatNgayLapTheVaNgayHetHan()
        {
            DateTime ngayLapThe = DateTime.Now;
            NgayLapTheTxt.Text = ngayLapThe.ToString("dd/MM/yyyy");
            int giaTriThe = busThamSo.LayGiaTriThe();
            DateTime ngayHetHan = ngayLapThe.AddMonths(giaTriThe);
            NgayHetHanTxt.Text = ngayHetHan.ToString("dd/MM/yyyy");
        }


        private void MaNhanVienCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!check_Open || MaNhanVienCombo.SelectedIndex == -1)
            {
                check_Open = true;
                return;
            }
            string maNhanVien = MaNhanVienCombo.Text;

            DTO_NhanVien nhanVien = busNhanVien.LayThongTinNhanVien(maNhanVien);
            if (nhanVien != null)
            {
                string TenBoPhan = busLoaiBoPhan.LayTenBoPhan(nhanVien.MaBoPhanNhanVien);
                bool QuyenLapThe = busLoaiBoPhan.LayQuyenLapThe(nhanVien.MaBoPhanNhanVien);
                string QuyenLapTheStr = QuyenLapThe ? "Có" : "Không";
                TenNhanVienTxt.Text = nhanVien.TenNhanVien;
                TenBoPhanTxt.Text = TenBoPhan;
                QuyenLapTheTxt.Text = QuyenLapTheStr;

                if (QuyenLapThe == false )
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("Nhân viên hiện tại không có quyền lập thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
                    HoTenDocGiaTxt.ReadOnly = true;
                    NgaySinhSelector.Enabled = false;
                    LoaiDocGiaCombo.Enabled = false;
                    EmailTxt.ReadOnly = true;
                    DiaChiTxt.ReadOnly = true;

                    HoTenDocGiaTxt.Text = string.Empty;
                    NgaySinhSelector.Value = DateTime.Now;
                    LoaiDocGiaCombo.SelectedIndex = -1; 
                    EmailTxt.Text = string.Empty;
                    DiaChiTxt.Text = string.Empty;

                }
                else
                {
                    HoTenDocGiaTxt.ReadOnly = false;
                    NgaySinhSelector.Enabled = true;
                    LoaiDocGiaCombo.Enabled = true;
                    EmailTxt.ReadOnly = false;
                    DiaChiTxt.ReadOnly = false;
                    
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
             DTO_TheDocGia theDocGia = new DTO_TheDocGia(
             MaDocGiaTxt.Text,
             HoTenDocGiaTxt.Text,
             DiaChiTxt.Text,
             NgaySinhSelector.Value.ToString("dd/MM/yyyy"),
             EmailTxt.Text,
             NgayLapTheTxt.Text,
             NgayHetHanTxt.Text,
             LoaiDocGiaCombo.SelectedValue.ToString(),
             MaNhanVienCombo.SelectedItem.ToString()
         );
            DateTime ngayHienHanh = DateTime.Today;
            int tuoi = ngayHienHanh.Year - NgaySinhSelector.Value.Year;
            if (string.IsNullOrEmpty(theDocGia.MaDocGia) || string.IsNullOrEmpty(theDocGia.HoTenDocGia) || string.IsNullOrEmpty(theDocGia.DiaChiDocGia) || string.IsNullOrEmpty(theDocGia.EmailDocGia) || string.IsNullOrEmpty(theDocGia.MaLoaiDocGia) || string.IsNullOrEmpty(theDocGia.MaNhanVien))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (tuoi >= 18 && tuoi <= 55)
            {
                // Tuổi hợp lệ
            }
            else
            {
                MessageBox.Show("Tuổi của độc giả phải từ 18 đến 55 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (busTheDocGia.ThemTheDocGia(theDocGia))
                {
                    MessageBox.Show("Thêm thẻ độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    ClearContent();
                }
                else
                {
                    MessageBox.Show("Thêm thẻ độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm thẻ độc giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiMaTheDocGiaMoi()
        {
            List<DTO_TheDocGia> listTheDocGia = busTheDocGia.LayDanhSachTheDocGia();
            if (listTheDocGia.Count > 0)
            {
                string maCuoi = listTheDocGia.Last().MaDocGia;
                int soThuTu = int.Parse(maCuoi.Substring(3)) + 1; 
                MaDocGiaTxt.Text = $"TDG{soThuTu:D4}"; 
            }
            else
            {
                MaDocGiaTxt.Text = "TDG0001"; 
            }
        }

        private void ClearContent()
        {
            MaDocGiaTxt.Text = string.Empty;
            HoTenDocGiaTxt.Text = string.Empty;
            DiaChiTxt.Text = string.Empty;
            NgaySinhSelector.Value = new DateTime(1980, 1, 1);
            EmailTxt.Text = string.Empty;
            LoaiDocGiaCombo.SelectedIndex = -1;
            MaNhanVienCombo.SelectedIndex = -1;
            HienThiMaTheDocGiaMoi();
        }

        private void TheDocGiaMoiBtn_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

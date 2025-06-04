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
    public partial class YeuCau3: Form
    {
        BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_Sach BUS_Sach = new BUS_Sach();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        BUS_TheLoai BUS_TheLoai = new BUS_TheLoai();
        public YeuCau3()
        {
            InitializeComponent();
        }

        private void YeuCau3_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMaNhanVien();
            HienThiDanhSachTheLoai();
            HienThiMaSachMoi();
            HienThiNamXuatBan();
        }

        private void HienThiNamXuatBan()
        {
            int namXuatBan = NamXuatBanSelector.Value.Year;
            int thoiGianNhapSachToiDa = BUS_ThamSo.LayThoiGianNhapSachToiDa();
            if (DateTime.Now.Year - namXuatBan > thoiGianNhapSachToiDa)
            {
                MessageBox.Show($"Sách có năm xuất bản quá cũ. Vui lòng nhập sách có năm xuất bản trong vòng {thoiGianNhapSachToiDa} năm qua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SachQuaHanNhapTxt.Text = "Có";
            }
            else
            {
                SachQuaHanNhapTxt.Text = "Không";
            }
        }

        private void HienThiDanhSachMaNhanVien()
        {
            MaNhanVienCombo.SelectedIndexChanged -= MaNhanVienCombo_SelectedIndexChanged;
            List<string> listMaNhanVien = BUS_NhanVien.LayTatCaMaNhanVien();
            var sortedList = listMaNhanVien
            .OrderBy(ma => int.Parse(ma.Substring(2)))
            .ToList();

            MaNhanVienCombo.DataSource = null;
            MaNhanVienCombo.DataSource = sortedList;
            MaNhanVienCombo.SelectedIndex = -1;
            MaNhanVienCombo.SelectedIndexChanged += MaNhanVienCombo_SelectedIndexChanged;
        }

        private void HienThiDanhSachTheLoai()
        {
            List<DTO_TheLoai> listTheLoai = BUS_TheLoai.LayDanhSachTheLoai();
            TheLoaiCombo.DataSource = listTheLoai;
            TheLoaiCombo.DisplayMember = "TenTheLoai";
            TheLoaiCombo.ValueMember = "MaTheLoai";
        }

        private void HienThiMaSachMoi()
        {
            List<DTO_Sach> listSach = BUS_Sach.LayDanhSachSach();
            if (listSach.Count == 0)
            {
                MaSachTxt.Text = "S0001";
            }
            else
            {
                string maSachCuoi = listSach.Last().MaSach;
                int soCuoi = int.Parse(maSachCuoi.Substring(2)) + 1;
                MaSachTxt.Text = "S" + soCuoi.ToString("D4");
            }
        }

        private void MaNhanVienCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhanVien = MaNhanVienCombo.Text;
            DTO_NhanVien nhanVien = BUS_NhanVien.LayThongTinNhanVien(maNhanVien);
            if (nhanVien != null)
            {
                TenNhanVienTxt.Text = nhanVien.TenNhanVien;
                TenBoPhanTxt.Text = BUS_LoaiBoPhan.LayTenBoPhan(nhanVien.MaBoPhanNhanVien);
                QuyeNhanSachTxt.Text = BUS_LoaiBoPhan.LayQuyenNhanSach(nhanVien.MaBoPhanNhanVien) ? "Có" : "Không";
                if(QuyeNhanSachTxt.Text == "Không")
                {
                    if(maNhanVien != "")
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            MessageBox.Show("Nhân viên hiện tại không có quyền nhận sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }));
                    }
                    TenSachTxt.ReadOnly = true;
                    TacGiaTxt.ReadOnly = true;
                    NamXuatBanSelector.Enabled = false;
                    NhaXuatBanTxt.ReadOnly = true;
                    NgayNhapSelector.Enabled = false;
                    TriGiaTxt.ReadOnly = true;
                    TheLoaiCombo.SelectedIndex = -1;
                    TheLoaiCombo.Enabled = false;
                }
                else
                {
                    TenSachTxt.ReadOnly = false;
                    TacGiaTxt.ReadOnly = false;
                    NamXuatBanSelector.Enabled = true;
                    NhaXuatBanTxt.ReadOnly = false;
                    NgayNhapSelector.Enabled = true;
                    TriGiaTxt.ReadOnly = false;
                    TheLoaiCombo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NamXuatBanSelector_ValueChanged(object sender, EventArgs e)
        {
            int namXuatBan = NamXuatBanSelector.Value.Year;
            int thoiGianNhapSachToiDa = BUS_ThamSo.LayThoiGianNhapSachToiDa();
            if (DateTime.Now.Year - namXuatBan > thoiGianNhapSachToiDa)
            {
                MessageBox.Show($"Sách có năm xuất bản quá cũ. Vui lòng nhập sách có năm xuất bản trong vòng {thoiGianNhapSachToiDa} năm qua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SachQuaHanNhapTxt.Text = "Có";
            }
            else
            {
                SachQuaHanNhapTxt.Text = "Không";
            }
        }

        private void ClearContent()
        {
            
            HienThiMaSachMoi();
            TenSachTxt.Clear();
            TacGiaTxt.Clear();
            NhaXuatBanTxt.Clear();
            TriGiaTxt.Clear();
            NgayNhapSelector.Value = DateTime.Now;
            NamXuatBanSelector.Value = DateTime.Now;
            TheLoaiCombo.SelectedIndex = -1;
            //MaNhanVienCombo.SelectedIndex = -1;
            HienThiDanhSachMaNhanVien();
            TenNhanVienTxt.Clear();
            TenBoPhanTxt.Clear();
            QuyeNhanSachTxt.Clear();
        }

        private void TiepNhanSachBtn_Click(object sender, EventArgs e)
        {
            DTO_Sach sach = new DTO_Sach(
                MaSachTxt.Text,
                TenSachTxt.Text,
                TheLoaiCombo.SelectedValue.ToString(),
                TacGiaTxt.Text,
                NamXuatBanSelector.Text,
                NhaXuatBanTxt.Text,
                NgayNhapSelector.Text,
                int.Parse(TriGiaTxt.Text),
                MaNhanVienCombo.SelectedItem.ToString()
            );

            try
            {
                if (BUS_Sach.ThemSach(sach))
                {
                    MessageBox.Show("Tiếp nhận sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    ClearContent();
                }
                else
                {
                    MessageBox.Show("Tiếp nhận sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tiếp nhận sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

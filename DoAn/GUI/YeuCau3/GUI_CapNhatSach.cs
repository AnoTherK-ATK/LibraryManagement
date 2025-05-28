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
    public partial class GUI_CapNhatSach: Form
    {
        BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_Sach BUS_Sach = new BUS_Sach();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        BUS_TheLoai BUS_TheLoai = new BUS_TheLoai();
        private bool ngayNhapSelected = false;
        private bool namXuatBanSelected = false;

        public GUI_CapNhatSach()
        {
            InitializeComponent();
        }

        private void GUI_CapNhatSach_Load(object sender, EventArgs e)
        {
            HienThiDanhSachMaNhanVien();
            HienThiDanhSachTheLoai();
            HienThiNamXuatBan();
            ResetDate();
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

        void ResetDate()
        {
           NgayNhapSelector.Format = DateTimePickerFormat.Custom;
           NgayNhapSelector.CustomFormat = "";

           NamXuatBanSelector.Format = DateTimePickerFormat.Custom;
           NamXuatBanSelector.CustomFormat = "";
        }

        private void MaNhanVienCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhanVien = MaNhanVienCombo.SelectedItem.ToString();
            DTO_NhanVien nhanVien = BUS_NhanVien.LayThongTinNhanVien(maNhanVien);
            if (nhanVien != null)
            {
                TenNhanVienTxt.Text = nhanVien.TenNhanVien;
                TenBoPhanTxt.Text = BUS_LoaiBoPhan.LayTenBoPhan(nhanVien.MaBoPhanNhanVien);
                QuyeNhanSachTxt.Text = BUS_LoaiBoPhan.LayQuyenNhanSach(nhanVien.MaBoPhanNhanVien) ? "Có" : "Không";
                if (QuyeNhanSachTxt.Text == "Không")
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        MessageBox.Show("Nhân viên hiện tại không có quyền nhận sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }));
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

        private void MaSachTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HienThiThongTin();
            }
        }

        private void HienThiThongTin()
        {
            string maSach = MaSachTxt.Text.Trim();
            DTO_Sach sach = BUS_Sach.LayThongTinSach(maSach);
            if (sach != null)
            {
                MaSachTxt.Text = sach.MaSach;
                TenSachTxt.Text = sach.TenSach;
                TacGiaTxt.Text = sach.TacGia;
                NamXuatBanSelector.Value = new DateTime(int.Parse(sach.NamXuatBan), 1, 1);
                NhaXuatBanTxt.Text = sach.NhaXuatBan;
                NgayNhapSelector.Value = sach.ngayNhap;
                TriGiaTxt.Text = sach.TriGia.ToString();
                TheLoaiCombo.SelectedValue = sach.MaTheLoai;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void ClearContent()
        {
            MaSachTxt.Clear();
            TenSachTxt.Clear();
            TacGiaTxt.Clear();
            NhaXuatBanTxt.Clear();
            TriGiaTxt.Clear();
            NgayNhapSelector.Value = DateTime.Now;
            NamXuatBanSelector.Value = DateTime.Now;
            TheLoaiCombo.SelectedIndex = -1;
            MaNhanVienCombo.SelectedIndex = -1;
            TenNhanVienTxt.Clear();
            TenBoPhanTxt.Clear();
            QuyeNhanSachTxt.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TiepNhanSachBtn_Click(object sender, EventArgs e)
        {

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
                    HienThiThongTin();
                }
            }
        }

        private void NgayNhapSelector_ValueChanged(object sender, EventArgs e)
        {

            NgayNhapSelector.CustomFormat = "dd/MM/yyyy";
        }
           
    }
}

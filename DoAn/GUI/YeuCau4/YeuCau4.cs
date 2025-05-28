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

namespace DoAn.GUI.YeuCau4
{
    public partial class YeuCau4: Form
    {
        BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_Sach BUS_Sach = new BUS_Sach();
        BUS_ThamSo BUS_ThamSo = new BUS_ThamSo();
        BUS_TheLoai BUS_TheLoai = new BUS_TheLoai();

        private bool ngayNhapFromSelected = false;
        private bool ngayNhapToSelected = false;
        private bool namXuatBanSelected = false;
        public YeuCau4()
        {
            InitializeComponent();
        }

        private void YeuCau4_Load(object sender, EventArgs e)
        {
            SetupForm();
            HienThiDanhSachMaNhanVien();
            HienThiDanhSachTheLoai();
            TheLoaiCombo.SelectedIndex = -1;
            TenNhanVienCombo.SelectedIndex = -1;
            ResetDate();
        }
        void ResetDate()
        {
            ngayNhapFromSelected = false;
            ngayNhapToSelected = false;
            namXuatBanSelected = false;
            NamXuatBanSelector.Format = DateTimePickerFormat.Custom;
            NamXuatBanSelector.CustomFormat = " ";
            NgayNhapFromSelector.Format = DateTimePickerFormat.Custom;
            NgayNhapFromSelector.CustomFormat = " ";
            NgayNhapToSelector.Format = DateTimePickerFormat.Custom;
            NgayNhapToSelector.CustomFormat = " ";
        }

        private void SetupForm()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("MaSach", "Mã Sách");
            dataGridView1.Columns.Add("TenSach", "Tên Sách");
            dataGridView1.Columns.Add("MaTheLoai", "Thể Loại");
            dataGridView1.Columns.Add("TacGia", "Tác Giả");
            dataGridView1.Columns.Add("NamXuatBan", "Năm Xuất Bản");
            dataGridView1.Columns.Add("NhaXuatBan", "Nhà Xuất Bản");
            dataGridView1.Columns.Add("MaNhanVien", "Nhân Viên");
            dataGridView1.Columns.Add("NgayNhap", "Ngày Nhập");
            dataGridView1.Columns.Add("TriGia", "Trị Giá");

            dataGridView1.Columns["MaSach"].DataPropertyName = "MaSach";
            dataGridView1.Columns["TenSach"].DataPropertyName = "TenSach";
            dataGridView1.Columns["MaTheLoai"].DataPropertyName = "MaTheLoai";
            dataGridView1.Columns["TacGia"].DataPropertyName = "TacGia";
            dataGridView1.Columns["NamXuatBan"].DataPropertyName = "NamXuatBan";
            dataGridView1.Columns["NhaXuatBan"].DataPropertyName = "NhaXuatBan";
            dataGridView1.Columns["MaNhanVien"].DataPropertyName = "MaNhanVien";
            dataGridView1.Columns["NgayNhap"].DataPropertyName = "ngayNhapStr";
            dataGridView1.Columns["TriGia"].DataPropertyName = "TriGia";

            dataGridView1.Columns["MaSach"].Width = 0;
            dataGridView1.Columns["TenSach"].Width = 220;
            dataGridView1.Columns["MaTheLoai"].Width = 120;
            dataGridView1.Columns["TacGia"].Width = 150;
            dataGridView1.Columns["NamXuatBan"].Width = 100;
            dataGridView1.Columns["NhaXuatBan"].Width = 150;
            dataGridView1.Columns["MaNhanVien"].Width = 120;
            dataGridView1.Columns["NgayNhap"].Width = 100;
            dataGridView1.Columns["TriGia"].Width = 100;
        }

        private void HienThiDanhSachMaNhanVien()
        {
            List<DTO_NhanVien> listMaNhanVien = BUS_NhanVien.LayDanhSachNhanVien();

            TenNhanVienCombo.DataSource = listMaNhanVien;
            TenNhanVienCombo.DisplayMember = "TenNhanVien";
            TenNhanVienCombo.ValueMember = "MaNhanVien";
        }

        private void HienThiDanhSachTheLoai()
        {
            List<DTO_TheLoai> listTheLoai = BUS_TheLoai.LayDanhSachTheLoai();
            TheLoaiCombo.DataSource = listTheLoai;
            TheLoaiCombo.DisplayMember = "TenTheLoai";
            TheLoaiCombo.ValueMember = "MaTheLoai";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            MaSachTxt.Clear();
            TenSachTxt.Clear();
            TacGiaTxt.Clear();
            NhaXuatBanTxt.Clear();
            NamXuatBanSelector.Value = DateTime.Now;
            NgayNhapFromSelector.Value = DateTime.Now;
            NgayNhapToSelector.Value = DateTime.Now;
            TriGiaTuTxt.Clear();
            TriGiaDenTxt.Clear();
            TheLoaiCombo.SelectedIndex = -1;
            TenNhanVienCombo.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            ResetDate();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string maSach = MaSachTxt.Text.Trim();
            string tenSach = TenSachTxt.Text.Trim();
            string tacGia = TacGiaTxt.Text.Trim();
            string nhaXuatBan = NhaXuatBanTxt.Text.Trim(); 
            string namXuatBan = NamXuatBanSelector.CustomFormat == " " ? null : NamXuatBanSelector.Value.Year.ToString();
            string maNhanVien = TenNhanVienCombo.SelectedValue?.ToString() ?? "";
            DateTime? ngayNhapTu = ngayNhapFromSelected ? (DateTime?)NgayNhapFromSelector.Value : null;
            DateTime? ngayNhapDen = ngayNhapToSelected ? (DateTime?)NgayNhapToSelector.Value : null;

            int? triGiaTu = string.IsNullOrEmpty(TriGiaTuTxt.Text) ? (int?)null : int.Parse(TriGiaTuTxt.Text);
            int? triGiaDen = string.IsNullOrEmpty(TriGiaDenTxt.Text) ? (int?)null : int.Parse(TriGiaDenTxt.Text);
            List<DTO_Sach> filteredList = BUS_Sach.TimKiemSach(
                maSach, tenSach, tacGia, namXuatBan, nhaXuatBan, maNhanVien,
                TheLoaiCombo.SelectedValue?.ToString() ?? "", ngayNhapTu, ngayNhapDen, triGiaTu, triGiaDen
            );

            foreach(var item in filteredList)
            {
                item.MaTheLoai = BUS_TheLoai.LayTenTheLoai(item.MaTheLoai);
                item.MaNhanVien = BUS_NhanVien.LayTenNhanVien(item.MaNhanVien);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredList;
        }

        public string MaSachReturn { get; set; }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MaSachReturn = row.Cells["MaSach"].Value.ToString();
                Clipboard.SetText( MaSachReturn );
                MessageBox.Show("Đã sao chép mã nhân viên vào bộ nhớ tạm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                if (this.Modal)
                {
                    this.Close();
                }
            }
        }

        private void NamXuatBanSelector_ValueChanged(object sender, EventArgs e)
        {
            if (!namXuatBanSelected)
            {
                NamXuatBanSelector.CustomFormat = "yyyy";
                namXuatBanSelected = true;
            }
          
        }

        private void NgayNhapFromSelector_ValueChanged(object sender, EventArgs e)
        {
           if (!ngayNhapFromSelected)
            {
                NgayNhapFromSelector.CustomFormat = "dd/MM/yyyy";
                ngayNhapFromSelected = true;
            }
           

        }

        private void NgayNhapToSelector_ValueChanged(object sender, EventArgs e)
        {

            if (!ngayNhapToSelected)
            {
                NgayNhapToSelector.CustomFormat = "dd/MM/yyyy";
                ngayNhapToSelected = true;
            }
           
        }    
    }
}

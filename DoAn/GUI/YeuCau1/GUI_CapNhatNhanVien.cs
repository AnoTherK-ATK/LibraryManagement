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
    public partial class GUI_CapNhatNhanVien: Form
    {

        private BUS_LoaiBangCap BUS_LoaiBangCap = new BUS_LoaiBangCap();
        private BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        private BUS_LoaiChucVu BUS_LoaiChucVu = new BUS_LoaiChucVu();
        private BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();

        public GUI_CapNhatNhanVien()
        {
            InitializeComponent();
        }

        private void TimNhanVienBtn_Click(object sender, EventArgs e)
        {
            using (GUI_TimNhanVien form = new GUI_TimNhanVien())
            {
                DialogResult result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    string maNV = form.MaNVReturn;
                    MaNhanVienTxt.Text = maNV;
                }
            }
            HienThiThongTinNhanVien();
        }

        private void HienThiThongTinNhanVien()
        {
            string maNV = MaNhanVienTxt.Text.Trim();
            DTO_NhanVien nhanVien = BUS_NhanVien.LayThongTinNhanVien(maNV);
            if (nhanVien != null)
            {
                MaNhanVienTxt.Text = nhanVien.MaNhanVien;
                TenNhanVienTxt.Text = nhanVien.TenNhanVien;
                SDTTxt.Text = nhanVien.SoDienThoaiNhanVien;
                DiaChiTxt.Text = nhanVien.DiaChiNhanVien;
                NgaySinhSelector.Value = nhanVien.ngaySinhNhanVien;
                BangCapCombo.SelectedValue = nhanVien.MaBangCapNhanVien;
                BoPhanCombo.SelectedValue = nhanVien.MaBoPhanNhanVien;
                ChucVuCombo.SelectedValue = nhanVien.MaChucVuNhanVien;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSachLoaiBangCap()
        {
            List<DTO_LoaiBangCap> listLoaiBangCap = BUS_LoaiBangCap.LayDanhSachLoaiBangCap();
            BangCapCombo.DataSource = listLoaiBangCap;
            BangCapCombo.DisplayMember = "TenLoaiBangCap";
            BangCapCombo.ValueMember = "MaLoaiBangCap";
        }

        private void HienThiDanhSachLoaiBoPhan()
        {
            List<DTO_LoaiBoPhan> listLoaiBoPhan = BUS_LoaiBoPhan.LayDanhSachLoaiBoPhan();
            BoPhanCombo.DataSource = listLoaiBoPhan;
            BoPhanCombo.DisplayMember = "TenLoaiBoPhan";
            BoPhanCombo.ValueMember = "MaLoaiBoPhan";
        }

        private void HienThiDanhSachLoaiChucVu()
        {
            List<DTO_LoaiChucVu> listLoaiChucVu = BUS_LoaiChucVu.LayDanhSachLoaiChucVu();
            ChucVuCombo.DataSource = listLoaiChucVu;
            ChucVuCombo.DisplayMember = "TenLoaiChucVu";
            ChucVuCombo.ValueMember = "MaLoaiChucVu";
        }

        private void GUI_CapNhatNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiBangCap();
            HienThiDanhSachLoaiBoPhan();
            HienThiDanhSachLoaiChucVu();
            BangCapCombo.SelectedIndex = -1;
            BoPhanCombo.SelectedIndex = -1;
            ChucVuCombo.SelectedIndex = -1;
        }

        private void MaNhanVienTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                HienThiThongTinNhanVien();
            }
        }

        private void CapNhatNhanVienBtn_Click(object sender, EventArgs e)
        {
            string maNV = MaNhanVienTxt.Text.Trim();
            string tenNV = TenNhanVienTxt.Text.Trim();
            string sdtNV = SDTTxt.Text.Trim();
            string diaChiNV = DiaChiTxt.Text.Trim();
            string ngaySinhNV = NgaySinhSelector.Text.Trim();
            string bangCapNV = BangCapCombo.SelectedValue?.ToString();
            string boPhanNV = BoPhanCombo.SelectedValue?.ToString();
            string chucVuNV = ChucVuCombo.SelectedValue?.ToString();
            if (BUS_NhanVien.CapNhatNhanVien(new DTO_NhanVien(maNV, tenNV, diaChiNV, ngaySinhNV, sdtNV, bangCapNV, boPhanNV, chucVuNV)))
            {
                MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

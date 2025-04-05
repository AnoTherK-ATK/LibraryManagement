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

namespace DoAn
{
    public partial class YeuCau1: Form
    {
        BUS_LoaiBangCap BUS_LoaiBangCap = new BUS_LoaiBangCap();
        BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        BUS_LoaiChucVu BUS_LoaiChucVu = new BUS_LoaiChucVu();
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        public YeuCau1()
        {
            InitializeComponent();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nhanVien = new DTO_NhanVien(
                MaNhanVienTxt.Text,
                TenNhanVienTxt.Text,
                DiaChiTxt.Text,
                NgaySinhSelector.Text,
                SDTTxt.Text,
                BangCapCombo.SelectedValue.ToString(),
                BoPhanCombo.SelectedValue.ToString(),
                ChucVuCombo.SelectedValue.ToString()
            );

            try
            {
                if (BUS_NhanVien.ThemNhanVien(nhanVien))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YeuCau1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiBangCap();
            HienThiDanhSachLoaiBoPhan();
            HienThiDanhSachLoaiChucVu();
            HienThiMaNhanVienMoi();
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

        private void HienThiMaNhanVienMoi()
        {
            List<DTO_NhanVien> listNhanVien = BUS_NhanVien.LayDanhSachNhanVien();
            if (listNhanVien.Count == 0)
            {
                MaNhanVienTxt.Text = "NV001";
            }
            else
            {
                string maNVCuoi = listNhanVien.Last().MaNhanVien;
                int soCuoi = int.Parse(maNVCuoi.Substring(2)) + 1;
                MaNhanVienTxt.Text = "NV" + soCuoi.ToString("D3");
            }
        }
    }
}

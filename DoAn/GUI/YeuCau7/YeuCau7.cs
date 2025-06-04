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
    public partial class YeuCau7: Form
    {
        BUS_NhanVien BUS_NhanVien = new BUS_NhanVien();
        BUS_PhieuThuTienPhat BUS_PhieuThuTienPhat = new BUS_PhieuThuTienPhat();
        BUS_TheDocGia BUS_TheDocGia = new BUS_TheDocGia();
        BUS_LoaiBoPhan BUS_LoaiBoPhan = new BUS_LoaiBoPhan();
        public YeuCau7()
        {
            InitializeComponent();
        }

        private void YeuCau7_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
            //HienThiMaPhieuThuMoi();
            HienThiDanhSachTenDocGia();
        }

        private void HienThiDanhSachNhanVien()
        {
            TenNhanVienCombo.SelectedIndexChanged -= TenNhanVienCombo_SelectedIndexChanged;
            List<string> listNhanVien = BUS_NhanVien.LayTatCaTenNhanVien();
            var sortedList = listNhanVien
                .OrderBy(ten => ten)
                .ToList();
            TenNhanVienCombo.DataSource = null;
            TenNhanVienCombo.DataSource = sortedList;
            TenNhanVienCombo.SelectedIndex = -1;
            TenNhanVienCombo.SelectedIndexChanged += TenNhanVienCombo_SelectedIndexChanged;
        }

        private void HienThiMaBoPhan()
        {
            string maBoPhan = BUS_NhanVien.LayMaBoPhanTheoTenNhanVien(TenNhanVienCombo.Text);
            if (!BUS_LoaiBoPhan.LayQuyenThuTienPhat(maBoPhan))
            {
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("Nhân viên hiện tại không có quyền thu tiềnp phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TenDocGiaCombo.Enabled = false;
                }));
            }
            else
            {
                TenDocGiaCombo.Enabled = true;
            }
            MaBoPhanTxt.Text = maBoPhan;
        }

        private void HienThiMaPhieuThuMoi()
        {
            List<DTO_PhieuThuTienPhat> listPhieuthu = BUS_PhieuThuTienPhat.LayDanhSachPhieuThuTienPhat();
            if (listPhieuthu.Count == 0)
            {
                MaPhieuThuTxt.Text = "TP0001";
            }
            else
            {
                string maPMCuoi = listPhieuthu.Last().MaPhieuThuTienPhat;
                //MessageBox.Show(maPMCuoi);
                int soCuoi = int.Parse(maPMCuoi.Substring(2)) + 1;
                MaPhieuThuTxt.Text = "TP" + soCuoi.ToString("D4");
            }
        }

        private void HienThiDanhSachTenDocGia()
        {
            TenDocGiaCombo.SelectedIndexChanged -= TenDocGiaCombo_SelectedIndexChanged;
            List<string> listTenDocGia = BUS_TheDocGia.LayTatCaTenDocGia(0);
            var sortedList = listTenDocGia
                .OrderBy(ten => ten)
                .ToList();
            TenDocGiaCombo.DataSource = null;
            TenDocGiaCombo.DataSource = sortedList;
            TenDocGiaCombo.SelectedIndex = -1;
            TenDocGiaCombo.SelectedIndexChanged += TenDocGiaCombo_SelectedIndexChanged;

        }

        private void HienThiTongNo()
        {
            string maDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGiaCombo.Text);
            DTO_TheDocGia DTO_TheDocGia = BUS_TheDocGia.LayThongTinTheDocGia(maDocGia);
            if (DTO_TheDocGia != null)
            {
                TongNoTxt.Text = DTO_TheDocGia.TongNo.ToString();
            }
            else
            {
                TongNoTxt.Text = "0";
            }
            SoTienThuTxt.Enabled = true;
        }

        private void TinhTienNoConLai()
        {
            TienConLaiTxt.Text = (int.Parse(TongNoTxt.Text) - int.Parse(SoTienThuTxt.Text)).ToString();
        }
        private void TenNhanVienCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiMaBoPhan();
            HienThiMaPhieuThuMoi();
        }

        private void TenDocGiaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiTongNo();
        }

        private void SoTienThuTxt_Validated(object sender, EventArgs e)
        {
            if (int.Parse(SoTienThuTxt.Text) > int.Parse(TongNoTxt.Text))
            {
                MessageBox.Show("Số tiền thu vượt quá số tiền nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                TinhTienNoConLai();
            }
        }

        private void clearContent()
        {
            TenDocGiaCombo.SelectedIndexChanged -= TenDocGiaCombo_SelectedIndexChanged;
            
            HienThiDanhSachNhanVien();
            HienThiDanhSachTenDocGia();
            MaPhieuThuTxt.Text = string.Empty;
            SoTienThuTxt.Text = string.Empty;
            MaBoPhanTxt.Text = string.Empty;
            TongNoTxt.Text = string.Empty;
            TienConLaiTxt.Text = string.Empty;
            SoTienThuTxt.Enabled = false;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string TenDocGia = TenDocGiaCombo.SelectedItem?.ToString();
            string MaDocGia = BUS_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);
            DTO_PhieuThuTienPhat DTO_PhieuThuTienPhat = new DTO_PhieuThuTienPhat(
                MaPhieuThuTxt.Text,
                int.Parse(SoTienThuTxt.Text),
                MaDocGia,
                BUS_NhanVien.LayMaNhanVienTheoTenNhanVien(TenNhanVienCombo.Text)

            );


            try
            {
                if (BUS_PhieuThuTienPhat.ThemPhieuThuTienPhat(DTO_PhieuThuTienPhat) && BUS_TheDocGia.CapNhatTongNo(MaDocGia, float.Parse(TienConLaiTxt.Text)))
                {
                    MessageBox.Show("Thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("thu tiền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi Thêm phiếu thu tiền: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearContent();
        }
    }
}

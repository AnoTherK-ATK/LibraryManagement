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

namespace DoAn.GUI
{
    public partial class GUI_ThayDoiThamSo: Form
    {
        BUS_ThamSo thamSo = new BUS_ThamSo();
        public GUI_ThayDoiThamSo()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_ThayDoiThamSo_Load(object sender, EventArgs e)
        {
            TuoiToiThieuTxt.Text = thamSo.LayTuoiToiThieu().ToString();
            TuoiToiDaTxt.Text = thamSo.LayTuoiToiDa().ToString();
            TienPhatTraTreMoiNgayTxt.Text = thamSo.LayTienPhatTraTreMoiNgay().ToString();
            ThoiHanGiaTriTheTxt.Text = thamSo.LayGiaTriThe().ToString();
            ThoiGianNhapSachToiDaTxt.Text = thamSo.LayThoiGianNhapSachToiDa().ToString();
            HanMuonSachToiDaTxt.Text = thamSo.LayHanMuonSachToiDa().ToString();
            ThoiGianMuonSachToiDaTxt.Text = thamSo.LayThoiGianMuonSachTheoQuyDinh().ToString();
            SoSachToiDaTxt.Text = thamSo.LaySachMuonToiDaTheoThoiGianQuyDinh().ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int tuoiToiThieu, tuoiToiDa, tienPhatTraTreMoiNgay, thoiGianNhapSachToiDa, hanMuonSachToiDa, thoiGianMuonSachTheoQuyDinh, sachMuonToiDaTheoThoiGianQuyDinh, thoiHanGiaTriThe;
            try
            {
                tuoiToiThieu = int.Parse(TuoiToiThieuTxt.Text);
                tuoiToiDa = int.Parse(TuoiToiDaTxt.Text);
                tienPhatTraTreMoiNgay = int.Parse(TienPhatTraTreMoiNgayTxt.Text);
                thoiGianNhapSachToiDa = int.Parse(ThoiGianNhapSachToiDaTxt.Text);
                hanMuonSachToiDa = int.Parse(HanMuonSachToiDaTxt.Text);
                thoiGianMuonSachTheoQuyDinh = int.Parse(ThoiGianMuonSachToiDaTxt.Text);
                sachMuonToiDaTheoThoiGianQuyDinh = int.Parse(SoSachToiDaTxt.Text);
                thoiHanGiaTriThe = int.Parse(ThoiHanGiaTriTheTxt.Text);
                if (thamSo.CapNhatThamSo(tuoiToiThieu, tuoiToiDa, tienPhatTraTreMoiNgay, thoiHanGiaTriThe, thoiGianNhapSachToiDa, hanMuonSachToiDa, thoiGianMuonSachTheoQuyDinh, sachMuonToiDaTheoThoiGianQuyDinh))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số nguyên cho các trường tham số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void GUI_ThayDoiThamSo_Load_1(object sender, EventArgs e)
        {
            TuoiToiThieuTxt.Text = thamSo.LayTuoiToiThieu().ToString();
            TuoiToiDaTxt.Text = thamSo.LayTuoiToiDa().ToString();
            TienPhatTraTreMoiNgayTxt.Text = thamSo.LayTienPhatTraTreMoiNgay().ToString();
            ThoiHanGiaTriTheTxt.Text = thamSo.LayGiaTriThe().ToString();
            ThoiGianNhapSachToiDaTxt.Text = thamSo.LayThoiGianNhapSachToiDa().ToString();
            HanMuonSachToiDaTxt.Text = thamSo.LayHanMuonSachToiDa().ToString();
            ThoiGianMuonSachToiDaTxt.Text = thamSo.LayThoiGianMuonSachTheoQuyDinh().ToString();
            SoSachToiDaTxt.Text = thamSo.LaySachMuonToiDaTheoThoiGianQuyDinh().ToString();
        }
    }
}

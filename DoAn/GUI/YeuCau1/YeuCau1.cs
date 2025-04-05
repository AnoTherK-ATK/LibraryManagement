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

        }

        private void YeuCau1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiBangCap();
            HienThiDanhSachLoaiBoPhan();
            HienThiDanhSachLoaiChucVu();
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
    }
}

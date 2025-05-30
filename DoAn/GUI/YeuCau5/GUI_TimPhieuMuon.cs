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
namespace DoAn.GUI.YeuCau5
{
    public partial class GUI_TimPhieuMuon : Form
    {
        private BUS_PhieuMuonSach PhieuMuonSach = new BUS_PhieuMuonSach();
        public GUI_TimPhieuMuon()
        {
            InitializeComponent();
            NgayMuon.Format = DateTimePickerFormat.Custom;
            NgayMuon.CustomFormat = " ";
        }

        private void TimPM_Click(object sender, EventArgs e)
        {
            string maPM = MaPM_text.Text.Trim();
            string hoTen = Name_text.Text.ToLower().Trim();
            DateTime? ngayMuon = null;
            if (NgayMuon.CustomFormat != " ")
            {
                ngayMuon = NgayMuon.Value;
            }
            var listPhieuMuon = PhieuMuonSach.TimPhieuMuonSach(maPM, hoTen, ngayMuon);


        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            NgayMuon.CustomFormat = " ";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }

        private void ValueChange(object sender, EventArgs e)
        {
            NgayMuon.Format = DateTimePickerFormat.Custom;
            NgayMuon.CustomFormat = "dd/MM/yyyy";
        }
    }
}

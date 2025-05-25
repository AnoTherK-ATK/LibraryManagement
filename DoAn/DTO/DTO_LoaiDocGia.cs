using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    internal class DTO_LoaiDocGia
    {
        string maLoaiDocGia;
        public string MaLoaiDocGia
        {
            get { return maLoaiDocGia; }
            set { maLoaiDocGia = value; }
        }

        string tenLoaiDocGia;
        public string TenLoaiDocGia
        {
            get { return tenLoaiDocGia; }
            set { tenLoaiDocGia = value; }
        }

        public DTO_LoaiDocGia(string maLoaiDocGia, string tenLoaiDocGia)
        {
            this.maLoaiDocGia = maLoaiDocGia;
            this.tenLoaiDocGia = tenLoaiDocGia;
        }
    }
}

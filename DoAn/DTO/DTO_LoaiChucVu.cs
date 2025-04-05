using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_LoaiChucVu
    {
        string maLoaiChucVu;
        public string MaLoaiChucVu { get => maLoaiChucVu; set => maLoaiChucVu = value; }
        string tenLoaiChucVu;
        public string TenLoaiChucVu { get => tenLoaiChucVu; set => tenLoaiChucVu = value; }

        public DTO_LoaiChucVu(string maLoaiChucVu, string tenLoaiChucVu)
        {
            this.maLoaiChucVu = maLoaiChucVu;
            this.tenLoaiChucVu = tenLoaiChucVu;
        }
    }
}

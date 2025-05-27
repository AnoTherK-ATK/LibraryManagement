using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_TheLoai
    {
        string maTheLoai;
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        string tenTheLoai;
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public DTO_TheLoai(string maTheLoai, string tenTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
        }
    }
}

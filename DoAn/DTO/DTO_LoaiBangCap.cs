using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_LoaiBangCap
    {
        string maLoaiBangCap;
        public string MaLoaiBangCap { get => maLoaiBangCap; set => maLoaiBangCap = value; }
        string tenLoaiBangCap;
        public string TenLoaiBangCap { get => tenLoaiBangCap; set => tenLoaiBangCap = value; }

        public DTO_LoaiBangCap(string maLoaiBangCap, string tenLoaiBangCap)
        {
            this.maLoaiBangCap = maLoaiBangCap;
            this.tenLoaiBangCap = tenLoaiBangCap;
        }
    }
}

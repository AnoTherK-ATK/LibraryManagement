using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_LoaiBoPhan
    {
        string maLoaiBoPhan;
        public string MaLoaiBoPhan { get => maLoaiBoPhan; set => maLoaiBoPhan = value; }
        string tenLoaiBoPhan;
        public string TenLoaiBoPhan { get => tenLoaiBoPhan; set => tenLoaiBoPhan = value; }

        public DTO_LoaiBoPhan(string maLoaiBoPhan, string tenLoaiBoPhan)
        {
            this.maLoaiBoPhan = maLoaiBoPhan;
            this.tenLoaiBoPhan = tenLoaiBoPhan;
        }
    }
}

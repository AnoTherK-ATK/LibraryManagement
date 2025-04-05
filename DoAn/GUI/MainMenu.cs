using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void YC1btn_Click(object sender, EventArgs e)
        {
            new YeuCau1().Show();
        }
    }
}

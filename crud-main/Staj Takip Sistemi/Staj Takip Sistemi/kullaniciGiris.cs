using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
    public partial class kullaniciGiris : Form
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            personelSifreTxt.UseSystemPasswordChar = false;
            picEye.Visible = false;
            picHide.Visible = true;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            personelSifreTxt.UseSystemPasswordChar = true;
            picEye.Visible = true;
            picHide.Visible = false;
        }
    }
}

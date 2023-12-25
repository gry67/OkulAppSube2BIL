using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube2BİL
{
    public partial class frmSecim : Form
    {
        public frmSecim()
        {
            InitializeComponent();
        }

        private void btn_ogrenciSec_Click(object sender, EventArgs e)
        {
            var ogrenciform = new frmOgrKayit();
            ogrenciform.Show();
        }

        private void btn_ogretmenSec_Click(object sender, EventArgs e)
        {
            var ogretmenForm = new frmOgretmenKayit();
            ogretmenForm.Show();
        }
    }
}

using OkulApp.BLL;
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
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm = null;
        public frmOgrBul(frmOgrKayit frmOgr)
        {
            InitializeComponent();
            this.frm = frmOgr;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciBL obl = new OgrenciBL();
                var ogr = obl.OgrenciBul(txtNumara.Text.Trim());

                if (ogr != null)
                {
                    frm.txt_Ad.Text = ogr.Ad;
                    frm.txt_Soyad.Text = ogr.Soyad;
                    frm.txt_Numara.Text = ogr.numara;
                    frm.OgrenciId = ogr.Ogrenciid;
                    frm.btnSil.Enabled= true;
                    frm.btnGuncelle.Enabled= true;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı");
                }
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show($"Hata Alındı {x}");
            }
        }
    }
}

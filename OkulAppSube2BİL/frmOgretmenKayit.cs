using OkulApp.BLL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube2BİL
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogretmenBl = new OgretmenBL();
                bool sonuc = ogretmenBl.OgretmenKaydet(new Ogretmen
                {
                    TCKNO = txtboxTCKNO.Text.Trim(),
                    Ad = txtboxAd.Text.Trim(),
                    Soyad = txtboxSoyad.Text.Trim()
            });

                MessageBox.Show(sonuc ? "Ekleme başarılı" : "Ekleme başarısız!");

            }
            catch (SqlException ex)
            {
                switch (ex.Number) 
                {
                    case 2628: MessageBox.Show("Tckno en fazla 11 haneli olabilir"); 
                        break;

                    default: MessageBox.Show("veritabanı hatası"); 
                        break;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}

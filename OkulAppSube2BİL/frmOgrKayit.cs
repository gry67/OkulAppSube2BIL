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
using OkulApp.BLL;

namespace OkulAppSube2BİL
{
    public partial class frmOgrKayit : Form
    {
        public int OgrenciId { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
        }


        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciKaydet(new Ogrenci
                {
                    Ad = txt_Ad.Text.Trim(),
                    Soyad = txt_Soyad.Text.Trim(),
                    numara = txt_Numara.Text.Trim(),
                });

                MessageBox.Show(sonuc ? "Ekleme başarılı" : "Ekleme başarısız!");
            }
            catch(SqlException ex) 
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("bu numara daha önce kaydedilmiş");
                        break;

                    default:
                        MessageBox.Show("veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                throw;
                MessageBox.Show("bilinmeyen hata");
            }

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            var frm = new frmOgrBul(this);
            frm.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            MessageBox.Show(obl.OgrenciSil(OgrenciId)? "Silme Başarılı":"Silme Başarısız");
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var obl = new OgrenciBL();
            Ogrenci ogr = new Ogrenci()
            {
            Ad = txt_Ad.Text.Trim(),
            Soyad = txt_Soyad.Text.Trim(),
            numara = txt_Numara.Text.Trim(),
            Ogrenciid = OgrenciId
            };

            MessageBox.Show(obl.OgrenciGuncelle(ogr)? "Güncelleme Başarılı" : "Güncelleme Başarısız!");
            
        }
    }
}

using OkulApp.Model;
using System;
using System.Data.SqlClient;
using OkulApp.DAL;
using System.Net;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {

        public bool OgrenciKaydet(Ogrenci ogr)
        {

            var hlp = new Helper();
            var p = new SqlParameter[]
            {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.numara),
            };

            return hlp.ExecuteNonQuery("Insert into tbl_Ogrenciler values(@Ad, @Soyad, @Numara)", p) > 0;
        }

        public Ogrenci OgrenciBul(string numara)
        {
            var hlp = new Helper();
            SqlParameter[] p = { new SqlParameter("@Numara", numara) };
            
            var dr = hlp.ExecuteReader("Select OgrenciId, Ad, Soyad, Numara From tbl_Ogrenciler where Numara = @Numara",p);
            
            Ogrenci ogr = null;

            if (dr.Read())
            {
                ogr = new Ogrenci();
                ogr.Ad = dr["Ad"].ToString();
                ogr.Soyad = dr["Soyad"].ToString();
                ogr.numara = dr["Numara"].ToString();
                ogr.Ogrenciid = Convert.ToInt32(dr["OgrenciId"].ToString());

            }
            dr.Close();
            return ogr;
        }

        public bool OgrenciSil(int ogrenciID)
        {
            var hlp = new Helper();
            var p = new SqlParameter[]
            {
                new SqlParameter("@ID",ogrenciID)
            };

            return hlp.ExecuteNonQuery("Delete From tbl_Ogrenciler WHERE OgrenciId = @ID", p) > 0;
        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@Ad",ogr.Ad),
                new SqlParameter("@Soyad",ogr.Soyad),
                new SqlParameter("@Numara",ogr.numara)
            };

            var hlp = new Helper();
            return hlp.ExecuteNonQuery("Update tbl_Ogrenciler set Ad=@Ad, Soyad = @Soyad, Numara = @Numara",p) > 0;
        }
    }
}

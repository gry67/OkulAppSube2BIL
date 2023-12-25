using OkulApp.DAL;
using OkulApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogr)
        {
            var hlp = new Helper();


            var p = new SqlParameter[]
            {
                new SqlParameter("@TCKNO", ogr.TCKNO),
                new SqlParameter("@Ad", ogr.Ad),
                new SqlParameter("@Soyad", ogr.Soyad)
            };

            return hlp.ExecuteNonQuery("Insert Into tbl_Ogretmenler values (@TCKNO, @Ad, @Soyad)", p) > 0;
        }
    }
}

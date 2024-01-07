using System;
using System.Data.SqlClient;
using System.Configuration;

namespace OkulApp.DAL
{
    public class Helper
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p=null)
        {
            using(cn = new SqlConnection(cstr))
            {
                using(cmd=new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery(); //hatayı burada alıyorum
                }
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            cn = new SqlConnection(cstr);
            cmd = new SqlCommand(cmdtext, cn);

            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            cn.Open();
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
    }
}

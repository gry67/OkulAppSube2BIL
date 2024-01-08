using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace OkulApp.DAL
{
    public class Helper : IDisposable
    {
        private Helper()
        {

        }

        private static Helper instance;

        public static Helper getInstance()
        {
            if (instance == null)
            {
                instance = new Helper();
            }
            return instance;
        }

        //-----------------------------------------------------------------------------

        SqlConnection cn = null;
        SqlCommand cmd = null;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
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
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            try
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
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            cn.Dispose();
            cmd.Dispose();
        }
    }
}

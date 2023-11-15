using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace hospital
{
    class first
    {
        public SqlConnection con;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public SqlCommand cmd;


        public first()//constructor
        {
            con = new SqlConnection();
            da = new SqlDataAdapter();
            cmd = new SqlCommand();

            cmd.Connection = con;
            da.SelectCommand = cmd;
        }
        public void Connect()
        {
            con.ConnectionString = @"Data Source=.;database=hospital;integrated security=sspi";// ConfigurationManager.ConnectionStrings["hospital"].ToString();

            con.Open();
        }
        public void Disconnect()
        {
            con.Close();
        }

        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            da.Fill(dt);
            return dt;
        }
        public void Docommand(string sql)
        {
            try
            {

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {


            }

        }
        public void Docommand(string proc, string parametername, string parameter)
        {
            try
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = proc;
                cmd.Parameters.Add(parametername, SqlDbType.Int).Value = parameter;
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {


            }

        }

    }
}

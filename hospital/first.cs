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
        SqlConnection con;
        SqlDataAdapter da;
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
            con.ConnectionString = @"Data Source=.;database=hospital;integrated security=sspi";// @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Default Company Name\Setup1\hospital\hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;;//ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
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
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

    }
}

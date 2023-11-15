using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hospital
{
    class second

    {
    
        first fr = new first();
        
        public  void ShowData( string StrSql, DataGridView Grid)
        {

            first fr = new first();
            fr.Connect();

            fr.cmd.CommandText = StrSql;
            DataTable dt = new DataTable();
            dt.Load(fr.cmd.ExecuteReader());
            Grid.DataSource = dt;
           
            fr.Disconnect();
        }
      
        public void Command (string sql)//add/update/delete
        {
            fr.Connect();
            fr.Docommand(sql);
           fr.Disconnect();

        }
        public DataTable Select(string sql)//select from tabale
        {
            DataTable dt = new DataTable();
            fr.Connect();
            dt = fr.Select(sql);
            fr.Disconnect();
            return dt;
        }
        public void Getone(string sql)//get one item of database
        {
            DataTable dt = new DataTable();
            fr.Connect();
            dt = fr.Select(sql);
            fr.Disconnect();
        }
        public DataTable GetList(string sql)
        {
            DataTable dt = new DataTable();
            fr.Connect();
            dt = fr.Select(sql);
            fr.Disconnect();
            return dt;
        }


        internal void Select(string p, string p_2)
        {
            throw new NotImplementedException();
        }
    }
}

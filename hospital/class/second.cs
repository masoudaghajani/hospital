using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace hospital
{
    class second
    {

        first fr = new first();




        public void ShowData(string proce, DataGridView Grid)
        {

            first fr = new first();
            fr.Connect();
            fr.cmd.CommandType = CommandType.StoredProcedure;
            fr.cmd.CommandText = proce;
            DataTable dt = new DataTable();
            fr.da.Fill(dt);
            Grid.DataSource = dt;

            fr.Disconnect();
        }
        public void ShowData(string proce, string proce_parameter,string parametername, DataGridView Grid)
        {

            first fr = new first();
            fr.Connect();
            fr.cmd.CommandType = CommandType.StoredProcedure;
            fr.cmd.CommandText = proce;
            DataTable dt = new DataTable();
            fr.cmd.Parameters.Add(parametername, SqlDbType.NVarChar).Value = proce_parameter;
            fr.da.Fill(dt);
            Grid.DataSource = dt;

            fr.Disconnect();
        }
      

        public void Command(string sql)//add/update/delete
        {
            fr.Connect();
            fr.Docommand(sql);

            fr.Disconnect();

        }
        public void Command(string proc, string parametername, string parameter)//add/update/delete
        {
            fr.Connect();
            fr.Docommand(proc,parametername, parameter);

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

        public void farsikeyboard()
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-IR"));

        }
        public void textClear(Form frm)
        {
            foreach (Control ctl in frm.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                    ctl.Text = "";
            }
        }

        public void numberonly(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
    }


}

class refreshpage
{
    [System.Runtime.InteropServices.DllImport("Shell32.dll")]
    private static extern int shchangenotify(int eventid, int flage, IntPtr item11, IntPtr item2);
    // shchangenotify(0x8000000, 0x1000, IntPtr.Zero, IntPtr.Zero);

}

class Picture
{
    public static string Location = "";
    public static int Pic(Form form)
    {
        OpenFileDialog ODI = new OpenFileDialog();
        ODI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        ODI.Filter = "Picture As jpg|*.jpg|Picture As jpeg|*.jpeg*|Picture As bmp|*.bmp|Picture As gif|*.gif|Picture As wmf|*.wmf|Picture As png|*.png";
        if (ODI.ShowDialog(form) == DialogResult.OK)
            Location = ODI.FileName.ToString();
        return (0);
    }
}




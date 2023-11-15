using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace hospital
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }
        void login()
        {
            SqlCommand cmd = new SqlCommand("select dbo.fun_log(@username,@password,@semat)", new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ToString()));
            cmd.Connection.Open();
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtuser.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtpass.Text;
            cmd.Parameters.Add("@semat", SqlDbType.NVarChar, 50).Value = comboBox1.Text;

            bool b = Convert.ToBoolean(cmd.ExecuteScalar());
            if (b)
            {
                business.LoginInfo.Semat = comboBox1.SelectedItem.ToString();
               main frm = new main();     
               frm.ShowDialog();
            }
            else
            {

                MessageBox.Show("نام کاربری سمت یا کلمه عبور اشتباه است");

                txtuser.SelectAll();
                txtpass.SelectAll();
                txtuser.Focus();

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            btn_in.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

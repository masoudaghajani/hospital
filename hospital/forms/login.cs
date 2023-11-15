using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospital
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public void loginfunction()
        {


            SqlCommand cmd = new SqlCommand("select dbo.fun_log(@username,@password,@semat)", new SqlConnection(@"Data Source=.;database=hospital;integrated security=sspi"));//@"Data Source=.;AttachDbFilename="+ Application.StartupPath+"/hospital.mdf;integrated security=true"));//(ConfigurationManager.ConnectionStrings["connectionstring"].ToString()));
            cmd.Connection.Open();
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtuser.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtpass.Text;
            cmd.Parameters.Add("@semat", SqlDbType.NVarChar, 50).Value = comboBox1.Text;
            bool b = Convert.ToBoolean(cmd.ExecuteScalar());
            if (b)
            {
                main frm = new main();


                frm.ShowDialog();

                cmd.Connection.Close();
            }
            else
            {

                MessageBox.Show("نام کاربری سمت یا کلمه عبور اشتباه است");

                txtuser.SelectAll();
                txtpass.SelectAll();
                txtuser.Focus();

            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            loginfunction();


        }

        private void login_Load(object sender, EventArgs e)
        {
            btn_in.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

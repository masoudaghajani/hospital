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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
        }
       
        private void form2_Load(object sender, EventArgs e)
        {
            button1.Focus();
        
        
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text==txtconfirm.Text)
                {
                    SqlCommand cmd = new SqlCommand("prc_ins", new SqlConnection(@"Data Source=.;database=hospital;integrated security=sspi"));
                    cmd.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtuser.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtpass.Text;
                    cmd.Parameters.Add("@semat", SqlDbType.NVarChar, 50).Value = comboBox1.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    MessageBox.Show(" عملیات با موفقت ثبت شد");
                }
                else
                {
                    MessageBox.Show("کلمه عبور یکسان نیست");
                }
              
            }
            catch (Exception)
            {
                //MessageBox.Show("عملیات نا موفق بود ");
                
               
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           



        }

       
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = button1;
           
        }
    }
}

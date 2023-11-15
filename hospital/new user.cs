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
        second se = new second();
        private void form2_Load(object sender, EventArgs e)
        {
            button1.Focus();




        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtuser.Text))
                {


                    if (txtpass.Text == txtconfirm.Text)
                    {
                        SqlCommand cmd = new SqlCommand("prc_ins", new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ToString()));
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
                else
                {
                    MessageBox.Show("نام کاربری را وارد کنید");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("عملیات نا موفق بود ");


            }


        }

      
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = button1;

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
           
            se.ShowData("SELECT Id کد,username'نام کاربری', semat'سمت' from Admin", Dgv_Admin);
            form2_Load(null, null);
        }

        private void Dgv_Admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = Dgv_Admin[0, e.RowIndex].Value.ToString();
            txtusername.Text = Dgv_Admin[1, e.RowIndex].Value.ToString();
            Cbxsemat.Text = Dgv_Admin[2, e.RowIndex].Value.ToString();
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("prc_update", new SqlConnection(ConfigurationManager.ConnectionStrings["connectionstring"].ToString()));
                    cmd.Connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtusername.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = txtpassword.Text;
                    cmd.Parameters.Add("@semat", SqlDbType.NVarChar, 50).Value = Cbxsemat.Text;
                    cmd.Parameters.Add("@Id", SqlDbType.NVarChar, 50).Value = label7.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    MessageBox.Show("ویرایش با موفقت ثبت شد");
                }
                else if (d == DialogResult.Cancel)
                {
                    this.Hide();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            business.CloseWindows(this);
        }
    }
}

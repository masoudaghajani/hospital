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

    public partial class maly : Form
    {
        public maly()
        {
            InitializeComponent();
        }

        second se = new second();



        private void maly_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            TextBox1.Select();
            se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dataGridView1);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا مطمئن هستد؟", "تسویه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void TextBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void TextBox4_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void TextBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

      

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                se.Command("dbo.proc_shomare_parvande_bimar_footshode", "shomare_parvande_bimar", TextBox1.Text);
            se.ShowData("dbo.proc_shomare_parvande_bimar_footshode", TextBox1.Text, "shomare_parvande_bimar", dataGridView1);
        


            }
            catch (Exception)
            {

                MessageBox.Show("لطفا شماره پرونده را وارد");
            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar where family='{0}'", textBox6.Text);
                se.Command(sql);
                se.ShowData(sql, dataGridView1);
            }
            catch (Exception)
            {

                MessageBox.Show("لطفا نام خوانوادگی را وارد");

            }


        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);
        }

       
        private void button2_Click_2(object sender, EventArgs e)
        {
            int a = dataGridView1.Rows.Count;

            if (a ==2)
            {
                textBox7.Text = dataGridView1[4, 0].Value.ToString();
                TextBox2.Text = dataGridView1[5, 0].Value.ToString();
            }
            else
            {
                MessageBox.Show(" 1-شماره پرونده یا نام خوانوادگی را وارد کنید"+"\n 2-تعداد نتیجه بیش از یکی است", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                   
            }
            string str = dataGridView1[8, 0].Value.ToString();
           
     
            
            
        }
    }

}

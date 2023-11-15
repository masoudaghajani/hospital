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
    public partial class sabt : Form
    {
        public sabt()
        {
            InitializeComponent();
        }
        second se = new second();


        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabtePezeshk;
           
           se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk", dgv_pezeshk);
           sabt_Load(null, null);
        
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabteParastar;
            se.ShowData("SELECT  name  'نام', family  'نام خانوادگی', tahsilat 'تحصیلات', shomare_personali  'شماره پرسنلی', telephon' تلفن', address 'ادرس'FROM  sabte_parastar", dgv_parastar);
            sabt_Load(null, null);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabteDaro;
            se.ShowData("SELECT name'نام', gheymat'قیمت', tarikh_tolid'تاریخ تولید', tarikh_engheza'تاریخ انقضا', code_daro'کد دارو' FROM dbo.daro", dgv_daro);
            sabt_Load(null, null);

        }
 

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabteMargeBimar;
            se.ShowData("SELECT name'نام', family'نام خانوادگی', shomare_parvande_bimar'شماره پرونده بیمار', tarikh_foot'تاریخ فوت', shomare_yakhchal' شماره یخچال', tozihat'توضیحات' FROM dbo.sardkhone", dgv_margebimar);
            sabt_Load(null, null);

        }

 
        private void button5_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabteReserv;
        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {

            business.NumberOnly(e);
        }

        private void sabt_Load(object sender, EventArgs e)

        {
            dgv_daro.ReadOnly = true;
            dgv_margebimar.ReadOnly = true;
            dgv_parastar.ReadOnly = true;
            dgv_pezeshk.ReadOnly = true;
            dgv_reserv.ReadOnly = true;
           
           
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

       
        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

      

       

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnSabteReserv;
            se.ShowData("SELECT name'نام', family'نام خانوادگی', telephon'تلفن', code_rezerv'کد رزرو', noe_rezerv'نوع رزرو', tarikh_sabet'تاریخ ثبت', tarikh_rezerv_shode'تاریخ رزرو', mablagh_pishpardakht'مبلغ پیش پرداخت' FROM dbo.rezerv", dgv_reserv);
            sabt_Load(null, null);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void BtnSabtePezeshk_Click(object sender, EventArgs e)
        {
            try
            {
                second se = new second();

                string sql = string.Format("insert  into sabte_pezeshk (name,family,tahsilat,takhasos,shomare_personali_pezeshk,telephon,address)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", TextBox1.Text, TextBox2.Text, TextBox3.Text, comboBox2.Text, TextBox5.Text, textBox7.Text, textBox8.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox3.Text = null;
                comboBox2.Text = null;
                TextBox5.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                TextBox1.Select();
                se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk", dgv_pezeshk);




            }
            catch (Exception ex)
            {

                if (TextBox5.Text == null)
                {
                    MessageBox.Show("شماره پرسنلی وارد را کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnSabteParastar_Click(object sender, EventArgs e)
        {
            second se = new second();
            try
            {


                string sql = string.Format("insert  into sabte_parastar (name,family,tahsilat,shomare_personali,telephon,address)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                    , textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox9.Text, textBox6.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                se.ShowData("SELECT  name  'نام', family  'نام خانوادگی', tahsilat 'تحصیلات', shomare_personali  'شماره پرسنلی', telephon' تلفن', address 'ادرس'FROM  sabte_parastar", dgv_parastar);




            }
            catch (Exception ex)
            {
                if (textBox11.Text == "")
                {
                    MessageBox.Show("شماره پرسنلی را وارد کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);


                }


            }
            sabt_Load(null, null);
        }

        private void BtnSabteDaro_Click(object sender, EventArgs e)
        {
            try
            {
                second se = new second();
                string sql = string.Format("insert  into daro (name,gheymat,tarikh_tolid,tarikh_engheza,code_daro)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')"

                    , textBox20.Text, textBox19.Text, maskedTextBox2.Text, maskedTextBox1.Text, textBox16.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                se.ShowData("SELECT name'نام', gheymat'قیمت', tarikh_tolid'تاریخ تولید', tarikh_engheza'تاریخ انقضا', code_daro'کد دارو' FROM dbo.daro", dgv_daro);//refresh datagrid

            }
            catch (Exception ex)
            {
                if (textBox16.Text == "")
                {
                    MessageBox.Show("کد را وارد کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);


                }
            }
        }

        private void BtnSabteMargeBimar_Click(object sender, EventArgs e)
        {
            try
            {
                second se = new second();
                string sql = string.Format("insert  into sardkhone (name,family,shomare_parvande_bimar,tarikh_foot,shomare_yakhchal,tozihat)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                    , textBox23.Text, textBox22.Text, textBox21.Text, maskedTextBox3.Text, textBox15.Text, textBox24.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                se.ShowData("SELECT name'نام', family'نام خانوادگی', shomare_parvande_bimar'شماره پرونده بیمار', tarikh_foot'تاریخ فوت', shomare_yakhchal' شماره یخچال', tozihat'توضیحات' FROM dbo.sardkhone", dgv_margebimar);

            }
            catch (Exception ex)
            {
                if (textBox21.Text == "")
                {
                    MessageBox.Show("شماره پرونده بیمار را وارد کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);


                }
            }
        }

        private void BtnSabteReserv_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }
    }
}

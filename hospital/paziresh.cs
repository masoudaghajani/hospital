using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class paziresh : Form
    {
        public paziresh()
        {
            InitializeComponent();
        }
        second se = new second();

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
        private void paziresh_Load(object sender, EventArgs e)
        {
          
            main frm = new main();
           
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnpazireshBimar;
            TextBox1.Select();
            se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dgv_bimar);
            paziresh_Load(null, null);

           
          
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnPazireshMoayene;
            textBox9.Select();
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene", dgv_moayene);
          
            paziresh_Load(null, null);

            
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnPazireshTajviz;
            textBox12.Select();
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz", dgv_tajviz);
            paziresh_Load(null, null);
        }

        private void TextBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void TextBox3_KeyDown(object sender, KeyEventArgs e)
        {

            business.NumberOnly(e);
        }

       
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void BtnPazireshTajviz_Click(object sender, EventArgs e)
        {
            try
            {
                second se = new second();

                string sql = string.Format("insert  into tajviz (shomare_parvande_bimar,shomare_personali_pezeshk,code_daro,meghdare_masraf)values(N'{0}',N'{1}',N'{2}',N'{3}')", textBox12.Text, textBox15.Text, textBox14.Text, textBox13.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox12.Text = null;
                textBox15.Text = null;
                textBox14.Text = null;
                textBox13.Text = null;
                textBox12.SelectAll();
                AcceptButton = BtnPazireshTajviz;
                se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz", dgv_tajviz);




            }
            catch (Exception ex)
            {

                if (textBox12.Text == null)
                {
                    MessageBox.Show("شماره پرونده بیمار  را وارد  کنید");
                }
                if (textBox15.Text == null)
                {
                    MessageBox.Show("کد پرسنلی پزشک را وارد  کنید");
                }
                if (textBox14.Text == null)
                {

                    MessageBox.Show("کد دارو را وارد  کنید");

                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnPazireshMoayene_Click(object sender, EventArgs e)
        {
            try
            {
                second se = new second();

                string sql = string.Format("insert  into moayene (shomare_parvande_bimar,shomare_personali,tashkis)values('N{0}',N'{1}',N'{2}')", textBox9.Text, textBox10.Text, textBox11.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox9.Text = null;
                textBox10.Text = null;
                textBox11.Text = null;
                textBox9.SelectAll();
                AcceptButton = BtnPazireshMoayene;
                se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene", dgv_moayene);




            }
            catch (Exception ex)
            {

                if (textBox9.Text == null)
                {
                    MessageBox.Show("شماره پرونده بیمار وارد را کنید");
                }
                if (textBox10.Text == null)
                {
                    MessageBox.Show("کد پرسنلی پزشک وارد را کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnpazireshBimar_Click(object sender, EventArgs e)
        {
            try
            {
                string now;
                now = DateTime.Now.ToString();
                TextBox6.Text = now;
                second se = new second();
                string sql = string.Format("insert  into bimar (name,family,telephone,address,shomare_parvande_bimar,shomare_takht,shomare_otagh,bime,tarikh_bastari)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, textBox7.Text, textBox8.Text, comboBox1.Text, TextBox6.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox3.Text = null;
                TextBox4.Text = null;
                TextBox5.Text = null;
                textBox7.Text = null;
                textBox8.Text = null;
                comboBox1.Text = null;
                TextBox1.Select();
                se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dgv_bimar);


            }
            catch (Exception ex)
            {

                if (TextBox5.Text == null)
                {
                    MessageBox.Show("شماره پرونده را وارد  کنید");
                }

                else
                {
                    MessageBox.Show(ex.Message);
                }
                paziresh_Load(null, null);

            }
        }
    }

       
    }


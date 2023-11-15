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
    public partial class gozaresh : Form
    {
        public gozaresh()
        {
            InitializeComponent();
        }
        second se = new second();

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "پزشک")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرسنلی پزشک";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label1.Text = ":شماره پرسنلی پزشک";
                    business.PrintQuery.StrPrintQuery = "SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "پرستار")
                {
                    comboBox2.ResetText();

                    comboBox2.Items.Clear();
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرسنلی پرستار";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label1.Text = " شماره پرسنلی پرستار ";

                    business.PrintQuery.StrPrintQuery = "SELECT  name  'نام', family  'نام خانوادگی', tahsilat 'تحصیلات', shomare_personali  'شماره پرسنلی', telephon' تلفن', address 'ادرس'FROM  sabte_parastar";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "دارو ")
                {
                    comboBox2.ResetText();

                    comboBox2.Items.Clear();
                    comboBox2.Visible = true;
                    textBox1.Clear();

                    comboBox2.Text = "کد دارو";
                    comboBox2.Items.Add("نام");
                    comboBox2.Items.Add("کد دارو");
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label1.Text = " کد دارو ";

                    business.PrintQuery.StrPrintQuery = "SELECT name'نام', gheymat'قیمت', tarikh_tolid'تاریخ تولید', tarikh_engheza'تاریخ انقضا', code_daro'کد دارو' FROM dbo.daro";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "رزرو تخت")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.ResetText();
                    comboBox3.Items.Clear();
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "کد رزرو";
                    comboBox2.Items.Add("نوع رزرو");
                    comboBox2.Items.Add("کد رزرو");
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label1.Text = "کد رزرو";

                    business.PrintQuery.StrPrintQuery = "SELECT name'نام', family'نام خانوادگی', telephon'تلفن', code_rezerv'کد رزرو', noe_rezerv'نوع رزرو', tarikh_sabet'تاریخ ثبت', tarikh_rezerv_shode'تاریخ رزرو', mablagh_pishpardakht'مبلغ پیش پرداخت' FROM dbo.rezerv";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "مرگ بیمار")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("نام خوانوادگی");
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    label1.Visible = true;

                    business.PrintQuery.StrPrintQuery = "SELECT name'نام', family'نام خانوادگی', shomare_parvande_bimar'شماره پرونده بیمار', tarikh_foot'تاریخ فوت', shomare_yakhchal' شماره یخچال', tozihat'توضیحات' FROM dbo.sardkhone";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }

                else if (comboBox1.Text == "پذیرش بیمار")
                {

                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("نام خوانوادگی");
                    comboBox2.Items.Add("شماره پرونده بیمار"); ;
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    label1.Visible = true;

                    business.PrintQuery.StrPrintQuery = "select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "معاینه")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    comboBox2.Items.Add("شماره پرسنلی پزشک");
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";

                    business.PrintQuery.StrPrintQuery = "select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox1.Text == "تجویز")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    maskedTextBox1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    textBox1.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    comboBox2.Items.Add("شماره پرسنلی پزشک");
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";

                    business.PrintQuery.StrPrintQuery = "select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz";
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "نام")
                {
                    label1.Visible = true;
                    textBox1.Visible = true;
                    label1.Text = " نام ";
                }

                else if (comboBox2.Text == "نوع رزرو")
                {
                    maskedTextBox1.Visible = false;
                    label1.Visible = false; ;
                    textBox1.Visible = false; ;
                    label3.Text = "نوع رزرو";
                    comboBox3.Visible = true;
                    comboBox3.Items.Add("عمل جراحی");
                    comboBox3.Items.Add("عمل پیوند");
                    comboBox3.Items.Add("رزرو تخت");
                    comboBox3.Items.Add("سایر");
                    comboBox3.TabIndex = 3;
                }

                else if (comboBox2.Text == "نام خوانوادگی")
                {
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Text = "نام خوانوادگی";
                    textBox1.Visible = true;
                    label1.Visible = true;
                }

                else if (comboBox2.Text == "شماره پرسنلی پزشک")
                {
                    maskedTextBox1.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Text = "شماره پرسنلی پزشک";
                    textBox1.Visible = true;
                    label1.Visible = true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                if (comboBox2.Text == "شماره پرسنلی پزشک" && comboBox1.Text == "پزشک")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk where shomare_personali_pezeshk='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                else if (comboBox2.Text == "شماره پرسنلی پرستار")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT  name  'نام', family  'نام خانوادگی', tahsilat 'تحصیلات', shomare_personali  'شماره پرسنلی', telephon' تلفن', address 'ادرس'FROM  sabte_parastar where shomare_personali='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox2.Text == "کد دارو")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', gheymat'قیمت', tarikh_tolid'تاریخ تولید', tarikh_engheza'تاریخ انقضا', code_daro'کد دارو' FROM daro where code_daro='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                else if (comboBox2.Text == "نام")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', gheymat'قیمت', tarikh_tolid'تاریخ تولید', tarikh_engheza'تاریخ انقضا', code_daro'کد دارو' FROM daro where name='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                else if (comboBox2.Text == "کد رزرو")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', family'نام خانوادگی', telephon'تلفن', code_rezerv'کد رزرو', noe_rezerv'نوع رزرو', tarikh_sabet'تاریخ ثبت', tarikh_rezerv_shode'تاریخ رزرو', mablagh_pishpardakht'مبلغ پیش پرداخت' FROM dbo.rezerv where code_rezerv='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }


                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "مرگ بیمار")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', family'نام خانوادگی', shomare_parvande_bimar'شماره پرونده بیمار', tarikh_foot'تاریخ فوت', shomare_yakhchal' شماره یخچال', tozihat'توضیحات' FROM dbo.sardkhone where shomare_parvande_bimar='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                else if (comboBox2.Text == "نام خوانوادگی" && comboBox1.Text == "مرگ بیمار")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', family'نام خانوادگی', shomare_parvande_bimar'شماره پرونده بیمار', tarikh_foot'تاریخ فوت', shomare_yakhchal' شماره یخچال', tozihat'توضیحات' FROM dbo.sardkhone where family='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "پذیرش بیمار")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar where shomare_parvande_bimar='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);

                }
                if (comboBox2.Text == "نام خوانوادگی" && comboBox1.Text == "پذیرش بیمار")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar where family='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "معاینه")
                {

                    business.PrintQuery.StrPrintQuery = string.Format("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene where shomare_parvande_bimar='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox2.Text == "شماره پرسنلی پزشک" && comboBox1.Text == "معاینه")
                {
                    business.PrintQuery.StrPrintQuery = string.Format("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene where shomare_personali_pezeshk='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "تجویز")
                {
                    business.PrintQuery.StrPrintQuery = string.Format("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz where shomare_parvande_bimar='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }
                else if (comboBox2.Text == "شماره پرسنلی پزشک" && comboBox1.Text == "تجویز")
                {
                    business.PrintQuery.StrPrintQuery = string.Format("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک', tashkis'تشخیص' from moayene where shomare_personali_pezeshk='{0}'", textBox1.Text);
                    se.Command(business.PrintQuery.StrPrintQuery);
                    se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                business.PrintQuery.StrPrintQuery = string.Format("SELECT name'نام', family'نام خانوادگی', telephon'تلفن', code_rezerv'کد رزرو', noe_rezerv'نوع رزرو', tarikh_sabet'تاریخ ثبت', tarikh_rezerv_shode'تاریخ رزرو', mablagh_pishpardakht'مبلغ پیش پرداخت' FROM dbo.rezerv where noe_rezerv='{0}'", comboBox3.Text);
                se.Command(business.PrintQuery.StrPrintQuery);
                se.ShowData(business.PrintQuery.StrPrintQuery, dgv_show);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Print prt = new Print();
            prt.ShowDialog();

        }
    }
}


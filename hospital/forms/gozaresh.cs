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
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرسنلی پزشک";
                    label1.Visible = true;
                    txt_parameter.Visible = true;
                    label1.Text = ":شماره پرسنلی پزشک";
                    se.ShowData("proc_pezeshk", Datagridview1);

                }
                else if (comboBox1.Text == "پرستار")
                {
                    comboBox2.ResetText();

                    comboBox2.Items.Clear();
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرسنلی پرستار";
                    label1.Visible = true;
                    txt_parameter.Visible = true;
                    label1.Text = " شماره پرسنلی پرستار ";
                    se.ShowData("proc_parastar", Datagridview1);

                }
                else if (comboBox1.Text == "دارو ")
                {
                    comboBox2.ResetText();

                    comboBox2.Items.Clear();
                    comboBox2.Visible = true;
                    txt_parameter.Clear();

                    comboBox2.Text = "کد دارو";
                    comboBox2.Items.Add("نام");
                    comboBox2.Items.Add("کد دارو");
                    comboBox2.Items.Add("تاریخ تولید");
                    comboBox2.Items.Add("تاریخ انقضا");
                    label1.Visible = true;
                    txt_parameter.Visible = true;
                    label1.Text = " کد دارو ";
                    se.ShowData("proc_daro", Datagridview1);
                }
                else if (comboBox1.Text == "رزرو تخت")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.ResetText();
                    comboBox3.Items.Clear();
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "کد رزرو";
                    comboBox2.Items.Add("نوع رزرو");
                    comboBox2.Items.Add("کد رزرو");
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label1.Visible = true;
                    txt_parameter.Visible = true;
                    label1.Text = "کد رزرو";
                    se.ShowData("proc_rezerv", Datagridview1);

                }
                else if (comboBox1.Text == "مرگ بیمار")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    msk_date.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("نام خوانوادگی");
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txt_parameter.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    label1.Visible = true;
                    se.ShowData("prce_margbimar", Datagridview1);

                }

                else if (comboBox1.Text == "پذیرش بیمار")
                {

                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    msk_date.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("نام خوانوادگی");
                    comboBox2.Items.Add("شماره پرونده بیمار"); ;
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txt_parameter.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    label1.Visible = true;
                    se.ShowData("proc_pazireshbimar", Datagridview1);

                }
                else if (comboBox1.Text == "معاینه")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    msk_date.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    comboBox2.Items.Add("شماره پرسنلی پزشک");
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txt_parameter.Visible = true;
                    label1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    se.ShowData("proc_moayene", Datagridview1);
                }
                else if (comboBox1.Text == "تجویز")
                {
                    comboBox2.ResetText();
                    comboBox2.Items.Clear();
                    comboBox3.Visible = false;
                    msk_date.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    comboBox2.Visible = true;
                    txt_parameter.Clear();
                    comboBox2.Text = "شماره پرونده بیمار";
                    comboBox2.Items.Add("شماره پرونده بیمار");
                    comboBox2.Items.Add("شماره پرسنلی پزشک");
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    txt_parameter.Visible = true;
                    label1.Visible = true;
                    label1.Text = "شماره پرونده بیمار";
                    se.ShowData("proc_tajviz_all", Datagridview1);


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
                    txt_parameter.Visible = true;
                    label1.Text = " نام ";
                }

                else if (comboBox2.Text == "نوع رزرو")
                {
                    msk_date.Visible = false;
                    label1.Visible = false; ;
                    txt_parameter.Visible = false; ;
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
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Text = "نام خوانوادگی";
                    txt_parameter.Visible = true;
                    label1.Visible = true;
                }

                else if (comboBox2.Text == "شماره پرسنلی پزشک")
                {
                    msk_date.Visible = false;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Text = "شماره پرسنلی پزشک";
                    txt_parameter.Visible = true;
                    label1.Visible = true;

                }
                else if (comboBox2.Text == "تاریخ تولید")
                {
                    msk_date.Visible = true;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label2.Text = "تاریخ تولید";
                    txt_parameter.Visible = false; ;
                    label1.Visible = false;
                    label2.Visible = true;


                }
                else if (comboBox2.Text == "تاریخ انقضا")
                {
                    msk_date.Visible = true;
                    comboBox3.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label2.Text = "تاریخ انقضا";
                    txt_parameter.Visible = false; ;
                    label1.Visible = false;
                    label2.Visible = true;

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
                    //string sql;
                    //sql = string.Format(variabale.shomare_personali_pezeshk, textBox1.Text);
                    se.Command("dbo.proc_shomare_personali_pezeshk", "shomare_personali_pezeshk", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_personali_pezeshk", txt_parameter.Text, "shomare_personali_pezeshk", Datagridview1);

                }
                else if (comboBox2.Text == "شماره پرسنلی پرستار")
                {
                    se.Command("dbo.proc_shomare_personali", "shomare_personali", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_personali", txt_parameter.Text, "shomare_personali", Datagridview1);
                }
                else if (comboBox2.Text == "کد دارو")
                {
                    se.Command("dbo.proc_code_daro", "code_daro", txt_parameter.Text);
                    se.ShowData("dbo.proc_code_daro", txt_parameter.Text, "code_daro", Datagridview1);

                }
                else if (comboBox2.Text == "نام")
                {
                    se.Command("dbo.proc_name_daro", "name_daro", txt_parameter.Text);
                    se.ShowData("dbo.proc_name_daro", txt_parameter.Text, "name_daro", Datagridview1);

                }
                else if (comboBox2.Text == "کد رزرو")
                {
                    se.Command("dbo.proc_code_rezerv", "code_rezerv", txt_parameter.Text);
                    se.ShowData("dbo.proc_code_rezerv", txt_parameter.Text, "code_rezerv", Datagridview1);
                }


                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "مرگ بیمار")
                {

                    se.Command("dbo.proc_shomare_parvande_bimar_footshode", "shomare_parvande_bimar", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_parvande_bimar_footshode", txt_parameter.Text, "shomare_parvande_bimar", Datagridview1);
                   

                }
                else if (comboBox2.Text == "نام خوانوادگی" && comboBox1.Text == "مرگ بیمار")
                {

                    se.Command("dbo.proc_family_bimare_footshode", "family", txt_parameter.Text);
                    se.ShowData("dbo.proc_family_bimare_footshode", txt_parameter.Text, "family", Datagridview1);
                }
                if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "پذیرش بیمار")
                {
                    se.Command("dbo.proc_shomare_parvande_bimar", "shomare_parvande_bimar", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_parvande_bimar", txt_parameter.Text, "shomare_parvande_bimar", Datagridview1);
                    

                }
                if (comboBox2.Text == "نام خوانوادگی" && comboBox1.Text == "پذیرش بیمار")
                {

                    se.Command("dbo.proc_family_bimare_bastari", "family", txt_parameter.Text);
                    se.ShowData("dbo.proc_family_bimare_bastari", txt_parameter.Text, "family", Datagridview1);
                }
                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "معاینه")
                {

                    se.Command("proc_shomare_parvande_bimare_moayene", "shomare_parvande_bimar", txt_parameter.Text);
                    se.ShowData("proc_shomare_parvande_bimare_moayene", txt_parameter.Text, "shomare_parvande_bimar", Datagridview1);
                }
                else if (comboBox2.Text == "شماره پرسنلی پزشک" && comboBox1.Text == "معاینه")
                {
                    se.Command("dbo.proc_shomare_personali_pezeshk_moayene", "shomare_personali_pezeshk", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_personali_pezeshk_moayene", txt_parameter.Text, "shomare_personali_pezeshk", Datagridview1);
                }
                else if (comboBox2.Text == "شماره پرونده بیمار" && comboBox1.Text == "تجویز")
                {
                    se.Command("dbo.proc_shomare_parvande_bimare_tajviz", "shomare_parvande_bimare", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_parvande_bimare_tajviz", txt_parameter.Text, "shomare_parvande_bimare", Datagridview1);
                }
                else if (comboBox2.Text == "شماره پرسنلی پزشک" && comboBox1.Text == "تجویز")
                {
                    se.Command("dbo.proc_shomare_personai_pezeshk_tajviz", "shomare_personai_pezeshk", txt_parameter.Text);
                    se.ShowData("dbo.proc_shomare_personai_pezeshk_tajviz", txt_parameter.Text, "shomare_personai_pezeshk", Datagridview1);
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
                string sql;
                sql = string.Format("SELECT name'نام', family'نام خانوادگی', telephon'تلفن', code_rezerv'کد رزرو', noe_rezerv'نوع رزرو', tarikh_sabet'تاریخ ثبت', tarikh_rezerv_shode'تاریخ رزرو', mablagh_pishpardakht'مبلغ پیش پرداخت' FROM dbo.rezerv where noe_rezerv='{0}'", comboBox3.Text);
                se.Command(sql);
                se.ShowData(sql, Datagridview1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "تاریخ انقضا")
            {

                se.Command("dbo.proc_tarike_engheza", "tarike_engheza", msk_date.Text);
                se.ShowData("dbo.proc_tarike_engheza", txt_parameter.Text, "tarike_engheza", Datagridview1);

            }
            else if (comboBox2.Text == "تاریخ تولید")
            {

                se.Command("dbo.proc_tarike_tolid", "tarikh_tolid", msk_date.Text);
                se.ShowData("dbo.proc_tarike_tolid", txt_parameter.Text, "tarikh_tolid", Datagridview1);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}


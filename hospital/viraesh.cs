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
    public partial class viraesh : Form
    {
        public viraesh()
        {
            InitializeComponent();
        }
        first fr = new first();
        second se = new second();

        private void viraesh_Load(object sender, EventArgs e)
        {
            dgv_bimar.ReadOnly = true;
            dgv_daro.ReadOnly = true;
            dgv_margebimar.ReadOnly = true;
            dgv_moayene.ReadOnly = true;
            dgv_parastar.ReadOnly = true;
            dgv_pezeshk.ReadOnly = true;
            dgv_reserv.ReadOnly = true;
            dgv_tajviz.ReadOnly = true;


        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditPezeshk;

            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk", dgv_pezeshk);

        }

        private void dgv_pezeshk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox1.Text = dgv_pezeshk[0, e.RowIndex].Value.ToString();
            TextBox2.Text = dgv_pezeshk[1, e.RowIndex].Value.ToString();
            TextBox3.Text = dgv_pezeshk[2, e.RowIndex].Value.ToString();
            TextBox4.Text = dgv_pezeshk[3, e.RowIndex].Value.ToString();
            TextBox5.Text = dgv_pezeshk[4, e.RowIndex].Value.ToString();
            textBox7.Text = dgv_pezeshk[5, e.RowIndex].Value.ToString();
            textBox8.Text = dgv_pezeshk[6, e.RowIndex].Value.ToString();

        }

        private void TextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void dgv_parastar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox14.Text = dgv_parastar[0, e.RowIndex].Value.ToString();
            textBox13.Text = dgv_parastar[1, e.RowIndex].Value.ToString();
            textBox12.Text = dgv_parastar[2, e.RowIndex].Value.ToString();
            textBox11.Text = dgv_parastar[3, e.RowIndex].Value.ToString();
            textBox9.Text = dgv_parastar[4, e.RowIndex].Value.ToString();
            textBox6.Text = dgv_parastar[5, e.RowIndex].Value.ToString();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditParastar;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', shomare_personali 'شماره پرسنلی ', telephon' تلفن', address 'ادرس' from sabte_parastar", dgv_parastar);

        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {

            business.NumberOnly(e);
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox31_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox33_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox37_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void textBox36_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditDaro;
            se.ShowData("SELECT  name'نام', gheymat 'قیمت ', tarikh_tolid'تاریخ تولید', tarikh_engheza 'تاریخ انقضا ',code_daro'کد دارو' from daro", dgv_daro);
        }

        private void dgv_daro_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgv_daro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox20.Text = dgv_daro[0, e.RowIndex].Value.ToString();
            textBox19.Text = dgv_daro[1, e.RowIndex].Value.ToString();
            maskedTextBox1.Text = dgv_daro[2, e.RowIndex].Value.ToString();
            maskedTextBox2.Text = dgv_daro[3, e.RowIndex].Value.ToString();
            textBox16.Text = dgv_daro[4, e.RowIndex].Value.ToString();

        }

        private void dgv_margebimar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox42.Text = dgv_margebimar[0, e.RowIndex].Value.ToString();
            textBox22.Text = dgv_margebimar[1, e.RowIndex].Value.ToString();
            textBox21.Text = dgv_margebimar[2, e.RowIndex].Value.ToString();
            maskedTextBox3.Text = dgv_margebimar[3, e.RowIndex].Value.ToString();
            textBox15.Text = dgv_margebimar[4, e.RowIndex].Value.ToString();
            textBox24.Text = dgv_margebimar[5, e.RowIndex].Value.ToString();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditMargeBimar;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', shomare_parvande_bimar 'شماره پرونده بیمار', tarikh_foot' تاریخ فوت', shomare_yakhchal 'شماره یخچال',tozihat'توضیحات'  from sardkhone", dgv_margebimar);



        }

        private void dgv_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox30.Text = dgv_reserv[0, e.RowIndex].Value.ToString();
            textBox29.Text = dgv_reserv[1, e.RowIndex].Value.ToString();
            textBox28.Text = dgv_reserv[2, e.RowIndex].Value.ToString();
            textBox27.Text = dgv_reserv[3, e.RowIndex].Value.ToString();
            comboBox1.Text = dgv_reserv[4, e.RowIndex].Value.ToString();
            maskedTextBox4.Text = dgv_reserv[5, e.RowIndex].Value.ToString();
            maskedTextBox5.Text = dgv_reserv[6, e.RowIndex].Value.ToString();
            textBox31.Text = dgv_reserv[7, e.RowIndex].Value.ToString();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditRezerv;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', telephon'تلفن', code_rezerv 'کد رزرو ', noe_rezerv' نوع رزرو', tarikh_sabet'تاریخ ثبت',tarikh_rezerv_shode'تارخ رزرو شده',mablagh_pishpardakht' مبلغ پیش پرداخت' from rezerv", dgv_reserv);



        }

        private void dgv_bimar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox17.Text = dgv_bimar[0, e.RowIndex].Value.ToString();
            textBox18.Text = dgv_bimar[1, e.RowIndex].Value.ToString();
            textBox26.Text = dgv_bimar[2, e.RowIndex].Value.ToString();
            textBox34.Text = dgv_bimar[3, e.RowIndex].Value.ToString();
            textBox33.Text = dgv_bimar[4, e.RowIndex].Value.ToString();
            textBox25.Text = dgv_bimar[5, e.RowIndex].Value.ToString();
            textBox10.Text = dgv_bimar[6, e.RowIndex].Value.ToString();
            comboBox2.Text = dgv_bimar[7, e.RowIndex].Value.ToString();
            textBox32.Text = dgv_bimar[8, e.RowIndex].Value.ToString();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditBimar;
            se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dgv_bimar);


        }

        private void dgv_moayene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox37.Text = dgv_moayene[0, e.RowIndex].Value.ToString();
            textBox36.Text = dgv_moayene[1, e.RowIndex].Value.ToString();
            textBox35.Text = dgv_moayene[2, e.RowIndex].Value.ToString();
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditMoayene;
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',tashkis'تشخیص' from moayene", dgv_moayene);

        }

        private void dgv_tajviz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox41.Text = dgv_tajviz[0, e.RowIndex].Value.ToString();
            textBox38.Text = dgv_tajviz[1, e.RowIndex].Value.ToString();
            textBox39.Text = dgv_tajviz[2, e.RowIndex].Value.ToString();
            textBox40.Text = dgv_tajviz[3, e.RowIndex].Value.ToString();

        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnEditTajviz;
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz", dgv_tajviz);

        }
        private void button10_Click(object sender, EventArgs e)
        {
            business.CloseWindows(this);
        }
      
        private void BtnEditPezeshk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ایا از تغیرات مطمئن هستد؟", "ویرایش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update sabte_pezeshk set name=N'{0}',family=N'{1}',tahsilat=N'{2}',takhasos=N'{3}', shomare_personali_pezeshk=N'{4}',telephon=N'{5}',address=N'{6}'  where  shomare_personali_pezeshk={7}", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, textBox7.Text, textBox8.Text, TextBox5.Text);
                    se.Command(sql);
                    se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk", dgv_pezeshk);
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

        private void BtnEditTajviz_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update tajviz set shomare_parvande_bimar=N'{0}',shomare_personali_pezeshk=N'{1}',code_daro=N'{2}',meghdare_masraf=N'{3}' where shomare_parvande_bimar='{4}' ", textBox41.Text, textBox28.Text, textBox39.Text, textBox40.Text, textBox41.Text);
                    se.Command(sql);
                    se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz", dgv_tajviz);
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

        private void BtnEditParastar_Click(object sender, EventArgs e)
        {
            try

            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update sabte_parastar set name=N'{0}',family=N'{1}',tahsilat=N'{2}', shomare_personali=N'{3}',telephon=N'{4}',address=N'{5}'  where  shomare_personali={6}", textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox9.Text, textBox6.Text, textBox11.Text);
                    se.Command(sql);
                    se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', shomare_personali 'شماره پرسنلی ', telephon' تلفن', address 'ادرس' from sabte_parastar", dgv_parastar);//refreshing data grid

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

        private void BtnEditDaro_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update daro set name=N'{0}',gheymat=N'{1}',tarikh_tolid=N'{2}', tarikh_engheza=N'{3}',code_daro=N'{4}'  where  code_daro={5}", textBox20.Text, textBox19.Text, maskedTextBox2.Text, maskedTextBox1.Text, textBox16.Text, textBox16.Text);
                    se.Command(sql);
                    se.ShowData("SELECT  name'نام', gheymat 'قیمت ', tarikh_tolid'تاریخ تولید', tarikh_engheza 'تاریخ انقضا ',code_daro'کد دارو' from daro", dgv_daro);
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

        private void BtnEditRezerv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update rezerv set name=N'{0}',family=N'{1}',telephon=N'{2}',code_rezerv=N'{3}', noe_rezerv=N'{4}',tarikh_sabet=N'{5}',tarikh_rezerv_shode=N'{6}',mablagh_pishpardakht=N'{7}'  where  code_rezerv={8}", textBox30.Text, textBox29.Text, textBox28.Text, textBox27.Text, comboBox1.Text, maskedTextBox4.Text, maskedTextBox5.Text, textBox31.Text, textBox27.Text);
                    se.Command(sql);
                    se.ShowData("SELECT  name'نام', family 'نام خانوادگی', telephon'تلفن', code_rezerv ' کد رزرو ', noe_rezerv' نوع رزرو', tarikh_sabet'تاریخ ثبت',tarikh_rezerv_shode'تارخ رزرو شده',mablagh_pishpardakht' مبلغ پیش پرداخت' from rezerv", dgv_reserv);

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

        private void BtnEditMargeBimar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update sardkhone set name=N'{0}',family=N'{1}',shomare_parvande_bimar=N'{2}', tarikh_foot=N'{3}',shomare_yakhchal=N'{4}',tozihat=N'{5}'  where  shomare_parvande_bimar='{6}'", textBox42.Text, textBox22.Text, textBox21.Text, maskedTextBox3.Text, textBox15.Text, textBox24.Text, textBox21.Text);
                    se.Command(sql);
                    se.ShowData("SELECT  name'نام', family 'نام خانوادگی', shomare_parvande_bimar 'شماره پرونده بیمار', tarikh_foot' تاریخ فوت', shomare_yakhchal 'شماره یخچال',tozihat'توضیحات'  from sardkhone", dgv_margebimar);

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

        private void BtnEditBimar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update bimar set name=N'{0}',family=N'{1}',telephone=N'{2}',address=N'{3}', shomare_parvande_bimar=N'{4}',shomare_takht=N'{5}',shomare_otagh=N'{6}',bime=N'{7}',tarikh_bastari=N'{8}'  where  shomare_parvande_bimar={9}", textBox17.Text, textBox18.Text, textBox26.Text, textBox34.Text, textBox33.Text, textBox25.Text, textBox10.Text, comboBox2.Text, textBox32.Text, textBox33.Text);
                    se.Command(sql);
                    se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dgv_bimar);
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

        private void BtnEditMoayene_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("update moayene set shomare_parvande_bimar=N'{0}',shomare_personali_pezeshk=N'{1}',tashkis=N'{2}' where shomare_parvande_bimar='{3}' ", textBox37.Text, textBox36.Text, textBox35.Text, textBox37.Text);
                    se.Command(sql);
                    se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',tashkis'تشخیص' from moayene", dgv_moayene);

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

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }
    }
}


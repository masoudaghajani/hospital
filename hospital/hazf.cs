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
    public partial class hazf : Form
    {
        public hazf()
        {
            InitializeComponent();
        }

        second se = new second();
        
       

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

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnHazfePezeshk;

            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', takhasos'تخصص', shomare_personali_pezeshk 'شماره پرسنلی پزشک', telephon' تلفن', address 'ادرس' from sabte_pezeshk", dgv_pezeshk);
        }

        

     
        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("ایا میخواهید از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (d == DialogResult.Yes)
            {
                this.Close();

            }
            else if (d == DialogResult.Cancel)
            {
                this.Hide();

            }
        }

      

        private void tabPage2_Enter_1(object sender, EventArgs e)
        {
            AcceptButton = BtnHazfeParastar;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', tahsilat'تحصیلات', shomare_personali 'شماره پرسنلی ', telephon' تلفن', address 'ادرس' from sabte_parastar", dgv_parastar);

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

       

        private void tabPage3_Enter(object sender, EventArgs e)
        {

            AcceptButton = BtnHazfeDaro;
            se.ShowData("SELECT  name'نام', gheymat 'قیمت ', tarikh_tolid'تاریخ تولید', tarikh_engheza 'تاریخ انقضا ',code_daro'کد دارو' from daro", dgv_daro);
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
            AcceptButton = BtnHazfeMargeBimar;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', shomare_parvande_bimar 'شماره پرونده بیمار', tarikh_foot' تاریخ فوت', shomare_yakhchal 'شماره یخچال',tozihat'توضیحات'  from sardkhone", dgv_margebimar);
        }

       

        private void dgv_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox30.Text = dgv_reserv[0, e.RowIndex].Value.ToString();
            textBox29.Text = dgv_reserv[1, e.RowIndex].Value.ToString();
            textBox28.Text = dgv_reserv[2, e.RowIndex].Value.ToString();
            textBox27.Text = dgv_reserv[3, e.RowIndex].Value.ToString();
            textBox43.Text = dgv_reserv[4, e.RowIndex].Value.ToString();
            maskedTextBox4.Text = dgv_reserv[5, e.RowIndex].Value.ToString();
            maskedTextBox5.Text = dgv_reserv[6, e.RowIndex].Value.ToString();
            textBox31.Text = dgv_reserv[7, e.RowIndex].Value.ToString();
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            AcceptButton = BtnHazfeReserv;
            se.ShowData("SELECT  name'نام', family 'نام خانوادگی', telephon'تلفن', code_rezerv 'کد رزرو ', noe_rezerv' نوع رزرو', tarikh_sabet'تاریخ ثبت',tarikh_rezerv_shode'تارخ رزرو شده',mablagh_pishpardakht' مبلغ پیش پرداخت' from rezerv", dgv_reserv);

        }

       

        private void dgv_bimar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox47.Text = dgv_bimar[0, e.RowIndex].Value.ToString();
            textBox48.Text = dgv_bimar[1, e.RowIndex].Value.ToString();
            textBox50.Text = dgv_bimar[2, e.RowIndex].Value.ToString();
            textBox53.Text = dgv_bimar[3, e.RowIndex].Value.ToString();
            textBox52.Text = dgv_bimar[4, e.RowIndex].Value.ToString();
            textBox49.Text = dgv_bimar[5, e.RowIndex].Value.ToString();
            textBox46.Text = dgv_bimar[6, e.RowIndex].Value.ToString();
            textBox45.Text = dgv_bimar[7, e.RowIndex].Value.ToString();
            textBox51.Text = dgv_bimar[8, e.RowIndex].Value.ToString();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            AcceptButton = button6;
            se.ShowData("select name'نام',family'نام خوانوادگی',telephone'تلفن',address'ادرس',shomare_parvande_bimar'شماره پرونده بیمار',shomare_takht'شماره تخت',shomare_otagh'شماره اتاق',bime'بیمه',tarikh_bastari'تاریخ بستری' from bimar", dgv_bimar);
        }

    
        private void tabPage7_Enter(object sender, EventArgs e)
        {
            AcceptButton = button7;
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',tashkis'تشخیص' from moayene", dgv_moayene);

        }

        private void dgv_moayene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox56.Text = dgv_moayene[0, e.RowIndex].Value.ToString();
            textBox55.Text = dgv_moayene[1, e.RowIndex].Value.ToString();
            textBox54.Text = dgv_moayene[2, e.RowIndex].Value.ToString();
        }

       

        private void dgv_tajviz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox60.Text = dgv_tajviz[0, e.RowIndex].Value.ToString();
            textBox57.Text = dgv_tajviz[1, e.RowIndex].Value.ToString();
            textBox58.Text = dgv_tajviz[2, e.RowIndex].Value.ToString();
            textBox59.Text = dgv_tajviz[3, e.RowIndex].Value.ToString();

        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            AcceptButton = button8;
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',shomare_personali_pezeshk'شماره پرسنلی پزشک',code_daro'کد دارو',meghdare_masraf'مقدار مصرف' from tajviz", dgv_tajviz);
        }

        private void hazf_Load(object sender, EventArgs e)
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

        private void BtnHazfePezeshk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ایا  مطمئن هستد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from sabte_pezeshk where shomare_personali_pezeshk='{0}'", TextBox5.Text);
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

        private void BtnHazfeParastar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete sabte_parastar where shomare_personali='{0}'", textBox11.Text);
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

        private void BtnHazfeDaro_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from daro where code_daro ='{0}'", textBox16.Text);
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

        private void BtnHazfeMoayene_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from moayene where shomare_parvande_bimar='{0}'", textBox37.Text);
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

        private void BtnHazfeBimar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from bimar where shomare_parvande_bimar='{0}' ", textBox33.Text);
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

        private void BtnHazfeReserv_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from rezerv where code_rezerv='{0}'", textBox27.Text);
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

        private void BtnHazfeMargeBimar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from sardkhone where shomare_parvande_bimar='{0}'", textBox21.Text);
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

        private void BtnHazfeTajviz_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from tajviz where shomare_parvande_bimar='{0}'", textBox41.Text);
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

        private void button21_Click(object sender, EventArgs e)
        {
            business.CloseWindows(this);
        }

       
    }
}

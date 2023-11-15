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
            AcceptButton = Button1;

            se.ShowData("proc_pezeshk", dgv_pezeshk);
            sabt_Load(null, null);

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            AcceptButton = button2;
            se.ShowData("proc_parastar", dgv_parastar);
            sabt_Load(null, null);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            AcceptButton = button3;
            se.ShowData("proc_daro", dgv_daro);
            sabt_Load(null, null);

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            AcceptButton = button4;
            se.ShowData("prce_margbimar", dgv_margebimar);
            sabt_Load(null, null);

        }



        private void button5_Enter(object sender, EventArgs e)
        {
            AcceptButton = button5;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (TextBox1.Text == "" || TextBox5.Text == "" || TextBox5.Text == "" || PictureLocation == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string sql = string.Format("insert  into sabte_pezeshk (name,family,tahsilat,takhasos,shomare_personali_pezeshk,telephon,address,picture)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}','{7}')", TextBox1.Text, TextBox2.Text, comboBox3.Text, comboBox2.Text, TextBox5.Text, textBox7.Text, textBox8.Text, PictureLocation);
                    se.Command(sql);
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    comboBox3.Text = "";
                    TextBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    comboBox2.Text = null;
                    TextBox1.Select();


                }

                se.ShowData("proc_pezeshk", dgv_pezeshk);

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


        private void sabt_Load(object sender, EventArgs e)
        {
            dgv_daro.ReadOnly = true;
            dgv_margebimar.ReadOnly = true;
            dgv_parastar.ReadOnly = true;
            dgv_pezeshk.ReadOnly = true;
            dgv_reserv.ReadOnly = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            second se = new second();
            try
            {
                if (textBox14.Text == "" || textBox13.Text == "" || textBox11.Text == "" || PictureLocation == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {


                    string sql = string.Format("insert  into sabte_parastar (name,family,tahsilat,shomare_personali,telephon,address)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                        , textBox14.Text, textBox13.Text, textBox12.Text, textBox11.Text, textBox9.Text, textBox6.Text);
                    se.Command(sql);
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    se.ShowData("proc_parastar", dgv_parastar);

                }
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

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox16.Text == "" || textBox20.Text == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    second se = new second();
                    string sql = string.Format("insert  into daro (name,gheymat,tarikh_tolid,tarikh_engheza,code_daro)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')"

                        , textBox20.Text, textBox19.Text, maskedTextBox2.Text, maskedTextBox1.Text, textBox16.Text);
                    se.Command(sql);
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    se.ShowData("proc_daro", dgv_daro);//refresh datagrid

                }
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

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox23.Text == "" || textBox22.Text == "" || textBox21.Text == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    second se = new second();
                    string sql = string.Format("insert  into sardkhone (name,family,shomare_parvande_bimar,tarikh_foot,shomare_yakhchal,tozihat)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')"
                        , textBox23.Text, textBox22.Text, textBox21.Text, maskedTextBox3.Text, textBox15.Text, textBox24.Text);
                    se.Command(sql);
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    se.ShowData("prce_margbimar", dgv_margebimar);

                }
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

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox30.Text == "" || textBox29.Text == "" || textBox27.Text == "")
                {
                    DialogResult resualt;
                    resualt = MessageBox.Show("!فیلدی را خالی گزاشته اید لطفا اطلاعات را کامل کنید", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    second se = new second();
                    string sql = string.Format("insert  into rezerv (name,family,telephon,code_rezerv,noe_rezerv,tarikh_sabet,tarikh_rezerv_shode,mablagh_pishpardakht )values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')",
                        textBox30.Text, textBox29.Text, textBox28.Text, textBox27.Text, comboBox1.Text, maskedTextBox4.Text, maskedTextBox5.Text, textBox31.Text);
                    se.Command(sql);
                    MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    se.ShowData("proc_rezerv", dgv_reserv);



                }
            }
            catch (Exception ex)
            {
                if (textBox27.Text == "")
                {
                    MessageBox.Show("کد رزرو را وارد کنید");
                }
                else
                {
                    MessageBox.Show(ex.Message);


                }
            }
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            AcceptButton = button5;
            se.ShowData("proc_rezerv", dgv_reserv);
            sabt_Load(null, null);
        }


        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }


        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void textBox31_KeyDown(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string PictureLocation = "";
        private void button7_Click(object sender, EventArgs e)
        {
            int a = Picture.Pic(this);
            pictureBox1.ImageLocation = Picture.Location;
            PictureLocation = Picture.Location;

        }



        private void button8_Click(object sender, EventArgs e)
        {
            se.farsikeyboard();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            se.farsikeyboard();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            se.farsikeyboard();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            se.farsikeyboard();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            se.farsikeyboard();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);

        }

        private void textBox7_KeyDown_1(object sender, KeyEventArgs e)
        {
            se.numberonly(e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

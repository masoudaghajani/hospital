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

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ایا  مطمئن هستد؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from sabte_pezeshk where shomare_personali_pezeshk='{0}'", TextBox5.Text);
                    se.Command(sql);
                    se.ShowData("proc_pezeshk", dgv_pezeshk);
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
            AcceptButton = Button1;
            se.ShowData("proc_pezeshk", dgv_pezeshk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete sabte_parastar where shomare_personali='{0}'", textBox11.Text);
                    se.Command(sql);
                    se.ShowData("proc_parastar", dgv_parastar);//refreshing data grid

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

        private void button16_Click(object sender, EventArgs e)
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

        private void button15_Click(object sender, EventArgs e)
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

        private void button13_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
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
            AcceptButton = button2;
            se.ShowData("proc_parastar", dgv_parastar);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from daro where code_daro ='{0}'", textBox16.Text);
                    se.Command(sql);
                    se.ShowData("proc_daro", dgv_daro);
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

        private void tabPage3_Enter(object sender, EventArgs e)
        {

            AcceptButton = button3;
            se.ShowData("proc_daro", dgv_daro);
        }

        private void dgv_daro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox20.Text = dgv_daro[0, e.RowIndex].Value.ToString();
            textBox19.Text = dgv_daro[1, e.RowIndex].Value.ToString();
            maskedTextBox1.Text = dgv_daro[2, e.RowIndex].Value.ToString();
            maskedTextBox2.Text = dgv_daro[3, e.RowIndex].Value.ToString();
            textBox16.Text = dgv_daro[4, e.RowIndex].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from sardkhone where shomare_parvande_bimar='{0}'", textBox21.Text);
                    se.Command(sql);
                    se.ShowData("prce_margbimar", dgv_margebimar);

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
            AcceptButton = button4;
            se.ShowData("prce_margbimar", dgv_margebimar);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from rezerv where code_rezerv='{0}'", textBox27.Text);
                    se.Command(sql);
                    se.ShowData("proc_rezerv", dgv_reserv);

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
            AcceptButton = button5;
            se.ShowData("proc_rezerv", dgv_reserv);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from bimar where shomare_parvande_bimar='{0}' ", textBox33.Text);
                    se.Command(sql);
                    se.ShowData("proc_pazireshbimar", dgv_bimar);
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

        private void dgv_bimar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox17.Text = dgv_bimar[0, e.RowIndex].Value.ToString();
            textBox18.Text = dgv_bimar[1, e.RowIndex].Value.ToString();
            textBox26.Text = dgv_bimar[2, e.RowIndex].Value.ToString();
            textBox34.Text = dgv_bimar[3, e.RowIndex].Value.ToString();
            textBox33.Text = dgv_bimar[4, e.RowIndex].Value.ToString();
            textBox25.Text = dgv_bimar[5, e.RowIndex].Value.ToString();
            textBox10.Text = dgv_bimar[6, e.RowIndex].Value.ToString();
            textBox44.Text = dgv_bimar[7, e.RowIndex].Value.ToString();
            textBox32.Text = dgv_bimar[8, e.RowIndex].Value.ToString();
        }

        private void tabPage6_Enter(object sender, EventArgs e)
        {
            AcceptButton = button6;
            se.ShowData("proc_pazireshbimar", dgv_bimar);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from moayene where shomare_parvande_bimar='{0}'", textBox37.Text);
                    se.Command(sql);
                    se.ShowData("proc_moayene", dgv_moayene);

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

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            AcceptButton = button7;
            se.ShowData("proc_moayene", dgv_moayene);

        }

        private void dgv_moayene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox37.Text = dgv_moayene[0, e.RowIndex].Value.ToString();
            textBox36.Text = dgv_moayene[1, e.RowIndex].Value.ToString();
            textBox35.Text = dgv_moayene[2, e.RowIndex].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("ايا از تغيرات مطمئن هستد؟", "ويرايش", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (d == DialogResult.Yes)
                {
                    string sql = string.Format("delete from tajviz where shomare_parvande_bimar='{0}'", textBox41.Text);
                    se.Command(sql);
                    se.ShowData("proc_tajviz", dgv_tajviz);
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

        private void dgv_tajviz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox41.Text = dgv_tajviz[0, e.RowIndex].Value.ToString();
            textBox38.Text = dgv_tajviz[1, e.RowIndex].Value.ToString();
            textBox39.Text = dgv_tajviz[2, e.RowIndex].Value.ToString();
            textBox40.Text = dgv_tajviz[3, e.RowIndex].Value.ToString();

        }

        private void tabPage8_Enter(object sender, EventArgs e)
        {
            AcceptButton = button8;
            se.ShowData("proc_tajviz", dgv_tajviz);
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

        private void dgv_pezeshk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_parvande_bimar_footshode", "shomare_parvande_bimar", textBox45.Text);
            se.ShowData("dbo.proc_shomare_parvande_bimar_footshode", textBox45.Text, "shomare_parvande_bimar", dgv_tajviz);
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_personali_pezeshk", "shomare_personali_pezeshk", textBox46.Text);
            se.ShowData("dbo.proc_tarike_engheza", textBox46.Text, "tarike_engheza", dgv_tajviz);
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_parvande_bimar_footshode", "shomare_parvande_bimar", textBox48.Text);
            se.ShowData("dbo.proc_shomare_parvande_bimar_footshode", textBox48.Text, "shomare_parvande_bimar",  dgv_moayene);

        }



        private void textBox47_TextChanged_1(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_personali_pezeshk", "shomare_personali_pezeshk", textBox47.Text);
            se.ShowData("dbo.proc_tarike_engheza", textBox47.Text, "tarike_engheza", dgv_moayene);
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_parvande_bimar", "shomare_parvande_bimar", textBox49.Text);
            se.ShowData("dbo.proc_shomare_parvande_bimar", textBox49.Text, "shomare_parvande_bimar", dgv_bimar);
        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_code_rezerv", "code_rezerv", textBox50.Text);
            se.ShowData("dbo.proc_code_rezerv", textBox50.Text, "code_rezerv", dgv_reserv);
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_parvande_bimar_footshode", "shomare_parvande_bimar", textBox51.Text);
            se.ShowData("dbo.proc_shomare_parvande_bimar_footshode", textBox51.Text, "shomare_parvande_bimar", dgv_margebimar);
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_code_daro", "code_daro", textBox52.Text);
            se.ShowData("dbo.proc_code_daro", textBox52.Text, "code_daro", dgv_daro);

        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_personali", "shomare_personali", textBox53.Text);
            se.ShowData("dbo.proc_shomare_personali", textBox53.Text, "shomare_personali", dgv_parastar);
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            se.Command("dbo.proc_shomare_personali_pezeshk", "shomare_personali_pezeshk", textBox54.Text);
            se.ShowData("dbo.proc_shomare_personali_pezeshk", textBox54.Text, "shomare_personali_pezeshk", dgv_pezeshk);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

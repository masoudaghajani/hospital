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
    public partial class maly : Form
    {
        public maly()
        {
            InitializeComponent();
        }
        second se = new second();

        private void maly_Load(object sender, EventArgs e)
        {
            AcceptButton = btnSabteMaly;
            TextBox1.Select();
            se.ShowData("select shomare_parvande_bimar'شماره پرونده بیمار',hazine_takht'هزینه تخت',hazine_ghaza'هزینه غذا',hazine_digar'هزینه دیگر',bime'بیمه',daro'دارو' from maly_bimar", dataGridView1);
        }
        private void TextBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void TextBox3_KeyDown_1(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void TextBox4_KeyDown_1(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void TextBox5_KeyDown_1(object sender, KeyEventArgs e)
        {
            business.NumberOnly(e);
        }

        private void btnSabteMaly_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = string.Format("insert  into maly_bimar (shomare_parvande_bimar,hazine_takht,hazine_ghaza,hazine_digar,bime,daro)values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, comboBox1.Text, TextBox5.Text);
                se.Command(sql);
                MessageBox.Show("ثبت شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox3.Text = null;
                TextBox4.Text = null;
                TextBox5.Text = null;
                comboBox1.Text = null;
                TextBox1.Select();
                maly_Load(null, null);

            }
            catch (Exception ex)
            {

                if (TextBox1.Text == null)
                {
                    MessageBox.Show("شماره پرونده را وارد  کنید");
                }

                else
                {
                    MessageBox.Show(ex.Message);
                }
                maly_Load(null, null);

            }
        }
    }
}

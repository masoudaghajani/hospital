using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace hospital
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public static int si = 0;
     
        private void main_Load(object sender, EventArgs e)
        {
            log_in frm = new log_in();

            string str = business.LoginInfo.Semat;
            switch (str)
            {
                case "مالی":
                    مالیToolStripMenuItem.Enabled = true;
                    ثبتToolStripMenuItem.Enabled = false;
               
                    پذیرشToolStripMenuItem.Enabled = false;
                    ویرایشToolStripMenuItem.Enabled = false;
                    حدفاطلاعاتToolStripMenuItem.Enabled = false;
                    گزارشToolStripMenuItem.Enabled = false;
                    تنظیماتToolStripMenuItem.Enabled = false;
                    تغیررمزToolStripMenuItem.Enabled = false;
                    break ;
                case "مدیر":
                    ثبتToolStripMenuItem.Enabled = true;
                    مالیToolStripMenuItem.Enabled = true;
                    پذیرشToolStripMenuItem.Enabled = true;
                    ویرایشToolStripMenuItem.Enabled = true;
                    حدفاطلاعاتToolStripMenuItem.Enabled = true;
                    گزارشToolStripMenuItem.Enabled = true;
                    تنظیماتToolStripMenuItem.Enabled = true;
                    تغیررمزToolStripMenuItem.Enabled = true;
                    break;
                case "عادی":
                    تغیررمزToolStripMenuItem.Enabled = false;
                    ثبتToolStripMenuItem.Enabled = true;           
                    پذیرشToolStripMenuItem.Enabled = true;
                    ویرایشToolStripMenuItem.Enabled = true;           
                    تنظیماتToolStripMenuItem.Enabled = true;
                    مالیToolStripMenuItem.Enabled = false;
                    حدفاطلاعاتToolStripMenuItem.Enabled = false;
                    گزارشToolStripMenuItem.Enabled = false;
                    اضافهکردنکاربرToolStripMenuItem.Enabled = false;


                    break;
            }


            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            PersianCalendar ps = new PersianCalendar();
            lbltime.Text = string.Format("{2} : {1} : {0}   ", ps.GetHour(Time), ps.GetMinute(Time), ps.GetSecond(Time));
        }

        private void اضافهکردنکاربرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            newuser frm = new newuser();
          
            frm.tabControl1.SelectTab(0);
           
            frm.ShowDialog();
          

        }

        private void تغیررمزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newuser frm = new newuser();
            frm.tabControl1.SelectTab(1);
            frm.ShowDialog();
            
           
        }

        private void بیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {

            paziresh frm = new paziresh();
            frm.tabControl1.SelectTab(0);
            frm.ShowDialog();
         
          

        }

        private void معاینهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paziresh frm = new paziresh();
            frm.tabControl1.SelectTab(1);
            frm.ShowDialog();
           
        }

        private void تجویزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paziresh frm = new paziresh();
            frm.tabControl1.SelectTab(2);
            frm.ShowDialog();
           
        }

      

        private void پزشکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabt frm = new sabt();
            frm.TabControl.SelectTab(0);
            frm.ShowDialog();
        }

        private void پرستارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabt frm = new sabt();
            frm.TabControl.SelectTab(1);
            frm.ShowDialog();
        }

        private void داروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabt frm = new sabt();
            frm.TabControl.SelectTab(2);
            frm.ShowDialog();
        }

        private void مرگبیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabt frm = new sabt();
            frm.TabControl.SelectTab(3);
            frm.ShowDialog();
        }

        private void رزروتختToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sabt frm = new sabt();
            frm.TabControl.SelectTab(4);
            frm.ShowDialog();
        }

       
        private void تسوییهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maly frm = new maly();
            frm.ShowDialog();
        }

       

        private void پزشکToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(0);
            frm.BtnEditPezeshk.Enabled = true;
            frm.button16.Enabled = true;

            frm.ShowDialog();
        }

        private void پرستارToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(1);
            frm.BtnEditParastar.Enabled = true;
            frm.button15.Enabled = true;

            frm.ShowDialog();
        }

        private void داروToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(2);
            frm.BtnEditDaro.Enabled = true;
            frm.button14.Enabled = true;


            frm.ShowDialog();
        }

        private void مرگبیمارToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(3);
            frm.BtnEditMargeBimar.Enabled = true;
            frm.button13.Enabled = true;

            frm.ShowDialog();
        }

        private void رزروتختToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(4);
            frm.BtnEditRezerv.Enabled = true;
            frm.button12.Enabled = true;


            frm.ShowDialog();
        }

        private void پذیرشبیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(5);
            frm.BtnEditBimar.Enabled = true;
            frm.button11.Enabled = true;

            frm.ShowDialog();
        }

        private void معاینهToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(6);
            frm.BtnEditMoayene.Enabled = true;
            frm.button9.Enabled = true;

            frm.ShowDialog();


        }

        private void تجویزToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            viraesh frm = new viraesh();
            frm.tabControl1.SelectTab(7);
            frm.BtnEditTajviz.Enabled = true;
            frm.button10.Enabled = true;

            frm.ShowDialog();
        }

        private void حدفاطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void پزشکToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            hazf frm = new hazf();
            frm.tabControl1.SelectTab(0);
            frm.BtnHazfePezeshk.Enabled = true;
            frm.button16.Enabled = true;
            frm.ShowDialog();
        }

        private void پرستارToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(1);
            frm.BtnHazfeParastar.Enabled = true;
            frm.button15.Enabled = true;
            frm.ShowDialog();
        }

        private void داروToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(2);
            frm.BtnHazfeDaro.Enabled = true;
            frm.button14.Enabled = true;
            frm.ShowDialog();
        }

        private void رزروتختToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(4);
            frm.BtnHazfeReserv.Enabled = true;
            frm.button12.Enabled = true;
            frm.ShowDialog();
        }

        private void مرگبیمارToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(3);
            frm.BtnHazfeMargeBimar.Enabled = true;
            frm.button13.Enabled = true;
            frm.ShowDialog();
        }

        private void پذیرشبیمارToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(5);
            frm.BtnHazfeBimar.Enabled = true;
            frm.button11.Enabled = true;
            frm.ShowDialog();
        }

        private void معاینهToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(6);
            frm.BtnHazfeMoayene.Enabled = true;
            frm.button9.Enabled = true;
            frm.ShowDialog();
        }

        private void تجویزToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            hazf frm = new hazf();
            frm.tabControl1.SelectTab(7);
            frm.BtnHazfeTajviz.Enabled = true;
            frm.button10.Enabled = true;
            frm.ShowDialog();
        }

        private void گزارشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gozaresh frm = new gozaresh();
            frm.ShowDialog();
        }

        private void دربارهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about frm = new about();
            frm.ShowDialog();
        }

       
        private void ماشینحسابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void عدمنمایشساعتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbltime.Visible==true)
            {
                lbltime.Visible = false;
            }
            else
            {
                lbltime.Visible = true;
            }
           
        }

        private void سایتبیمارستانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.taleghani.com");
        }

        private void تغییرتصویرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ODI = new OpenFileDialog();
            ODI.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            ODI.Filter = "Picture As jpg|*.jpg|Picture As jpeg|*.jpeg*|Picture As bmp|*.bmp|Picture As gif|*.gif|Picture As wmf|*.wmf|Picture As png|*.png";

            if (ODI.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ODI.FileName;
            }
        }

        private void تصویربهاندازهیصفحهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void تصویردروسطصفحهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void تصویربهبهاندازهاصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string Lstr = "hospital manegment program     ";
                if (this.Text.ToString().Length < Lstr.Length)
                {
                    this.Text = Lstr.Substring(0, si) + "_";
                    si += 1;
                }
                else
                {
                    this.Text = "";
                    si = 0;
                }
            }
            catch { }
        }

       

       
    }
}

using System.Windows.Forms;

namespace hospital
{
   public  class business
    {
        public static void CloseWindows(Form frm)
        {
            DialogResult d;
            d = MessageBox.Show("ایا میخواهید از برنامه خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (d == DialogResult.Yes)
            {
                frm.Close();

            }
            else if (d == DialogResult.Cancel)
            {
                frm.Hide();

            }
        }
       public static void NumberOnly(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }
        public static class LoginInfo
        {
            public static string Semat;
        }
        public static class PrintQuery
        {
            public static string StrPrintQuery;
        }
    }
   
}


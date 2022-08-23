using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project2_ClassLibrary1
;

namespace Project3_WindowsForms
{
    public partial class New_User : Form
    {
        public New_User()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }


        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Password user = new Password();
            string result = user.Create_MyPassword(txt_Username.Text, txt_Password.Text);
            MessageBox.Show(result);
        }
    }
}

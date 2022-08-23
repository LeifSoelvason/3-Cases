using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project2_ClassLibrary1;
using System.IO;

namespace Project3_WindowsForms
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = checkBox1.Checked ? '\0':'*';
        }     

        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            Password user3 = new Password();
            bool result = user3.Login(txt_Username.Text, txt_Password.Text);
            if (result == true && !String.IsNullOrWhiteSpace(txt_Username.Text) && !String.IsNullOrEmpty(txt_Password.Text))
            {
                this.Hide();
                Home user4 = new Home();
                user4.Show();
                MessageBox.Show(("Welcome ") + txt_Username.Text);
            }
            else
                MessageBox.Show("username or password was incorrect");
        }

        private void Btn_New_User_Click(object sender, EventArgs e)
        {
            this.Hide();

            New_User x = new New_User();

            x.Show();
        }
    }
}

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
    public partial class Change_Password_Form : Form
    {
        public Change_Password_Form()
        {
            InitializeComponent();
        }     

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Password user5 = new Password();
            string result = user5.Change_Password(txt_Old_Password.Text, txt_New_Password.Text);
            MessageBox.Show(result);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_New_Password.PasswordChar = checkBox1.Checked ? '\0' : '*';           
        }
    }
}

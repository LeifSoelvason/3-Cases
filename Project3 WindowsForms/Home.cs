using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_WindowsForms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Btn_Football_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_Football x = new txt_Football();
            x.Show();
        }

        private void Btn_Dancer_Click(object sender, EventArgs e)
        {
            this.Close();
            txt_Dancer x = new txt_Dancer();
            x.Show();
        }

        private void Btn_Change_Password_Click(object sender, EventArgs e)
        {
            this.Close();
            Change_Password_Form x = new Change_Password_Form();
            x.Show();
        }
    }
}

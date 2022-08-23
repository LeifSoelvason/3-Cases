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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Udskriv_Click(object sender, EventArgs e)
        {
            //int antalAfleveringer = int.Parse(txtAntalAfleveringer.Text) virkede ikke, da man ikke kan Parse et tomt felt. Derfor bruges TryParse med bool/int istedet.

            bool antalAfleveringer = int.TryParse(txtAntalAfleveringer.Text, out int result);

            string målforsøg = txt_Målforsøg.Text;


            if (målforsøg == "mål")
            {
                lbl_Udskriv.Text = "Ole ole ole";
            }
            else if (result < 1)
            {
                lbl_Udskriv.Text = "Shh";
            }

            else if (result >= 1 && result < 10)
            {
                lbl_Udskriv.Text = "Huh!";
            }
            else if (result >= 10)
            {
                lbl_Udskriv.Text = "High Five – Jubel!!!";
            }
                      
        }

        private void txt_Målforsøg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAntalAfleveringer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

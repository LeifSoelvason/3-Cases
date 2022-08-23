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


namespace Project3_WindowsForms
{
    public partial class txt_Football : Form
    {
        public txt_Football()
        {
            InitializeComponent();
        }

        private void Btn_Vis_Click(object sender, EventArgs e)
        {
            //Note til mig selv: Da jeg brugte int.Parse crasher systemet fordi den prøver at parse selvom feltet er tomt. Når jeg bruger TryParse istedet virker det.

            Football myGame = new Football();
            bool antalafleveringer = int.TryParse(Txt_AntalAfleveringer.Text, out int afleveringer);
            resultat.Text = myGame.Mål(afleveringer, Txt_Målforsøg.Text.ToLower());
        }

        private void Txt_Målforsøg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_AntalAfleveringer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Næste_Form_Click(object sender, EventArgs e)
        {
            this.Close();

            txt_Dancer d2 = new txt_Dancer();

            d2.Show();
        }

        private void Txt_AntalAfleveringer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

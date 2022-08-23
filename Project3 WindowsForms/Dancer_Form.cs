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
    public partial class txt_Dancer : Form
    {


        public txt_Dancer()
        {
            InitializeComponent();

        }
        private class Person
        {
            public string Name { get; set; }
            public int Point { get; set; } = 0;
        }      
                 

        private void Btn_Vis_Click(object sender, EventArgs e)
        {
            int point;

            var person1 = new Person();
            person1.Name = Txt_FirstDancer_Name.Text;
            bool succes = int.TryParse(person1.Name, out point);

            if (succes) person1.Point = point;

            point = 0;
            succes = false;

            var person2 = new Person();
            person2.Name = Txt_SecondDancer_Name.Text;
            succes = int.TryParse(person2.Name, out point);

            if (succes) person2.Point = point;


            bool firstDancer_points = int.TryParse(Txt_FirstDancer_Points.Text, out int points1);
            bool secondDancer_points = int.TryParse(Txt_SecondDancer_Points.Text, out int points2);


            Dancer Person1 = new Dancer(person1.Name, points1);

            Dancer Person2 = new Dancer(person2.Name, points2);

            Dancer Person3 = new Dancer();

            Person1._Points = points1;
            Person2._Points = points2;
            Person1.Name = person1.Name;
            Person2.Name = person2.Name;

            Person3 = Person1 + Person2;

            // resultat of Dancer 3


            txt_resultat.Text = $"{Person3.Name} fik tilsammen {Person3._Points} point.";
        }

        private void Forrige_Click(object sender, EventArgs e)
        {
            this.Hide();

            txt_Football f1 = new txt_Football();

            f1.Show();
        }

        private void Txt_FirstDancer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_FirstDancer_Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_SecondDancer_Name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_SecondDancer_Points_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


        
        
    


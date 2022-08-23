namespace Project3_WindowsForms
{
    partial class txt_Dancer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resultat = new System.Windows.Forms.Label();
            this.Txt_SecondDancer_Points = new System.Windows.Forms.TextBox();
            this.Btn_Vis = new System.Windows.Forms.Button();
            this.Txt_Forrige = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_FirstDancer_Points = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SecondDancer_Name = new System.Windows.Forms.TextBox();
            this.Txt_FirstDancer_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anden danser, Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Første danser, Point:";
            // 
            // txt_resultat
            // 
            this.txt_resultat.AutoSize = true;
            this.txt_resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultat.Location = new System.Drawing.Point(53, 339);
            this.txt_resultat.Name = "txt_resultat";
            this.txt_resultat.Size = new System.Drawing.Size(138, 24);
            this.txt_resultat.TabIndex = 2;
            this.txt_resultat.Text = "Samlet Resultat";
            // 
            // Txt_SecondDancer_Points
            // 
            this.Txt_SecondDancer_Points.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Txt_SecondDancer_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SecondDancer_Points.Location = new System.Drawing.Point(474, 190);
            this.Txt_SecondDancer_Points.Name = "Txt_SecondDancer_Points";
            this.Txt_SecondDancer_Points.Size = new System.Drawing.Size(100, 29);
            this.Txt_SecondDancer_Points.TabIndex = 4;
            this.Txt_SecondDancer_Points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SecondDancer_Points_KeyPress);
            // 
            // Btn_Vis
            // 
            this.Btn_Vis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vis.Location = new System.Drawing.Point(496, 256);
            this.Btn_Vis.Name = "Btn_Vis";
            this.Btn_Vis.Size = new System.Drawing.Size(78, 37);
            this.Btn_Vis.TabIndex = 5;
            this.Btn_Vis.Text = "Vis";
            this.Btn_Vis.UseVisualStyleBackColor = true;
            this.Btn_Vis.Click += new System.EventHandler(this.Btn_Vis_Click);
            // 
            // Txt_Forrige
            // 
            this.Txt_Forrige.Location = new System.Drawing.Point(661, 385);
            this.Txt_Forrige.Name = "Txt_Forrige";
            this.Txt_Forrige.Size = new System.Drawing.Size(90, 33);
            this.Txt_Forrige.TabIndex = 6;
            this.Txt_Forrige.Text = "Forrige";
            this.Txt_Forrige.UseVisualStyleBackColor = true;
            this.Txt_Forrige.Click += new System.EventHandler(this.Forrige_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Første danser, Navn:";
            // 
            // Txt_FirstDancer_Points
            // 
            this.Txt_FirstDancer_Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FirstDancer_Points.Location = new System.Drawing.Point(474, 92);
            this.Txt_FirstDancer_Points.Name = "Txt_FirstDancer_Points";
            this.Txt_FirstDancer_Points.Size = new System.Drawing.Size(100, 29);
            this.Txt_FirstDancer_Points.TabIndex = 8;
            this.Txt_FirstDancer_Points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FirstDancer_Points_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Anden danser, Point:";
            // 
            // Txt_SecondDancer_Name
            // 
            this.Txt_SecondDancer_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Txt_SecondDancer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SecondDancer_Name.Location = new System.Drawing.Point(474, 145);
            this.Txt_SecondDancer_Name.Name = "Txt_SecondDancer_Name";
            this.Txt_SecondDancer_Name.Size = new System.Drawing.Size(100, 29);
            this.Txt_SecondDancer_Name.TabIndex = 10;
            this.Txt_SecondDancer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SecondDancer_Name_KeyPress);
            // 
            // Txt_FirstDancer_Name
            // 
            this.Txt_FirstDancer_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Txt_FirstDancer_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_FirstDancer_Name.Location = new System.Drawing.Point(474, 41);
            this.Txt_FirstDancer_Name.Name = "Txt_FirstDancer_Name";
            this.Txt_FirstDancer_Name.Size = new System.Drawing.Size(100, 29);
            this.Txt_FirstDancer_Name.TabIndex = 11;
            this.Txt_FirstDancer_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FirstDancer_Name_KeyPress);
            // 
            // txt_Dancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_FirstDancer_Name);
            this.Controls.Add(this.Txt_SecondDancer_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_FirstDancer_Points);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Forrige);
            this.Controls.Add(this.Btn_Vis);
            this.Controls.Add(this.Txt_SecondDancer_Points);
            this.Controls.Add(this.txt_resultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txt_Dancer";
            this.Text = "Dans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_resultat;
        private System.Windows.Forms.TextBox Txt_SecondDancer_Points;
        private System.Windows.Forms.Button Btn_Vis;
        private System.Windows.Forms.Button Txt_Forrige;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_FirstDancer_Points;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SecondDancer_Name;
        private System.Windows.Forms.TextBox Txt_FirstDancer_Name;
    }
}
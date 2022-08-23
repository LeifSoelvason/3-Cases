namespace Project3_WindowsForms
{
    partial class txt_Football
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
            this.resultat = new System.Windows.Forms.Label();
            this.Btn_Vis = new System.Windows.Forms.Button();
            this.Txt_Målforsøg = new System.Windows.Forms.TextBox();
            this.Txt_AntalAfleveringer = new System.Windows.Forms.TextBox();
            this.Btn_Næste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal afleveringer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Målforsøg (Skriv MÅL hvis der scores):";
            // 
            // resultat
            // 
            this.resultat.AutoSize = true;
            this.resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultat.Location = new System.Drawing.Point(70, 266);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(76, 24);
            this.resultat.TabIndex = 4;
            this.resultat.Text = "Resultat";
            // 
            // Btn_Vis
            // 
            this.Btn_Vis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vis.Location = new System.Drawing.Point(506, 170);
            this.Btn_Vis.Name = "Btn_Vis";
            this.Btn_Vis.Size = new System.Drawing.Size(75, 31);
            this.Btn_Vis.TabIndex = 5;
            this.Btn_Vis.Text = "Vis";
            this.Btn_Vis.UseVisualStyleBackColor = true;
            this.Btn_Vis.Click += new System.EventHandler(this.Btn_Vis_Click);
            // 
            // Txt_Målforsøg
            // 
            this.Txt_Målforsøg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Målforsøg.Location = new System.Drawing.Point(506, 135);
            this.Txt_Målforsøg.Name = "Txt_Målforsøg";
            this.Txt_Målforsøg.Size = new System.Drawing.Size(100, 29);
            this.Txt_Målforsøg.TabIndex = 6;
            this.Txt_Målforsøg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Målforsøg_KeyPress);
            // 
            // Txt_AntalAfleveringer
            // 
            this.Txt_AntalAfleveringer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Txt_AntalAfleveringer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AntalAfleveringer.Location = new System.Drawing.Point(506, 58);
            this.Txt_AntalAfleveringer.Name = "Txt_AntalAfleveringer";
            this.Txt_AntalAfleveringer.Size = new System.Drawing.Size(100, 29);
            this.Txt_AntalAfleveringer.TabIndex = 7;
            this.Txt_AntalAfleveringer.TextChanged += new System.EventHandler(this.Txt_AntalAfleveringer_TextChanged);
            this.Txt_AntalAfleveringer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_AntalAfleveringer_KeyPress);
            // 
            // Btn_Næste
            // 
            this.Btn_Næste.Location = new System.Drawing.Point(664, 387);
            this.Btn_Næste.Name = "Btn_Næste";
            this.Btn_Næste.Size = new System.Drawing.Size(99, 33);
            this.Btn_Næste.TabIndex = 8;
            this.Btn_Næste.Text = "Næste";
            this.Btn_Næste.UseVisualStyleBackColor = true;
            this.Btn_Næste.Click += new System.EventHandler(this.Btn_Næste_Form_Click);
            // 
            // txt_Football
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Næste);
            this.Controls.Add(this.Txt_AntalAfleveringer);
            this.Controls.Add(this.Txt_Målforsøg);
            this.Controls.Add(this.Btn_Vis);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "txt_Football";
            this.Text = "Fodbold";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultat;
        private System.Windows.Forms.Button Btn_Vis;
        private System.Windows.Forms.TextBox Txt_Målforsøg;
        private System.Windows.Forms.TextBox Txt_AntalAfleveringer;
        private System.Windows.Forms.Button Btn_Næste;
    }
}


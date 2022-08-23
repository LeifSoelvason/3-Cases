namespace Project3_WindowsForms
{
    partial class Form1
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
            this.lbl_Udskriv = new System.Windows.Forms.Label();
            this.btn_Udskriv = new System.Windows.Forms.Button();
            this.txt_Målforsøg = new System.Windows.Forms.TextBox();
            this.txtAntalAfleveringer = new System.Windows.Forms.TextBox();
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
            // lbl_Udskriv
            // 
            this.lbl_Udskriv.AutoSize = true;
            this.lbl_Udskriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Udskriv.Location = new System.Drawing.Point(70, 222);
            this.lbl_Udskriv.Name = "lbl_Udskriv";
            this.lbl_Udskriv.Size = new System.Drawing.Size(71, 24);
            this.lbl_Udskriv.TabIndex = 4;
            this.lbl_Udskriv.Text = "Udskriv";
            // 
            // btn_Udskriv
            // 
            this.btn_Udskriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Udskriv.Location = new System.Drawing.Point(506, 170);
            this.btn_Udskriv.Name = "btn_Udskriv";
            this.btn_Udskriv.Size = new System.Drawing.Size(75, 31);
            this.btn_Udskriv.TabIndex = 5;
            this.btn_Udskriv.Text = "Vis";
            this.btn_Udskriv.UseVisualStyleBackColor = true;
            this.btn_Udskriv.Click += new System.EventHandler(this.btn_Udskriv_Click);
            // 
            // txt_Målforsøg
            // 
            this.txt_Målforsøg.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_Målforsøg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Målforsøg.Location = new System.Drawing.Point(506, 135);
            this.txt_Målforsøg.Name = "txt_Målforsøg";
            this.txt_Målforsøg.Size = new System.Drawing.Size(100, 29);
            this.txt_Målforsøg.TabIndex = 6;
            this.txt_Målforsøg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Målforsøg_KeyPress);
            // 
            // txtAntalAfleveringer
            // 
            this.txtAntalAfleveringer.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAntalAfleveringer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntalAfleveringer.Location = new System.Drawing.Point(506, 58);
            this.txtAntalAfleveringer.Name = "txtAntalAfleveringer";
            this.txtAntalAfleveringer.Size = new System.Drawing.Size(100, 29);
            this.txtAntalAfleveringer.TabIndex = 7;
            this.txtAntalAfleveringer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAntalAfleveringer_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAntalAfleveringer);
            this.Controls.Add(this.txt_Målforsøg);
            this.Controls.Add(this.btn_Udskriv);
            this.Controls.Add(this.lbl_Udskriv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Udskriv;
        private System.Windows.Forms.Button btn_Udskriv;
        private System.Windows.Forms.TextBox txt_Målforsøg;
        private System.Windows.Forms.TextBox txtAntalAfleveringer;
    }
}


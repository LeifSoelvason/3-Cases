namespace Project3_WindowsForms
{
    partial class Home
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
            this.Btn_Football = new System.Windows.Forms.Button();
            this.Btn_Dancer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Change_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velkommen";
            // 
            // Btn_Football
            // 
            this.Btn_Football.Location = new System.Drawing.Point(24, 99);
            this.Btn_Football.Name = "Btn_Football";
            this.Btn_Football.Size = new System.Drawing.Size(71, 31);
            this.Btn_Football.TabIndex = 1;
            this.Btn_Football.Text = "Football";
            this.Btn_Football.UseVisualStyleBackColor = true;
            this.Btn_Football.Click += new System.EventHandler(this.Btn_Football_Click);
            // 
            // Btn_Dancer
            // 
            this.Btn_Dancer.Location = new System.Drawing.Point(24, 146);
            this.Btn_Dancer.Name = "Btn_Dancer";
            this.Btn_Dancer.Size = new System.Drawing.Size(71, 31);
            this.Btn_Dancer.TabIndex = 2;
            this.Btn_Dancer.Text = "Dancer";
            this.Btn_Dancer.UseVisualStyleBackColor = true;
            this.Btn_Dancer.Click += new System.EventHandler(this.Btn_Dancer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cases:";
            // 
            // Btn_Change_Password
            // 
            this.Btn_Change_Password.Location = new System.Drawing.Point(756, 481);
            this.Btn_Change_Password.Name = "Btn_Change_Password";
            this.Btn_Change_Password.Size = new System.Drawing.Size(97, 46);
            this.Btn_Change_Password.TabIndex = 4;
            this.Btn_Change_Password.Text = "Change Password";
            this.Btn_Change_Password.UseVisualStyleBackColor = true;
            this.Btn_Change_Password.Click += new System.EventHandler(this.Btn_Change_Password_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(920, 557);
            this.Controls.Add(this.Btn_Change_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Dancer);
            this.Controls.Add(this.Btn_Football);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Football;
        private System.Windows.Forms.Button Btn_Dancer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Change_Password;
    }
}
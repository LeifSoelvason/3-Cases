namespace Project3_WindowsForms
{
    partial class New_User
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
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Save = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // Txt_Save
            // 
            this.Txt_Save.Location = new System.Drawing.Point(72, 282);
            this.Txt_Save.Name = "Txt_Save";
            this.Txt_Save.Size = new System.Drawing.Size(75, 23);
            this.Txt_Save.TabIndex = 5;
            this.Txt_Save.Text = "Save";
            this.Txt_Save.UseVisualStyleBackColor = true;
            this.Txt_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(378, 152);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 6;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(72, 152);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(116, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Image = global::Project3_WindowsForms.Properties.Resources.kindpng_92516;
            this.checkBox1.Location = new System.Drawing.Point(209, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 34);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(72, 236);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(116, 20);
            this.txt_Password.TabIndex = 9;
            // 
            // Txt_Close
            // 
            this.Txt_Close.Location = new System.Drawing.Point(564, 368);
            this.Txt_Close.Name = "Txt_Close";
            this.Txt_Close.Size = new System.Drawing.Size(83, 36);
            this.Txt_Close.TabIndex = 10;
            this.Txt_Close.Text = "Close";
            this.Txt_Close.UseVisualStyleBackColor = true;
            this.Txt_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 416);
            this.Controls.Add(this.Txt_Close);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Txt_Save);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "New_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Txt_Save;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button Txt_Close;
    }
}
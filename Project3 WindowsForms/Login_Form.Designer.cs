namespace Project3_WindowsForms
{
    partial class Login_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_LogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.Btn_New_User = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(252, 74);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(173, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // Btn_LogIn
            // 
            this.Btn_LogIn.Location = new System.Drawing.Point(252, 111);
            this.Btn_LogIn.Name = "Btn_LogIn";
            this.Btn_LogIn.Size = new System.Drawing.Size(91, 33);
            this.Btn_LogIn.TabIndex = 4;
            this.Btn_LogIn.Text = "Login";
            this.Btn_LogIn.UseVisualStyleBackColor = true;
            this.Btn_LogIn.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(252, 32);
            this.txt_Username.MaxLength = 50;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(173, 20);
            this.txt_Username.TabIndex = 6;
            // 
            // Btn_New_User
            // 
            this.Btn_New_User.Location = new System.Drawing.Point(549, 232);
            this.Btn_New_User.Name = "Btn_New_User";
            this.Btn_New_User.Size = new System.Drawing.Size(91, 33);
            this.Btn_New_User.TabIndex = 7;
            this.Btn_New_User.Text = "New User";
            this.Btn_New_User.UseVisualStyleBackColor = true;
            this.Btn_New_User.Click += new System.EventHandler(this.Btn_New_User_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Image = global::Project3_WindowsForms.Properties.Resources.kindpng_92516;
            this.checkBox1.Location = new System.Drawing.Point(440, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 28);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 277);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Btn_New_User);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LogIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button Btn_LogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button Btn_New_User;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
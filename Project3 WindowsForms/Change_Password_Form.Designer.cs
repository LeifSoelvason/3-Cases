namespace Project3_WindowsForms
{
    partial class Change_Password_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_New_Password = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Old_Password = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(128, 50);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(100, 20);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_New_Password
            // 
            this.txt_New_Password.Location = new System.Drawing.Point(128, 141);
            this.txt_New_Password.Name = "txt_New_Password";
            this.txt_New_Password.PasswordChar = '*';
            this.txt_New_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_New_Password.TabIndex = 4;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(32, 187);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(83, 30);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(370, 81);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 13);
            this.Output.TabIndex = 6;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(506, 279);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(95, 30);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Old Password";
            // 
            // txt_Old_Password
            // 
            this.txt_Old_Password.Location = new System.Drawing.Point(128, 100);
            this.txt_Old_Password.Name = "txt_Old_Password";
            this.txt_Old_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Old_Password.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.Image = global::Project3_WindowsForms.Properties.Resources.kindpng_92516;
            this.checkBox1.Location = new System.Drawing.Point(243, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 27);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Change_Password_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 321);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_Old_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.txt_New_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Change_Password_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_New_Password;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Old_Password;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
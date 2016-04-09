namespace UnlockUser
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
            this.Unlock = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Unlock
            // 
            this.Unlock.Location = new System.Drawing.Point(18, 46);
            this.Unlock.Name = "Unlock";
            this.Unlock.Size = new System.Drawing.Size(184, 57);
            this.Unlock.TabIndex = 0;
            this.Unlock.Text = "Unlock";
            this.Unlock.UseVisualStyleBackColor = true;
            this.Unlock.Click += new System.EventHandler(this.Unlock_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(18, 20);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(184, 20);
            this.user.TabIndex = 1;
            this.user.Text = "gilang963517";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 147);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Unlock);
            this.tabPage1.Controls.Add(this.user);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(224, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unlock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ok);
            this.tabPage2.Controls.Add(this.password);
            this.tabPage2.Controls.Add(this.userName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(224, 121);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(20, 19);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(179, 20);
            this.userName.TabIndex = 0;
            this.userName.Text = "ciptha952839";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(20, 45);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(179, 20);
            this.password.TabIndex = 1;
            this.password.Text = "Dh@rmaw@n18";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(20, 72);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(179, 32);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 158);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Unlock User";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Unlock;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
    }
}


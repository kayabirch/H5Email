namespace EmailClient
{
    partial class EmailClient
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
            this.txLogCre = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txUser = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbSaveCre = new System.Windows.Forms.Label();
            this.cbCRe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txLogCre
            // 
            this.txLogCre.AutoSize = true;
            this.txLogCre.Location = new System.Drawing.Point(12, 19);
            this.txLogCre.Name = "txLogCre";
            this.txLogCre.Size = new System.Drawing.Size(122, 17);
            this.txLogCre.TabIndex = 0;
            this.txLogCre.Text = "Login Credentials:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(12, 49);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(77, 17);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Username:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(12, 84);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(73, 17);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // txUser
            // 
            this.txUser.Location = new System.Drawing.Point(96, 49);
            this.txUser.Name = "txUser";
            this.txUser.Size = new System.Drawing.Size(100, 22);
            this.txUser.TabIndex = 3;
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(96, 84);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(100, 22);
            this.txPass.TabIndex = 4;
            this.txPass.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btLogin.Location = new System.Drawing.Point(15, 161);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 30);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbSaveCre
            // 
            this.lbSaveCre.AutoSize = true;
            this.lbSaveCre.Location = new System.Drawing.Point(15, 122);
            this.lbSaveCre.Name = "lbSaveCre";
            this.lbSaveCre.Size = new System.Drawing.Size(115, 17);
            this.lbSaveCre.TabIndex = 6;
            this.lbSaveCre.Text = "Save Credentials";
            // 
            // cbCRe
            // 
            this.cbCRe.AutoSize = true;
            this.cbCRe.Location = new System.Drawing.Point(178, 122);
            this.cbCRe.Name = "cbCRe";
            this.cbCRe.Size = new System.Drawing.Size(18, 17);
            this.cbCRe.TabIndex = 7;
            this.cbCRe.UseVisualStyleBackColor = true;
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 216);
            this.Controls.Add(this.cbCRe);
            this.Controls.Add(this.lbSaveCre);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txLogCre);
            this.Name = "EmailClient";
            this.Text = "Email-Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txLogCre;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbSaveCre;
        private System.Windows.Forms.CheckBox cbCRe;
    }
}


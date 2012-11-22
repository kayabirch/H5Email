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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
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
            resources.ApplyResources(this.txLogCre, "txLogCre");
            this.txLogCre.Name = "txLogCre";
            // 
            // lbUser
            // 
            resources.ApplyResources(this.lbUser, "lbUser");
            this.lbUser.Name = "lbUser";
            // 
            // lbPass
            // 
            resources.ApplyResources(this.lbPass, "lbPass");
            this.lbPass.Name = "lbPass";
            // 
            // txUser
            // 
            resources.ApplyResources(this.txUser, "txUser");
            this.txUser.Name = "txUser";
            // 
            // txPass
            // 
            resources.ApplyResources(this.txPass, "txPass");
            this.txPass.Name = "txPass";
            this.txPass.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.Name = "btLogin";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbSaveCre
            // 
            resources.ApplyResources(this.lbSaveCre, "lbSaveCre");
            this.lbSaveCre.Name = "lbSaveCre";
            // 
            // cbCRe
            // 
            resources.ApplyResources(this.cbCRe, "cbCRe");
            this.cbCRe.Name = "cbCRe";
            this.cbCRe.UseVisualStyleBackColor = true;
            // 
            // EmailClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCRe);
            this.Controls.Add(this.lbSaveCre);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.txUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txLogCre);
            this.Name = "EmailClient";
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


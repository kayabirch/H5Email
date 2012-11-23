namespace EmailClient
{
    partial class SendEmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmail));
            this.lbRec = new System.Windows.Forms.Label();
            this.lbCat = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.txRec = new System.Windows.Forms.TextBox();
            this.txCat = new System.Windows.Forms.TextBox();
            this.txMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.toolTipSend = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbRec
            // 
            resources.ApplyResources(this.lbRec, "lbRec");
            this.lbRec.Name = "lbRec";
            // 
            // lbCat
            // 
            resources.ApplyResources(this.lbCat, "lbCat");
            this.lbCat.Name = "lbCat";
            // 
            // lbMessage
            // 
            resources.ApplyResources(this.lbMessage, "lbMessage");
            this.lbMessage.Name = "lbMessage";
            // 
            // txRec
            // 
            resources.ApplyResources(this.txRec, "txRec");
            this.txRec.Name = "txRec";
            // 
            // txCat
            // 
            resources.ApplyResources(this.txCat, "txCat");
            this.txCat.Name = "txCat";
            // 
            // txMessage
            // 
            resources.ApplyResources(this.txMessage, "txMessage");
            this.txMessage.Name = "txMessage";
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btSend, "btSend");
            this.btSend.Name = "btSend";
            this.toolTipSend.SetToolTip(this.btSend, resources.GetString("btSend.ToolTip"));
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // SendEmail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txMessage);
            this.Controls.Add(this.txCat);
            this.Controls.Add(this.txRec);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.lbRec);
            this.Name = "SendEmail";
            this.Load += new System.EventHandler(this.SendEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRec;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox txRec;
        private System.Windows.Forms.TextBox txCat;
        private System.Windows.Forms.TextBox txMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.ToolTip toolTipSend;
    }
}
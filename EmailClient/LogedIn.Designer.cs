namespace EmailClient
{
    partial class LogedIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogedIn));
            this.lbloglabel = new System.Windows.Forms.Label();
            this.lbLogedInName = new System.Windows.Forms.Label();
            this.btCreateEmail = new System.Windows.Forms.Button();
            this.txMessage = new System.Windows.Forms.TextBox();
            this.lbMessageId = new System.Windows.Forms.Label();
            this.lbmessages = new System.Windows.Forms.Label();
            this.lbAtt = new System.Windows.Forms.Label();
            this.listAttachements = new System.Windows.Forms.TreeView();
            this.listMessages = new System.Windows.Forms.TreeView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbFrom = new System.Windows.Forms.Label();
            this.txFrom = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txTo = new System.Windows.Forms.TextBox();
            this.lbCC = new System.Windows.Forms.Label();
            this.txCC = new System.Windows.Forms.TextBox();
            this.lbBCC = new System.Windows.Forms.Label();
            this.txBCC = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloglabel
            // 
            resources.ApplyResources(this.lbloglabel, "lbloglabel");
            this.lbloglabel.Name = "lbloglabel";
            // 
            // lbLogedInName
            // 
            resources.ApplyResources(this.lbLogedInName, "lbLogedInName");
            this.lbLogedInName.Name = "lbLogedInName";
            // 
            // btCreateEmail
            // 
            this.btCreateEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            resources.ApplyResources(this.btCreateEmail, "btCreateEmail");
            this.btCreateEmail.Name = "btCreateEmail";
            this.btCreateEmail.UseVisualStyleBackColor = false;
            this.btCreateEmail.Click += new System.EventHandler(this.btCreateEmail_Click);
            // 
            // txMessage
            // 
            resources.ApplyResources(this.txMessage, "txMessage");
            this.txMessage.Name = "txMessage";
            this.txMessage.ReadOnly = true;
            // 
            // lbMessageId
            // 
            resources.ApplyResources(this.lbMessageId, "lbMessageId");
            this.lbMessageId.Name = "lbMessageId";
            // 
            // lbmessages
            // 
            resources.ApplyResources(this.lbmessages, "lbmessages");
            this.lbmessages.Name = "lbmessages";
            // 
            // lbAtt
            // 
            resources.ApplyResources(this.lbAtt, "lbAtt");
            this.lbAtt.Name = "lbAtt";
            // 
            // listAttachements
            // 
            resources.ApplyResources(this.listAttachements, "listAttachements");
            this.listAttachements.Name = "listAttachements";
            this.listAttachements.ShowLines = false;
            this.listAttachements.ShowRootLines = false;
            // 
            // listMessages
            // 
            resources.ApplyResources(this.listMessages, "listMessages");
            this.listMessages.Name = "listMessages";
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listMessages_AfterSelect);
            // 
            // lbFrom
            // 
            resources.ApplyResources(this.lbFrom, "lbFrom");
            this.lbFrom.Name = "lbFrom";
            // 
            // txFrom
            // 
            resources.ApplyResources(this.txFrom, "txFrom");
            this.txFrom.Name = "txFrom";
            // 
            // lbTo
            // 
            resources.ApplyResources(this.lbTo, "lbTo");
            this.lbTo.Name = "lbTo";
            // 
            // txTo
            // 
            resources.ApplyResources(this.txTo, "txTo");
            this.txTo.Name = "txTo";
            // 
            // lbCC
            // 
            resources.ApplyResources(this.lbCC, "lbCC");
            this.lbCC.Name = "lbCC";
            // 
            // txCC
            // 
            resources.ApplyResources(this.txCC, "txCC");
            this.txCC.Name = "txCC";
            // 
            // lbBCC
            // 
            resources.ApplyResources(this.lbBCC, "lbBCC");
            this.lbBCC.Name = "lbBCC";
            // 
            // txBCC
            // 
            resources.ApplyResources(this.txBCC, "txBCC");
            this.txBCC.Name = "txBCC";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // LogedIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.txBCC);
            this.Controls.Add(this.lbBCC);
            this.Controls.Add(this.txCC);
            this.Controls.Add(this.lbCC);
            this.Controls.Add(this.txTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.txFrom);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.listAttachements);
            this.Controls.Add(this.lbAtt);
            this.Controls.Add(this.lbmessages);
            this.Controls.Add(this.lbMessageId);
            this.Controls.Add(this.txMessage);
            this.Controls.Add(this.btCreateEmail);
            this.Controls.Add(this.lbLogedInName);
            this.Controls.Add(this.lbloglabel);
            this.Name = "LogedIn";
            this.Load += new System.EventHandler(this.LogedIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloglabel;
        public System.Windows.Forms.Label lbLogedInName;
        private System.Windows.Forms.Button btCreateEmail;
        private System.Windows.Forms.TextBox txMessage;
        private System.Windows.Forms.Label lbMessageId;
        private System.Windows.Forms.Label lbmessages;
        private System.Windows.Forms.Label lbAtt;
        private System.Windows.Forms.TreeView listAttachements;
        private System.Windows.Forms.TreeView listMessages;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox txFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txTo;
        private System.Windows.Forms.Label lbCC;
        private System.Windows.Forms.TextBox txCC;
        private System.Windows.Forms.Label lbBCC;
        private System.Windows.Forms.TextBox txBCC;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbLanguage;
    }
}
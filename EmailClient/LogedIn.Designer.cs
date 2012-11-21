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
            this.btPrint = new System.Windows.Forms.Button();
            this.lbTo = new System.Windows.Forms.Label();
            this.txTo = new System.Windows.Forms.TextBox();
            this.lbCC = new System.Windows.Forms.Label();
            this.txCC = new System.Windows.Forms.TextBox();
            this.lbBCC = new System.Windows.Forms.Label();
            this.txBCC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbloglabel
            // 
            this.lbloglabel.AutoSize = true;
            this.lbloglabel.Location = new System.Drawing.Point(12, 23);
            this.lbloglabel.Name = "lbloglabel";
            this.lbloglabel.Size = new System.Drawing.Size(86, 17);
            this.lbloglabel.TabIndex = 0;
            this.lbloglabel.Text = "Loged in as:";
            // 
            // lbLogedInName
            // 
            this.lbLogedInName.AutoSize = true;
            this.lbLogedInName.Location = new System.Drawing.Point(92, 23);
            this.lbLogedInName.Name = "lbLogedInName";
            this.lbLogedInName.Size = new System.Drawing.Size(42, 17);
            this.lbLogedInName.TabIndex = 1;
            this.lbLogedInName.Text = "None";
            // 
            // btCreateEmail
            // 
            this.btCreateEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btCreateEmail.Location = new System.Drawing.Point(15, 57);
            this.btCreateEmail.Name = "btCreateEmail";
            this.btCreateEmail.Size = new System.Drawing.Size(143, 31);
            this.btCreateEmail.TabIndex = 2;
            this.btCreateEmail.Text = "Create New E-mail";
            this.btCreateEmail.UseVisualStyleBackColor = false;
            this.btCreateEmail.Click += new System.EventHandler(this.btCreateEmail_Click);
            // 
            // txMessage
            // 
            this.txMessage.Location = new System.Drawing.Point(387, 176);
            this.txMessage.Multiline = true;
            this.txMessage.Name = "txMessage";
            this.txMessage.ReadOnly = true;
            this.txMessage.Size = new System.Drawing.Size(468, 269);
            this.txMessage.TabIndex = 4;
            // 
            // lbMessageId
            // 
            this.lbMessageId.AutoSize = true;
            this.lbMessageId.Location = new System.Drawing.Point(384, 144);
            this.lbMessageId.Name = "lbMessageId";
            this.lbMessageId.Size = new System.Drawing.Size(142, 17);
            this.lbMessageId.TabIndex = 5;
            this.lbMessageId.Text = "Email message body:";
            // 
            // lbmessages
            // 
            this.lbmessages.AutoSize = true;
            this.lbmessages.Location = new System.Drawing.Point(15, 144);
            this.lbmessages.Name = "lbmessages";
            this.lbmessages.Size = new System.Drawing.Size(76, 17);
            this.lbmessages.TabIndex = 7;
            this.lbmessages.Text = "Messages:";
            // 
            // lbAtt
            // 
            this.lbAtt.AutoSize = true;
            this.lbAtt.Location = new System.Drawing.Point(889, 144);
            this.lbAtt.Name = "lbAtt";
            this.lbAtt.Size = new System.Drawing.Size(98, 17);
            this.lbAtt.TabIndex = 9;
            this.lbAtt.Text = "Attachements:";
            // 
            // listAttachements
            // 
            this.listAttachements.Location = new System.Drawing.Point(876, 176);
            this.listAttachements.Name = "listAttachements";
            this.listAttachements.ShowLines = false;
            this.listAttachements.ShowRootLines = false;
            this.listAttachements.Size = new System.Drawing.Size(209, 269);
            this.listAttachements.TabIndex = 10;
            // 
            // listMessages
            // 
            this.listMessages.Location = new System.Drawing.Point(18, 176);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(344, 269);
            this.listMessages.TabIndex = 11;
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listMessages_AfterSelect);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Location = new System.Drawing.Point(384, 46);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(99, 17);
            this.lbFrom.TabIndex = 12;
            this.lbFrom.Text = "From address:";
            // 
            // txFrom
            // 
            this.txFrom.Location = new System.Drawing.Point(489, 43);
            this.txFrom.Name = "txFrom";
            this.txFrom.Size = new System.Drawing.Size(366, 22);
            this.txFrom.TabIndex = 13;
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btPrint.Location = new System.Drawing.Point(15, 94);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(143, 30);
            this.btPrint.TabIndex = 14;
            this.btPrint.Text = "Print Email!";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Visible = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Location = new System.Drawing.Point(384, 71);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(84, 17);
            this.lbTo.TabIndex = 15;
            this.lbTo.Text = "To address:";
            // 
            // txTo
            // 
            this.txTo.Location = new System.Drawing.Point(489, 68);
            this.txTo.Name = "txTo";
            this.txTo.Size = new System.Drawing.Size(366, 22);
            this.txTo.TabIndex = 16;
            // 
            // lbCC
            // 
            this.lbCC.AutoSize = true;
            this.lbCC.Location = new System.Drawing.Point(384, 99);
            this.lbCC.Name = "lbCC";
            this.lbCC.Size = new System.Drawing.Size(30, 17);
            this.lbCC.TabIndex = 17;
            this.lbCC.Text = "CC:";
            // 
            // txCC
            // 
            this.txCC.Location = new System.Drawing.Point(489, 94);
            this.txCC.Name = "txCC";
            this.txCC.Size = new System.Drawing.Size(366, 22);
            this.txCC.TabIndex = 18;
            // 
            // lbBCC
            // 
            this.lbBCC.AutoSize = true;
            this.lbBCC.Location = new System.Drawing.Point(384, 122);
            this.lbBCC.Name = "lbBCC";
            this.lbBCC.Size = new System.Drawing.Size(39, 17);
            this.lbBCC.TabIndex = 19;
            this.lbBCC.Text = "BCC:";
            // 
            // txBCC
            // 
            this.txBCC.Location = new System.Drawing.Point(489, 119);
            this.txBCC.Name = "txBCC";
            this.txBCC.Size = new System.Drawing.Size(366, 22);
            this.txBCC.TabIndex = 20;
            // 
            // LogedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1110, 473);
            this.Controls.Add(this.txBCC);
            this.Controls.Add(this.lbBCC);
            this.Controls.Add(this.txCC);
            this.Controls.Add(this.lbCC);
            this.Controls.Add(this.txTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.btPrint);
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
            this.Text = "LogedIn";
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
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txTo;
        private System.Windows.Forms.Label lbCC;
        private System.Windows.Forms.TextBox txCC;
        private System.Windows.Forms.Label lbBCC;
        private System.Windows.Forms.TextBox txBCC;
    }
}
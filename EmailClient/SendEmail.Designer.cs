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
            this.lbRec = new System.Windows.Forms.Label();
            this.lbCat = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.txRec = new System.Windows.Forms.TextBox();
            this.txCat = new System.Windows.Forms.TextBox();
            this.txMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRec
            // 
            this.lbRec.AutoSize = true;
            this.lbRec.Location = new System.Drawing.Point(13, 13);
            this.lbRec.Name = "lbRec";
            this.lbRec.Size = new System.Drawing.Size(84, 17);
            this.lbRec.TabIndex = 0;
            this.lbRec.Text = "To address:";
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Location = new System.Drawing.Point(13, 42);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(59, 17);
            this.lbCat.TabIndex = 1;
            this.lbCat.Text = "Subject:";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(13, 74);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(62, 17);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.Text = "Mesage:";
            // 
            // txRec
            // 
            this.txRec.Location = new System.Drawing.Point(99, 13);
            this.txRec.Name = "txRec";
            this.txRec.Size = new System.Drawing.Size(215, 22);
            this.txRec.TabIndex = 3;
            // 
            // txCat
            // 
            this.txCat.Location = new System.Drawing.Point(99, 42);
            this.txCat.Name = "txCat";
            this.txCat.Size = new System.Drawing.Size(215, 22);
            this.txCat.TabIndex = 4;
            // 
            // txMessage
            // 
            this.txMessage.Location = new System.Drawing.Point(99, 74);
            this.txMessage.Multiline = true;
            this.txMessage.Name = "txMessage";
            this.txMessage.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txMessage.Size = new System.Drawing.Size(215, 135);
            this.txMessage.TabIndex = 5;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btSend.Location = new System.Drawing.Point(16, 248);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 30);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 300);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txMessage);
            this.Controls.Add(this.txCat);
            this.Controls.Add(this.txRec);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.lbRec);
            this.Name = "SendEmail";
            this.Text = "SendEmail";
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
    }
}
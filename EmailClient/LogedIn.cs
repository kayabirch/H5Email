using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.Security;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.Threading;
using System.Globalization;

namespace EmailClient
{

    public partial class LogedIn : Form
    {
        List<OpenPop.Mime.Message> messages;
        int nodeIndex;
        string bodyAsText;
        string Lang;

        public LogedIn()
        {
            InitializeComponent();

            //Run a thread in background to collect emails from gmail.
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorkerDoWork);

            backgroundWorker1.RunWorkerAsync();

            //When background worker complete, insert in treview list on form
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundworkerRunCompleted);
        }

        //Create new email
        private void btCreateEmail_Click(object sender, EventArgs e)
        {
            SendEmail sendemail = new SendEmail(Lang);
            sendemail.Show();
        }

        private void GetIndbox()
        {
            messages = GetAllMessages("pop.gmail.com", 995, true, Properties.Settings.Default.username.ToString(), Properties.Settings.Default.password.ToString());
        }
        public void backgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            GetIndbox();
        }

        public void backgroundworkerRunCompleted(object sender, AsyncCompletedEventArgs e)
        {
            insertEmailsInListOnGui();
        }

        //Insert emails in treview on form
        private void insertEmailsInListOnGui()
        {
            for (int i = 0; i < messages.Count; i++)
            {
                listMessages.Nodes.Add(messages[i].Headers.Subject.ToString());
            }
        }

        //Connect to gmail, get emails and ad it to a MessageList
        public static List<OpenPop.Mime.Message> GetAllMessages(string hostname, int port, bool ssl, string username, string password)
        {
            try
            {
                Pop3Client client = new Pop3Client();
                
                    if (client.Connected)
                    {
                        client.Disconnect();
                    }

                    client.Connect(hostname, port, ssl);
                    client.Authenticate(username, password);

                    int messageCount = client.GetMessageCount();
                    
                    List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

                    for (int i = messageCount; i > messageCount - 5; i--)
                    {
                        allMessages.Add(client.GetMessage(i));
                    }

                    return allMessages;
                }
            
            catch(Exception ex)
            {
                MessageBox.Show("You have written something wrong! : " + ex.Message);
                EmailClient em = new EmailClient();
                em.Dispose();
                Thread.CurrentThread.Abort();
                Application.Exit();
            }
            
            return null;
        }

        private void listMessages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodeIndex = e.Node.Index;
            //Get From address
            txFrom.Text = messages[e.Node.Index].Headers.From.ToString();
            //Get To address
            if (messages[e.Node.Index].Headers.To.Count == 0)
            {
                txTo.Text = string.Empty;
            }
            else
            {
                for (int i = 0; i < messages[e.Node.Index].Headers.To.Count; i++)
                {
                    txTo.Text += messages[e.Node.Index].Headers.To[i].ToString();
                }
            }
            //Get CC address
            if (messages[e.Node.Index].Headers.Cc.Count == 0)
            {
                txCC.Text = string.Empty;
            }
            else
            {
                for (int i = 0; i < messages[e.Node.Index].Headers.Cc.Count; i++)
                {
                    txCC.Text += messages[e.Node.Index].Headers.Cc[i].ToString();
                }
            }
            //Get Bcc address
            if (messages[e.Node.Index].Headers.Bcc.Count == 0)
            {
                txBCC.Text = string.Empty;
            }
            else
            {
                for (int i = 0; i < messages[e.Node.Index].Headers.Bcc.Count; i++)
                {
                    txBCC.Text += messages[e.Node.Index].Headers.Bcc[i].ToString();
                }
            }

            //Get Body text
            MessagePart body = messages[e.Node.Index].FindFirstPlainTextVersion();
            if (body != null)
            {
                bodyAsText = body.GetBodyAsText();
                txMessage.Text = bodyAsText;
            }
            else
                txMessage.Text = "No text ! ";
            //Get attachements
            foreach (MessagePart attachement in messages[e.Node.Index].FindAllAttachments())
            {
                listAttachements.Nodes.Clear();
                listAttachements.Nodes.Add(attachement.FileName);
            }

        }

        private void LogedIn_Load(object sender, EventArgs e)
        {
            cbLanguage.Items.Add("English");
            cbLanguage.Items.Add("Danish");
            cbLanguage.SelectedIndex = 0;
            Lang = "English";
        }

        private void ChangeLanguage(string language)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(LogedIn));
                resources.ApplyResources(c, c.Name, new CultureInfo(language));
            }
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedItem.ToString() == "Danish")
            {
                Lang = "Danish";
                ChangeLanguage("da");
            }
            else
            {
                Lang = "English";
                ChangeLanguage("en");
            }
        }
    }
}

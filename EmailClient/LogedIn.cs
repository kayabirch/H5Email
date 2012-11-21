using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.Security;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.Threading;

namespace EmailClient
{
    
    public partial class LogedIn : Form
    {
        List<OpenPop.Mime.Message> messages;
        int nodeIndex;

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
            SendEmail sendemail = new SendEmail();
            sendemail.Show();
        }

        private void GetIndbox()
        {
            messages = GetAllMessages("pop.gmail.com",995,true,Properties.Settings.Default.username.ToString(), Properties.Settings.Default.password.ToString());
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
            
            using (Pop3Client client = new Pop3Client())
            {
                if (client.Connected)
                {
                    client.Disconnect();
                }

                client.Connect(hostname,port,ssl);
                client.Authenticate(username,password);
                int messageCount = client.GetMessageCount();
                List<OpenPop.Mime.Message> allMessages = new List<OpenPop.Mime.Message>(messageCount);

                for(int i = messageCount; i > messageCount - 5; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                }

                return allMessages;
            }
        }

        private void listMessages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodeIndex = e.Node.Index;
            //Set button print to visible when choosing a mail
            btPrint.Visible = true;
            //Get From address
            txFrom.Text = messages[e.Node.Index].Headers.From.ToString();
            //Get To address
            if (messages[e.Node.Index].Headers.To.Count == 0){
                txTo.Text = string.Empty;}
            else{
                for (int i = 0; i < messages[e.Node.Index].Headers.To.Count; i++){
                    txTo.Text += messages[e.Node.Index].Headers.To[i].ToString();}}
            //Get CC address
            if (messages[e.Node.Index].Headers.Cc.Count == 0) {
                txCC.Text = string.Empty;}
            else{
                for (int i = 0; i < messages[e.Node.Index].Headers.Cc.Count; i++){
                    txCC.Text += messages[e.Node.Index].Headers.Cc[i].ToString();}}
            //Get Bcc address
            if (messages[e.Node.Index].Headers.Bcc.Count == 0){
                txBCC.Text = string.Empty;}
            else{
                for (int i = 0; i < messages[e.Node.Index].Headers.Bcc.Count; i++){
                    txBCC.Text += messages[e.Node.Index].Headers.Bcc[i].ToString();}}

            //Get Body text
            MessagePart body = messages[e.Node.Index].FindFirstPlainTextVersion();
            if (body != null)
            {
                string bodyAsText = body.GetBodyAsText();
                txMessage.Text = bodyAsText;
            }
            else
                txMessage.Text = "No text ! ";
            //Get attachements
            foreach(MessagePart attachement in messages[e.Node.Index].FindAllAttachments())
            {
                listAttachements.Nodes.Clear();
                listAttachements.Nodes.Add(attachement.FileName);
            }

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            //nodeIndex;
        }
    }
}

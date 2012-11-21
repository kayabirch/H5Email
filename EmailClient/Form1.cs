using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class EmailClient : Form
    {
        public EmailClient()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            /*string name = "anna";
            //string password = "Password1";
            if (txUser.Text == name)
            {
                if (txPass.Text == password)
                {
                    if (cbCRe.Checked)
                    {
                        Properties.Settings.Default.username = name;
                        Properties.Settings.Default.password = password;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.username = string.Empty;
                        Properties.Settings.Default.password = string.Empty;
                        Properties.Settings.Default.Save();
                    }

                    LogedIn logedin = new LogedIn();
                    logedin.Show();
                    logedin.lbLogedInName.Text = Name;
                    this.Hide();
                    
                }
                else
                    MessageBox.Show("You have written a wrong password!");
            }
            else
                MessageBox.Show("You have written a wrong username!");*/

            Properties.Settings.Default.username = txUser.Text;
            Properties.Settings.Default.password = txPass.Text;

            LogedIn logedin = new LogedIn();
            logedin.Show();
            logedin.lbLogedInName.Text = Name;
            this.Hide();
        }
    }
}

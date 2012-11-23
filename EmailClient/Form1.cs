using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

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
            //save to settings file
            Properties.Settings.Default.username = txUser.Text;
            Properties.Settings.Default.password = txPass.Text;

            //show new form after login:
            LogedIn logedin = new LogedIn();
            logedin.Show();
            logedin.lbLogedInName.Text = txUser.Text;
            this.Hide();
        }
    }
}

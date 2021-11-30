using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

using System.Windows.Forms;

namespace Discord_Webhook_Spammer
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {



        public MainForm()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        string update;


        private void btnStart_Click(object sender, EventArgs e)
        {
            int interval = Int32.Parse(textInterval.Text);

            if (interval == null)
            {
                MessageBox.Show("You need to set an interval", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (interval < 500)
            {
                MessageBox.Show("Interval should be above 500 ms or discord wont accept anything", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                timer.Interval = interval;
                timer.Enabled = true;
                timer.Tick += timerSendMessage;
            }
            
            
        }

        private void timerSendMessage(object sender, EventArgs e)
        {
            string webhook = textWebhook.Text;
            string message = textMessage.Text;
            string username = textUsername.Text;
            string pfp = textProfilePic.Text;

            if (webhook == "" || !webhook.Contains("discordapp.com"))
            {
                MessageBox.Show("You need to insert a valid webhook", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message == "")
            {
                MessageBox.Show("You need to enter a message", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sendMessage(username, pfp, webhook, message);
                lblStatus.Text = "Running...";
                int i = int.Parse(lblSent.Text);
                i++;
                lblSent.Text = i.ToString();
            }
                

        }

        static void sendMessage(string uname, string pfpic, string whook, string msg)
        {
            NameValueCollection value = new NameValueCollection();
            string UNLol = uname;
            if (uname == "" || uname.Length > 32)
            {
                UNLol = "BBITAR WEBHOOK SPAMMER";
            }

            value.Add("username", UNLol);
            value.Add("content", msg);
            if (pfpic == "")
            value.Add("avatar_url", "https://i.pinimg.com/736x/00/9e/96/009e9657f6b56006813e74c0431caa0d--logo-b-gaming-logo.jpg");
            else
                value.Add("avatar_url", pfpic);

            new WebClient().UploadValues(whook, value);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            lblStatus.Text = "Not Running...";
            lblSent.Text = "0";
        }

        private void textMessage2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            string webhook = textWebhook2.Text;
            string message = textMessage2.Text;
            string username = textUsername2.Text;
            string pfp = textAvatar2.Text;
            textMessage2.Text = "";
            if (webhook == "" || !webhook.Contains("discordapp.com"))
            {
                MessageBox.Show("You need to insert a valid webhook", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (message == "")
            {
                MessageBox.Show("You need to enter a message", "BBitar Webhook Spammer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sendMessage(username, pfp, webhook, message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string update = new WebClient().DownloadString("https://pastebin.com/raw/u37bYUwM");
            
            textUpdate.Text = update;
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bbitarx");
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/ZzqyR8vZVK");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            textUpdate.Text = new WebClient().DownloadString("https://pastebin.com/raw/u37bYUwM");
        }
    }
}

namespace Discord_Webhook_Spammer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabSpammer = new System.Windows.Forms.TabPage();
            this.tabMessage = new System.Windows.Forms.TabPage();
            this.textMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textWebhook = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblSent = new MetroFramework.Controls.MetroLabel();
            this.textUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.textProfilePic = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textAvatar2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.textUsername2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.textWebhook2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.textMessage2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.btnGithub = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDiscord = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRefresh = new Bunifu.Framework.UI.BunifuImageButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.pnlScroll = new MetroFramework.Controls.MetroPanel();
            this.textUpdate = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSpammer.SuspendLayout();
            this.tabMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabMain);
            this.metroTabControl1.Controls.Add(this.tabSpammer);
            this.metroTabControl1.Controls.Add(this.tabMessage);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(630, 328);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabMain.Controls.Add(this.pnlScroll);
            this.tabMain.Controls.Add(this.metroLabel14);
            this.tabMain.Controls.Add(this.metroLabel13);
            this.tabMain.Controls.Add(this.btnDiscord);
            this.tabMain.Controls.Add(this.btnGithub);
            this.tabMain.Location = new System.Drawing.Point(4, 38);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(622, 286);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "   Main   ";
            // 
            // tabSpammer
            // 
            this.tabSpammer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabSpammer.Controls.Add(this.textProfilePic);
            this.tabSpammer.Controls.Add(this.metroLabel8);
            this.tabSpammer.Controls.Add(this.textUsername);
            this.tabSpammer.Controls.Add(this.metroLabel7);
            this.tabSpammer.Controls.Add(this.lblSent);
            this.tabSpammer.Controls.Add(this.lblStatus);
            this.tabSpammer.Controls.Add(this.metroLabel6);
            this.tabSpammer.Controls.Add(this.metroLabel5);
            this.tabSpammer.Controls.Add(this.metroLabel4);
            this.tabSpammer.Controls.Add(this.btnStop);
            this.tabSpammer.Controls.Add(this.btnStart);
            this.tabSpammer.Controls.Add(this.textInterval);
            this.tabSpammer.Controls.Add(this.metroLabel3);
            this.tabSpammer.Controls.Add(this.textWebhook);
            this.tabSpammer.Controls.Add(this.metroLabel2);
            this.tabSpammer.Controls.Add(this.textMessage);
            this.tabSpammer.Controls.Add(this.metroLabel1);
            this.tabSpammer.Location = new System.Drawing.Point(4, 38);
            this.tabSpammer.Name = "tabSpammer";
            this.tabSpammer.Size = new System.Drawing.Size(622, 286);
            this.tabSpammer.TabIndex = 1;
            this.tabSpammer.Text = "   Spammer   ";
            // 
            // tabMessage
            // 
            this.tabMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabMessage.Controls.Add(this.btnSend);
            this.tabMessage.Controls.Add(this.textAvatar2);
            this.tabMessage.Controls.Add(this.metroLabel9);
            this.tabMessage.Controls.Add(this.textUsername2);
            this.tabMessage.Controls.Add(this.metroLabel10);
            this.tabMessage.Controls.Add(this.textWebhook2);
            this.tabMessage.Controls.Add(this.metroLabel11);
            this.tabMessage.Controls.Add(this.textMessage2);
            this.tabMessage.Controls.Add(this.metroLabel12);
            this.tabMessage.Location = new System.Drawing.Point(4, 38);
            this.tabMessage.Name = "tabMessage";
            this.tabMessage.Size = new System.Drawing.Size(622, 286);
            this.tabMessage.TabIndex = 2;
            this.tabMessage.Text = "Single Message";
            // 
            // textMessage
            // 
            // 
            // 
            // 
            this.textMessage.CustomButton.Image = null;
            this.textMessage.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textMessage.CustomButton.Name = "";
            this.textMessage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textMessage.CustomButton.TabIndex = 1;
            this.textMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textMessage.CustomButton.UseSelectable = true;
            this.textMessage.CustomButton.Visible = false;
            this.textMessage.Lines = new string[0];
            this.textMessage.Location = new System.Drawing.Point(85, 72);
            this.textMessage.MaxLength = 32767;
            this.textMessage.Name = "textMessage";
            this.textMessage.PasswordChar = '\0';
            this.textMessage.PromptText = "Spam Message Here";
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textMessage.SelectedText = "";
            this.textMessage.SelectionLength = 0;
            this.textMessage.SelectionStart = 0;
            this.textMessage.ShortcutsEnabled = true;
            this.textMessage.Size = new System.Drawing.Size(521, 23);
            this.textMessage.Style = MetroFramework.MetroColorStyle.Purple;
            this.textMessage.TabIndex = 3;
            this.textMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textMessage.UseSelectable = true;
            this.textMessage.WaterMark = "Spam Message Here";
            this.textMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Message:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textWebhook
            // 
            // 
            // 
            // 
            this.textWebhook.CustomButton.Image = null;
            this.textWebhook.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textWebhook.CustomButton.Name = "";
            this.textWebhook.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textWebhook.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textWebhook.CustomButton.TabIndex = 1;
            this.textWebhook.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textWebhook.CustomButton.UseSelectable = true;
            this.textWebhook.CustomButton.Visible = false;
            this.textWebhook.Lines = new string[0];
            this.textWebhook.Location = new System.Drawing.Point(85, 42);
            this.textWebhook.MaxLength = 32767;
            this.textWebhook.Name = "textWebhook";
            this.textWebhook.PasswordChar = '\0';
            this.textWebhook.PromptText = "Webhook Link Here";
            this.textWebhook.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textWebhook.SelectedText = "";
            this.textWebhook.SelectionLength = 0;
            this.textWebhook.SelectionStart = 0;
            this.textWebhook.ShortcutsEnabled = true;
            this.textWebhook.Size = new System.Drawing.Size(521, 23);
            this.textWebhook.Style = MetroFramework.MetroColorStyle.Purple;
            this.textWebhook.TabIndex = 5;
            this.textWebhook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textWebhook.UseSelectable = true;
            this.textWebhook.WaterMark = "Webhook Link Here";
            this.textWebhook.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textWebhook.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Webhook:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textInterval
            // 
            // 
            // 
            // 
            this.textInterval.CustomButton.Image = null;
            this.textInterval.CustomButton.Location = new System.Drawing.Point(70, 1);
            this.textInterval.CustomButton.Name = "";
            this.textInterval.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textInterval.CustomButton.TabIndex = 1;
            this.textInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textInterval.CustomButton.UseSelectable = true;
            this.textInterval.CustomButton.Visible = false;
            this.textInterval.Lines = new string[0];
            this.textInterval.Location = new System.Drawing.Point(85, 120);
            this.textInterval.MaxLength = 32767;
            this.textInterval.Name = "textInterval";
            this.textInterval.PasswordChar = '\0';
            this.textInterval.PromptText = "Interval (ms)";
            this.textInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textInterval.SelectedText = "";
            this.textInterval.SelectionLength = 0;
            this.textInterval.SelectionStart = 0;
            this.textInterval.ShortcutsEnabled = true;
            this.textInterval.Size = new System.Drawing.Size(92, 23);
            this.textInterval.Style = MetroFramework.MetroColorStyle.Purple;
            this.textInterval.TabIndex = 7;
            this.textInterval.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textInterval.UseSelectable = true;
            this.textInterval.WaterMark = "Interval (ms)";
            this.textInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Interval:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 196);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(139, 28);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(26, 241);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(139, 28);
            this.btnStop.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStop.UseSelectable = true;
            this.btnStop.UseStyleColors = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(461, 136);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Information:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(424, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Status:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(374, 202);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Messages Sent:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(476, 172);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 19);
            this.lblStatus.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Not Running...";
            this.lblStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.ForeColor = System.Drawing.Color.Red;
            this.lblSent.Location = new System.Drawing.Point(476, 202);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(16, 19);
            this.lblSent.Style = MetroFramework.MetroColorStyle.Purple;
            this.lblSent.TabIndex = 14;
            this.lblSent.Text = "0";
            this.lblSent.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textUsername
            // 
            // 
            // 
            // 
            this.textUsername.CustomButton.Image = null;
            this.textUsername.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.textUsername.CustomButton.Name = "";
            this.textUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername.CustomButton.TabIndex = 1;
            this.textUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername.CustomButton.UseSelectable = true;
            this.textUsername.CustomButton.Visible = false;
            this.textUsername.Lines = new string[0];
            this.textUsername.Location = new System.Drawing.Point(296, 120);
            this.textUsername.MaxLength = 32767;
            this.textUsername.Name = "textUsername";
            this.textUsername.PasswordChar = '\0';
            this.textUsername.PromptText = "Webhook Bot Name";
            this.textUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername.SelectedText = "";
            this.textUsername.SelectionLength = 0;
            this.textUsername.SelectionStart = 0;
            this.textUsername.ShortcutsEnabled = true;
            this.textUsername.Size = new System.Drawing.Size(143, 23);
            this.textUsername.Style = MetroFramework.MetroColorStyle.Purple;
            this.textUsername.TabIndex = 16;
            this.textUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textUsername.UseSelectable = true;
            this.textUsername.WaterMark = "Webhook Bot Name";
            this.textUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(224, 121);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Username:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textProfilePic
            // 
            // 
            // 
            // 
            this.textProfilePic.CustomButton.Image = null;
            this.textProfilePic.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textProfilePic.CustomButton.Name = "";
            this.textProfilePic.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textProfilePic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textProfilePic.CustomButton.TabIndex = 1;
            this.textProfilePic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textProfilePic.CustomButton.UseSelectable = true;
            this.textProfilePic.CustomButton.Visible = false;
            this.textProfilePic.Lines = new string[0];
            this.textProfilePic.Location = new System.Drawing.Point(85, 12);
            this.textProfilePic.MaxLength = 32767;
            this.textProfilePic.Name = "textProfilePic";
            this.textProfilePic.PasswordChar = '\0';
            this.textProfilePic.PromptText = "Profile picture link goes here";
            this.textProfilePic.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textProfilePic.SelectedText = "";
            this.textProfilePic.SelectionLength = 0;
            this.textProfilePic.SelectionStart = 0;
            this.textProfilePic.ShortcutsEnabled = true;
            this.textProfilePic.Size = new System.Drawing.Size(521, 23);
            this.textProfilePic.Style = MetroFramework.MetroColorStyle.Purple;
            this.textProfilePic.TabIndex = 18;
            this.textProfilePic.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textProfilePic.UseSelectable = true;
            this.textProfilePic.WaterMark = "Profile picture link goes here";
            this.textProfilePic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textProfilePic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 12);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Avatar Url:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textAvatar2
            // 
            // 
            // 
            // 
            this.textAvatar2.CustomButton.Image = null;
            this.textAvatar2.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textAvatar2.CustomButton.Name = "";
            this.textAvatar2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textAvatar2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textAvatar2.CustomButton.TabIndex = 1;
            this.textAvatar2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textAvatar2.CustomButton.UseSelectable = true;
            this.textAvatar2.CustomButton.Visible = false;
            this.textAvatar2.Lines = new string[0];
            this.textAvatar2.Location = new System.Drawing.Point(88, 16);
            this.textAvatar2.MaxLength = 32767;
            this.textAvatar2.Name = "textAvatar2";
            this.textAvatar2.PasswordChar = '\0';
            this.textAvatar2.PromptText = "Profile picture link goes here";
            this.textAvatar2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textAvatar2.SelectedText = "";
            this.textAvatar2.SelectionLength = 0;
            this.textAvatar2.SelectionStart = 0;
            this.textAvatar2.ShortcutsEnabled = true;
            this.textAvatar2.Size = new System.Drawing.Size(521, 23);
            this.textAvatar2.Style = MetroFramework.MetroColorStyle.Purple;
            this.textAvatar2.TabIndex = 26;
            this.textAvatar2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textAvatar2.UseSelectable = true;
            this.textAvatar2.WaterMark = "Profile picture link goes here";
            this.textAvatar2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textAvatar2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(16, 16);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel9.TabIndex = 25;
            this.metroLabel9.Text = "Avatar Url:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textUsername2
            // 
            // 
            // 
            // 
            this.textUsername2.CustomButton.Image = null;
            this.textUsername2.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.textUsername2.CustomButton.Name = "";
            this.textUsername2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textUsername2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textUsername2.CustomButton.TabIndex = 1;
            this.textUsername2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textUsername2.CustomButton.UseSelectable = true;
            this.textUsername2.CustomButton.Visible = false;
            this.textUsername2.Lines = new string[0];
            this.textUsername2.Location = new System.Drawing.Point(88, 76);
            this.textUsername2.MaxLength = 32767;
            this.textUsername2.Name = "textUsername2";
            this.textUsername2.PasswordChar = '\0';
            this.textUsername2.PromptText = "Webhook Bot Name";
            this.textUsername2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textUsername2.SelectedText = "";
            this.textUsername2.SelectionLength = 0;
            this.textUsername2.SelectionStart = 0;
            this.textUsername2.ShortcutsEnabled = true;
            this.textUsername2.Size = new System.Drawing.Size(143, 23);
            this.textUsername2.Style = MetroFramework.MetroColorStyle.Purple;
            this.textUsername2.TabIndex = 24;
            this.textUsername2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textUsername2.UseSelectable = true;
            this.textUsername2.WaterMark = "Webhook Bot Name";
            this.textUsername2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textUsername2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(16, 77);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(71, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel10.TabIndex = 23;
            this.metroLabel10.Text = "Username:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textWebhook2
            // 
            // 
            // 
            // 
            this.textWebhook2.CustomButton.Image = null;
            this.textWebhook2.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textWebhook2.CustomButton.Name = "";
            this.textWebhook2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textWebhook2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textWebhook2.CustomButton.TabIndex = 1;
            this.textWebhook2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textWebhook2.CustomButton.UseSelectable = true;
            this.textWebhook2.CustomButton.Visible = false;
            this.textWebhook2.Lines = new string[0];
            this.textWebhook2.Location = new System.Drawing.Point(88, 46);
            this.textWebhook2.MaxLength = 32767;
            this.textWebhook2.Name = "textWebhook2";
            this.textWebhook2.PasswordChar = '\0';
            this.textWebhook2.PromptText = "Webhook Link Here";
            this.textWebhook2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textWebhook2.SelectedText = "";
            this.textWebhook2.SelectionLength = 0;
            this.textWebhook2.SelectionStart = 0;
            this.textWebhook2.ShortcutsEnabled = true;
            this.textWebhook2.Size = new System.Drawing.Size(521, 23);
            this.textWebhook2.Style = MetroFramework.MetroColorStyle.Purple;
            this.textWebhook2.TabIndex = 22;
            this.textWebhook2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textWebhook2.UseSelectable = true;
            this.textWebhook2.WaterMark = "Webhook Link Here";
            this.textWebhook2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textWebhook2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(19, 48);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(68, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "Webhook:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textMessage2
            // 
            // 
            // 
            // 
            this.textMessage2.CustomButton.Image = null;
            this.textMessage2.CustomButton.Location = new System.Drawing.Point(499, 1);
            this.textMessage2.CustomButton.Name = "";
            this.textMessage2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textMessage2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textMessage2.CustomButton.TabIndex = 1;
            this.textMessage2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textMessage2.CustomButton.UseSelectable = true;
            this.textMessage2.CustomButton.Visible = false;
            this.textMessage2.Lines = new string[0];
            this.textMessage2.Location = new System.Drawing.Point(88, 138);
            this.textMessage2.MaxLength = 32767;
            this.textMessage2.Name = "textMessage2";
            this.textMessage2.PasswordChar = '\0';
            this.textMessage2.PromptText = "Type your message in here";
            this.textMessage2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textMessage2.SelectedText = "";
            this.textMessage2.SelectionLength = 0;
            this.textMessage2.SelectionStart = 0;
            this.textMessage2.ShortcutsEnabled = true;
            this.textMessage2.Size = new System.Drawing.Size(521, 23);
            this.textMessage2.Style = MetroFramework.MetroColorStyle.Purple;
            this.textMessage2.TabIndex = 20;
            this.textMessage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textMessage2.UseSelectable = true;
            this.textMessage2.WaterMark = "Type your message in here";
            this.textMessage2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textMessage2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textMessage2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMessage2_KeyDown);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(19, 139);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(63, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "Message:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(88, 171);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(139, 28);
            this.btnSend.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "Send";
            this.btnSend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSend.UseSelectable = true;
            this.btnSend.UseStyleColors = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.Activecolor = System.Drawing.Color.Gray;
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGithub.BorderRadius = 0;
            this.btnGithub.ButtonText = "Visit my github";
            this.btnGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGithub.DisabledColor = System.Drawing.Color.Gray;
            this.btnGithub.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGithub.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGithub.Iconimage")));
            this.btnGithub.Iconimage_right = null;
            this.btnGithub.Iconimage_right_Selected = null;
            this.btnGithub.Iconimage_Selected = null;
            this.btnGithub.IconMarginLeft = 0;
            this.btnGithub.IconMarginRight = 0;
            this.btnGithub.IconRightVisible = true;
            this.btnGithub.IconRightZoom = 0D;
            this.btnGithub.IconVisible = true;
            this.btnGithub.IconZoom = 90D;
            this.btnGithub.IsTab = false;
            this.btnGithub.Location = new System.Drawing.Point(6, 5);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGithub.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGithub.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGithub.selected = false;
            this.btnGithub.Size = new System.Drawing.Size(241, 48);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.Text = "Visit my github";
            this.btnGithub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGithub.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnGithub.TextFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.Activecolor = System.Drawing.Color.Gray;
            this.btnDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiscord.BorderRadius = 0;
            this.btnDiscord.ButtonText = "Join my discord";
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.DisabledColor = System.Drawing.Color.Gray;
            this.btnDiscord.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDiscord.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDiscord.Iconimage")));
            this.btnDiscord.Iconimage_right = null;
            this.btnDiscord.Iconimage_right_Selected = null;
            this.btnDiscord.Iconimage_Selected = null;
            this.btnDiscord.IconMarginLeft = 0;
            this.btnDiscord.IconMarginRight = 0;
            this.btnDiscord.IconRightVisible = true;
            this.btnDiscord.IconRightZoom = 0D;
            this.btnDiscord.IconVisible = true;
            this.btnDiscord.IconZoom = 100D;
            this.btnDiscord.IsTab = false;
            this.btnDiscord.Location = new System.Drawing.Point(3, 58);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnDiscord.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiscord.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDiscord.selected = false;
            this.btnDiscord.Size = new System.Drawing.Size(241, 48);
            this.btnDiscord.TabIndex = 1;
            this.btnDiscord.Text = "Join my discord";
            this.btnDiscord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscord.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnDiscord.TextFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageActive = null;
            this.btnRefresh.Location = new System.Drawing.Point(273, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(29, 29);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Zoom = 10;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(269, 32);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(104, 25);
            this.metroLabel13.TabIndex = 3;
            this.metroLabel13.Text = "Update Log:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(2, 259);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(171, 25);
            this.metroLabel14.TabIndex = 4;
            this.metroLabel14.Text = "Made by BBitar#3731";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.textUpdate);
            this.pnlScroll.Controls.Add(this.btnRefresh);
            this.pnlScroll.HorizontalScrollbar = true;
            this.pnlScroll.HorizontalScrollbarBarColor = true;
            this.pnlScroll.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlScroll.HorizontalScrollbarSize = 10;
            this.pnlScroll.Location = new System.Drawing.Point(271, 65);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(319, 155);
            this.pnlScroll.Style = MetroFramework.MetroColorStyle.Purple;
            this.pnlScroll.TabIndex = 5;
            this.pnlScroll.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlScroll.VerticalScrollbar = true;
            this.pnlScroll.VerticalScrollbarBarColor = true;
            this.pnlScroll.VerticalScrollbarHighlightOnWheel = false;
            this.pnlScroll.VerticalScrollbarSize = 10;
            // 
            // textUpdate
            // 
            this.textUpdate.AutoSize = true;
            this.textUpdate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.textUpdate.Location = new System.Drawing.Point(26, 17);
            this.textUpdate.Name = "textUpdate";
            this.textUpdate.Size = new System.Drawing.Size(60, 16);
            this.textUpdate.TabIndex = 3;
            this.textUpdate.Text = "updates";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 414);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Webhook Spammer by BBitar V1.0";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabSpammer.ResumeLayout(false);
            this.tabSpammer.PerformLayout();
            this.tabMessage.ResumeLayout(false);
            this.tabMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSpammer;
        private System.Windows.Forms.TabPage tabMessage;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroTextBox textInterval;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textWebhook;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroLabel lblSent;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textUsername;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox textProfilePic;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroTextBox textAvatar2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox textUsername2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox textWebhook2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox textMessage2;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private Bunifu.Framework.UI.BunifuFlatButton btnGithub;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private Bunifu.Framework.UI.BunifuImageButton btnRefresh;
        private Bunifu.Framework.UI.BunifuFlatButton btnDiscord;
        private MetroFramework.Controls.MetroPanel pnlScroll;
        private System.Windows.Forms.Label textUpdate;
    }
}


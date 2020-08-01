namespace LISCIO
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new ns1.BunifuFlatButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buildBtn = new ns1.BunifuFlatButton();
            this.spreadBtn = new ns1.BunifuFlatButton();
            this.visualtrackingBtn = new ns1.BunifuFlatButton();
            this.settingsButton = new ns1.BunifuFlatButton();
            this.testMail = new ns1.BunifuFlatButton();
            this.masterPage = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this._gitLink = new System.Windows.Forms.LinkLabel();
            this.passwordsBtn = new ns1.BunifuFlatButton();
            this.TopPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.masterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.TopPanel.Controls.Add(this.btnExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 25);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(2)))));
            this.headerPanel.Controls.Add(this.logo);
            this.headerPanel.Controls.Add(this.dashboardBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 25);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 70);
            this.headerPanel.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Black;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(152, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(648, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardBtn.BorderRadius = 0;
            this.dashboardBtn.ButtonText = "Dashboard";
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardBtn.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Iconimage")));
            this.dashboardBtn.Iconimage_right = null;
            this.dashboardBtn.Iconimage_right_Selected = null;
            this.dashboardBtn.Iconimage_Selected = null;
            this.dashboardBtn.IconMarginLeft = 0;
            this.dashboardBtn.IconMarginRight = 0;
            this.dashboardBtn.IconRightVisible = true;
            this.dashboardBtn.IconRightZoom = 0D;
            this.dashboardBtn.IconVisible = true;
            this.dashboardBtn.IconZoom = 90D;
            this.dashboardBtn.IsTab = false;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.dashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.dashboardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.dashboardBtn.selected = false;
            this.dashboardBtn.Size = new System.Drawing.Size(152, 70);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Textcolor = System.Drawing.Color.White;
            this.dashboardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.leftPanel.Controls.Add(this.passwordsBtn);
            this.leftPanel.Controls.Add(this.buildBtn);
            this.leftPanel.Controls.Add(this.spreadBtn);
            this.leftPanel.Controls.Add(this.visualtrackingBtn);
            this.leftPanel.Controls.Add(this.settingsButton);
            this.leftPanel.Controls.Add(this.testMail);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 95);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(151, 387);
            this.leftPanel.TabIndex = 2;
            // 
            // buildBtn
            // 
            this.buildBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.buildBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.buildBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buildBtn.BorderRadius = 0;
            this.buildBtn.ButtonText = "Server Create";
            this.buildBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildBtn.DisabledColor = System.Drawing.Color.Gray;
            this.buildBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buildBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.buildBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("buildBtn.Iconimage")));
            this.buildBtn.Iconimage_right = null;
            this.buildBtn.Iconimage_right_Selected = null;
            this.buildBtn.Iconimage_Selected = null;
            this.buildBtn.IconMarginLeft = 0;
            this.buildBtn.IconMarginRight = 0;
            this.buildBtn.IconRightVisible = true;
            this.buildBtn.IconRightZoom = 0D;
            this.buildBtn.IconVisible = true;
            this.buildBtn.IconZoom = 80D;
            this.buildBtn.IsTab = false;
            this.buildBtn.Location = new System.Drawing.Point(0, 323);
            this.buildBtn.Name = "buildBtn";
            this.buildBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.buildBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.buildBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.buildBtn.selected = false;
            this.buildBtn.Size = new System.Drawing.Size(151, 64);
            this.buildBtn.TabIndex = 11;
            this.buildBtn.Text = "Server Create";
            this.buildBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildBtn.Textcolor = System.Drawing.Color.White;
            this.buildBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildBtn.Click += new System.EventHandler(this.buildBtn_Click);
            // 
            // spreadBtn
            // 
            this.spreadBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.spreadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.spreadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spreadBtn.BorderRadius = 0;
            this.spreadBtn.ButtonText = "Spread";
            this.spreadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spreadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.spreadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.spreadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("spreadBtn.Iconimage")));
            this.spreadBtn.Iconimage_right = null;
            this.spreadBtn.Iconimage_right_Selected = null;
            this.spreadBtn.Iconimage_Selected = null;
            this.spreadBtn.IconMarginLeft = 0;
            this.spreadBtn.IconMarginRight = 0;
            this.spreadBtn.IconRightVisible = true;
            this.spreadBtn.IconRightZoom = 0D;
            this.spreadBtn.IconVisible = true;
            this.spreadBtn.IconZoom = 80D;
            this.spreadBtn.IsTab = false;
            this.spreadBtn.Location = new System.Drawing.Point(0, 193);
            this.spreadBtn.Name = "spreadBtn";
            this.spreadBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.spreadBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.spreadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.spreadBtn.selected = false;
            this.spreadBtn.Size = new System.Drawing.Size(151, 65);
            this.spreadBtn.TabIndex = 8;
            this.spreadBtn.Text = "Spread";
            this.spreadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spreadBtn.Textcolor = System.Drawing.Color.White;
            this.spreadBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadBtn.Click += new System.EventHandler(this.spreadBtn_Click);
            // 
            // visualtrackingBtn
            // 
            this.visualtrackingBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.visualtrackingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.visualtrackingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visualtrackingBtn.BorderRadius = 0;
            this.visualtrackingBtn.ButtonText = "Visual Tracking";
            this.visualtrackingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualtrackingBtn.DisabledColor = System.Drawing.Color.Gray;
            this.visualtrackingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.visualtrackingBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.visualtrackingBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("visualtrackingBtn.Iconimage")));
            this.visualtrackingBtn.Iconimage_right = null;
            this.visualtrackingBtn.Iconimage_right_Selected = null;
            this.visualtrackingBtn.Iconimage_Selected = null;
            this.visualtrackingBtn.IconMarginLeft = 0;
            this.visualtrackingBtn.IconMarginRight = 0;
            this.visualtrackingBtn.IconRightVisible = true;
            this.visualtrackingBtn.IconRightZoom = 0D;
            this.visualtrackingBtn.IconVisible = true;
            this.visualtrackingBtn.IconZoom = 80D;
            this.visualtrackingBtn.IsTab = false;
            this.visualtrackingBtn.Location = new System.Drawing.Point(0, 128);
            this.visualtrackingBtn.Name = "visualtrackingBtn";
            this.visualtrackingBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.visualtrackingBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.visualtrackingBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.visualtrackingBtn.selected = false;
            this.visualtrackingBtn.Size = new System.Drawing.Size(151, 65);
            this.visualtrackingBtn.TabIndex = 7;
            this.visualtrackingBtn.Text = "Visual Tracking";
            this.visualtrackingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visualtrackingBtn.Textcolor = System.Drawing.Color.White;
            this.visualtrackingBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualtrackingBtn.Click += new System.EventHandler(this.visualtrackingBtn_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.BorderRadius = 0;
            this.settingsButton.ButtonText = "Settings";
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.DisabledColor = System.Drawing.Color.Gray;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("settingsButton.Iconimage")));
            this.settingsButton.Iconimage_right = null;
            this.settingsButton.Iconimage_right_Selected = null;
            this.settingsButton.Iconimage_Selected = null;
            this.settingsButton.IconMarginLeft = 0;
            this.settingsButton.IconMarginRight = 0;
            this.settingsButton.IconRightVisible = true;
            this.settingsButton.IconRightZoom = 0D;
            this.settingsButton.IconVisible = true;
            this.settingsButton.IconZoom = 80D;
            this.settingsButton.IsTab = false;
            this.settingsButton.Location = new System.Drawing.Point(0, 63);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.settingsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.settingsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsButton.selected = false;
            this.settingsButton.Size = new System.Drawing.Size(151, 65);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Textcolor = System.Drawing.Color.White;
            this.settingsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click_1);
            // 
            // testMail
            // 
            this.testMail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.testMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.testMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testMail.BorderRadius = 0;
            this.testMail.ButtonText = "Test Mail";
            this.testMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testMail.DisabledColor = System.Drawing.Color.Gray;
            this.testMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.testMail.Iconcolor = System.Drawing.Color.Transparent;
            this.testMail.Iconimage = ((System.Drawing.Image)(resources.GetObject("testMail.Iconimage")));
            this.testMail.Iconimage_right = null;
            this.testMail.Iconimage_right_Selected = null;
            this.testMail.Iconimage_Selected = null;
            this.testMail.IconMarginLeft = 0;
            this.testMail.IconMarginRight = 0;
            this.testMail.IconRightVisible = true;
            this.testMail.IconRightZoom = 0D;
            this.testMail.IconVisible = true;
            this.testMail.IconZoom = 80D;
            this.testMail.IsTab = false;
            this.testMail.Location = new System.Drawing.Point(0, 0);
            this.testMail.Name = "testMail";
            this.testMail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.testMail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.testMail.OnHoverTextColor = System.Drawing.Color.White;
            this.testMail.selected = false;
            this.testMail.Size = new System.Drawing.Size(151, 63);
            this.testMail.TabIndex = 3;
            this.testMail.Text = "Test Mail";
            this.testMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.testMail.Textcolor = System.Drawing.Color.White;
            this.testMail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMail.Click += new System.EventHandler(this._testMail_Click);
            // 
            // masterPage
            // 
            this.masterPage.Controls.Add(this.pictureBox2);
            this.masterPage.Controls.Add(this.label1);
            this.masterPage.Controls.Add(this._gitLink);
            this.masterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterPage.Location = new System.Drawing.Point(151, 95);
            this.masterPage.Name = "masterPage";
            this.masterPage.Size = new System.Drawing.Size(649, 387);
            this.masterPage.TabIndex = 3;
            this.masterPage.Paint += new System.Windows.Forms.PaintEventHandler(this.masterPage_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(187, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(287, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact";
            // 
            // _gitLink
            // 
            this._gitLink.AutoSize = true;
            this._gitLink.Location = new System.Drawing.Point(279, 167);
            this._gitLink.Name = "_gitLink";
            this._gitLink.Size = new System.Drawing.Size(61, 13);
            this._gitLink.TabIndex = 0;
            this._gitLink.TabStop = true;
            this._gitLink.Text = "Github Link";
            this._gitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitLink_LinkClicked);
            // 
            // passwordsBtn
            // 
            this.passwordsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.passwordsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.passwordsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.passwordsBtn.BorderRadius = 0;
            this.passwordsBtn.ButtonText = "Passwords";
            this.passwordsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.passwordsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.passwordsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("passwordsBtn.Iconimage")));
            this.passwordsBtn.Iconimage_right = null;
            this.passwordsBtn.Iconimage_right_Selected = null;
            this.passwordsBtn.Iconimage_Selected = null;
            this.passwordsBtn.IconMarginLeft = 0;
            this.passwordsBtn.IconMarginRight = 0;
            this.passwordsBtn.IconRightVisible = true;
            this.passwordsBtn.IconRightZoom = 0D;
            this.passwordsBtn.IconVisible = true;
            this.passwordsBtn.IconZoom = 80D;
            this.passwordsBtn.IsTab = false;
            this.passwordsBtn.Location = new System.Drawing.Point(0, 258);
            this.passwordsBtn.Name = "passwordsBtn";
            this.passwordsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.passwordsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.passwordsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.passwordsBtn.selected = false;
            this.passwordsBtn.Size = new System.Drawing.Size(151, 65);
            this.passwordsBtn.TabIndex = 12;
            this.passwordsBtn.Text = "Passwords";
            this.passwordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordsBtn.Textcolor = System.Drawing.Color.White;
            this.passwordsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordsBtn.Click += new System.EventHandler(this.passwordsBtn_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.masterPage);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISCIO KEYLOGGER";
            this.TopPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.masterPage.ResumeLayout(false);
            this.masterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private ns1.BunifuFlatButton dashboardBtn;
        private ns1.BunifuFlatButton spreadBtn;
        private ns1.BunifuFlatButton visualtrackingBtn;
        private ns1.BunifuFlatButton settingsButton;
        private ns1.BunifuFlatButton testMail;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel masterPage;
        private ns1.BunifuFlatButton buildBtn;
        private System.Windows.Forms.LinkLabel _gitLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ns1.BunifuFlatButton passwordsBtn;
    }
}


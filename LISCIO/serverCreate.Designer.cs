namespace LISCIO
{
    partial class serverCreate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverCreate));
            this.mailTestBtn = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.passTxt = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.emailTxt = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.serverTxt = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.minuteUp = new System.Windows.Forms.NumericUpDown();
            this.delTime = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUp)).BeginInit();
            this.SuspendLayout();
            // 
            // mailTestBtn
            // 
            this.mailTestBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.mailTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.mailTestBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mailTestBtn.BorderRadius = 0;
            this.mailTestBtn.ButtonText = "           Create Server !";
            this.mailTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailTestBtn.DisabledColor = System.Drawing.Color.Gray;
            this.mailTestBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mailTestBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mailTestBtn.Iconimage")));
            this.mailTestBtn.Iconimage_right = null;
            this.mailTestBtn.Iconimage_right_Selected = null;
            this.mailTestBtn.Iconimage_Selected = null;
            this.mailTestBtn.IconMarginLeft = 0;
            this.mailTestBtn.IconMarginRight = 0;
            this.mailTestBtn.IconRightVisible = true;
            this.mailTestBtn.IconRightZoom = 0D;
            this.mailTestBtn.IconVisible = true;
            this.mailTestBtn.IconZoom = 90D;
            this.mailTestBtn.IsTab = false;
            this.mailTestBtn.Location = new System.Drawing.Point(196, 299);
            this.mailTestBtn.Name = "mailTestBtn";
            this.mailTestBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.mailTestBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.mailTestBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mailTestBtn.selected = false;
            this.mailTestBtn.Size = new System.Drawing.Size(247, 48);
            this.mailTestBtn.TabIndex = 54;
            this.mailTestBtn.Text = "           Create Server !";
            this.mailTestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailTestBtn.Textcolor = System.Drawing.Color.White;
            this.mailTestBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTestBtn.Click += new System.EventHandler(this.mailTestBtn_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(302, 67);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(104, 16);
            this.bunifuCustomLabel10.TabIndex = 46;
            this.bunifuCustomLabel10.Text = "Minute Setting:";
            // 
            // passTxt
            // 
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passTxt.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.passTxt.HintText = "Password";
            this.passTxt.isPassword = false;
            this.passTxt.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.passTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.passTxt.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.passTxt.LineThickness = 3;
            this.passTxt.Location = new System.Drawing.Point(17, 207);
            this.passTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(171, 44);
            this.passTxt.TabIndex = 42;
            this.passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTxt.OnValueChanged += new System.EventHandler(this.passTxt_OnValueChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(14, 189);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(68, 16);
            this.bunifuCustomLabel6.TabIndex = 41;
            this.bunifuCustomLabel6.Text = "Password";
            // 
            // emailTxt
            // 
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailTxt.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailTxt.HintText = "G-Mail Adresses";
            this.emailTxt.isPassword = false;
            this.emailTxt.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.emailTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTxt.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.emailTxt.LineThickness = 3;
            this.emailTxt.Location = new System.Drawing.Point(17, 124);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(171, 44);
            this.emailTxt.TabIndex = 40;
            this.emailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(14, 106);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(53, 16);
            this.bunifuCustomLabel5.TabIndex = 39;
            this.bunifuCustomLabel5.Text = "G-Mail";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuMaterialTextbox2.HintText = "587";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(207, 37);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(57, 44);
            this.bunifuMaterialTextbox2.TabIndex = 38;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(215, 19);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(32, 16);
            this.bunifuCustomLabel4.TabIndex = 37;
            this.bunifuCustomLabel4.Text = "Port";
            // 
            // serverTxt
            // 
            this.serverTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serverTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.serverTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serverTxt.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.serverTxt.HintText = "smtp.gmail.com";
            this.serverTxt.isPassword = false;
            this.serverTxt.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.serverTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.serverTxt.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.serverTxt.LineThickness = 3;
            this.serverTxt.Location = new System.Drawing.Point(17, 37);
            this.serverTxt.Margin = new System.Windows.Forms.Padding(4);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(171, 44);
            this.serverTxt.TabIndex = 36;
            this.serverTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(14, 19);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 16);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "Server";
            // 
            // minuteUp
            // 
            this.minuteUp.BackColor = System.Drawing.Color.Black;
            this.minuteUp.ForeColor = System.Drawing.SystemColors.Info;
            this.minuteUp.Location = new System.Drawing.Point(422, 65);
            this.minuteUp.Name = "minuteUp";
            this.minuteUp.Size = new System.Drawing.Size(120, 20);
            this.minuteUp.TabIndex = 56;
            this.minuteUp.ValueChanged += new System.EventHandler(this.delUpDown_ValueChanged);
            // 
            // delTime
            // 
            this.delTime.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.delTime.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delTime.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.delTime.Location = new System.Drawing.Point(422, 118);
            this.delTime.Name = "delTime";
            this.delTime.Size = new System.Drawing.Size(155, 20);
            this.delTime.TabIndex = 57;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(302, 124);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(87, 16);
            this.bunifuCustomLabel1.TabIndex = 58;
            this.bunifuCustomLabel1.Text = "Auto Delete:";
            // 
            // serverCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.delTime);
            this.Controls.Add(this.minuteUp);
            this.Controls.Add(this.mailTestBtn);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.serverTxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Name = "serverCreate";
            this.Size = new System.Drawing.Size(595, 359);
            ((System.ComponentModel.ISupportInitialize)(this.minuteUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuFlatButton mailTestBtn;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuMaterialTextbox passTxt;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuMaterialTextbox emailTxt;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuMaterialTextbox serverTxt;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.NumericUpDown minuteUp;
        private System.Windows.Forms.DateTimePicker delTime;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
    }
}

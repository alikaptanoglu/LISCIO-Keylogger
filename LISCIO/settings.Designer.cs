namespace LISCIO
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.startupCB = new ns1.BunifuCheckbox();
            this._groupBox = new System.Windows.Forms.GroupBox();
            this._saveSettingsBtn = new ns1.BunifuThinButton2();
            this.errTxt = new ns1.BunifuMetroTextbox();
            this.errLbl = new ns1.BunifuCustomLabel();
            this.errCB = new ns1.BunifuCheckbox();
            this.startupTxt = new ns1.BunifuMetroTextbox();
            this.startupLbl = new ns1.BunifuCustomLabel();
            this._groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startupCB
            // 
            this.startupCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.startupCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.startupCB.Checked = false;
            this.startupCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.startupCB.ForeColor = System.Drawing.Color.White;
            this.startupCB.Location = new System.Drawing.Point(105, 57);
            this.startupCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.startupCB.Name = "startupCB";
            this.startupCB.Size = new System.Drawing.Size(20, 20);
            this.startupCB.TabIndex = 0;
            // 
            // _groupBox
            // 
            this._groupBox.Controls.Add(this._saveSettingsBtn);
            this._groupBox.Controls.Add(this.errTxt);
            this._groupBox.Controls.Add(this.errLbl);
            this._groupBox.Controls.Add(this.errCB);
            this._groupBox.Controls.Add(this.startupTxt);
            this._groupBox.Controls.Add(this.startupLbl);
            this._groupBox.Controls.Add(this.startupCB);
            this._groupBox.Location = new System.Drawing.Point(35, 21);
            this._groupBox.Name = "_groupBox";
            this._groupBox.Size = new System.Drawing.Size(569, 349);
            this._groupBox.TabIndex = 1;
            this._groupBox.TabStop = false;
            this._groupBox.Text = "groupBox1";
            // 
            // _saveSettingsBtn
            // 
            this._saveSettingsBtn.ActiveBorderThickness = 1;
            this._saveSettingsBtn.ActiveCornerRadius = 20;
            this._saveSettingsBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this._saveSettingsBtn.ActiveForecolor = System.Drawing.Color.White;
            this._saveSettingsBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this._saveSettingsBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._saveSettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_saveSettingsBtn.BackgroundImage")));
            this._saveSettingsBtn.ButtonText = "Save Settings";
            this._saveSettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._saveSettingsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._saveSettingsBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this._saveSettingsBtn.IdleBorderThickness = 1;
            this._saveSettingsBtn.IdleCornerRadius = 20;
            this._saveSettingsBtn.IdleFillColor = System.Drawing.Color.Black;
            this._saveSettingsBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this._saveSettingsBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this._saveSettingsBtn.Location = new System.Drawing.Point(176, 291);
            this._saveSettingsBtn.Margin = new System.Windows.Forms.Padding(5);
            this._saveSettingsBtn.Name = "_saveSettingsBtn";
            this._saveSettingsBtn.Size = new System.Drawing.Size(181, 41);
            this._saveSettingsBtn.TabIndex = 6;
            this._saveSettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._saveSettingsBtn.Click += new System.EventHandler(this._saveSettingsBtn_Click);
            // 
            // errTxt
            // 
            this.errTxt.BorderColorFocused = System.Drawing.Color.CornflowerBlue;
            this.errTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.errTxt.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.errTxt.BorderThickness = 3;
            this.errTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errTxt.isPassword = false;
            this.errTxt.Location = new System.Drawing.Point(104, 215);
            this.errTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.errTxt.Name = "errTxt";
            this.errTxt.Size = new System.Drawing.Size(328, 57);
            this.errTxt.TabIndex = 5;
            this.errTxt.Text = "The file could not be opened, please try again!";
            this.errTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // errLbl
            // 
            this.errLbl.AutoSize = true;
            this.errLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.errLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.errLbl.Location = new System.Drawing.Point(127, 189);
            this.errLbl.Name = "errLbl";
            this.errLbl.Size = new System.Drawing.Size(179, 22);
            this.errLbl.TabIndex = 4;
            this.errLbl.Text = "Run error message";
            // 
            // errCB
            // 
            this.errCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.errCB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.errCB.Checked = false;
            this.errCB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.errCB.ForeColor = System.Drawing.Color.White;
            this.errCB.Location = new System.Drawing.Point(105, 191);
            this.errCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.errCB.Name = "errCB";
            this.errCB.Size = new System.Drawing.Size(20, 20);
            this.errCB.TabIndex = 3;
            // 
            // startupTxt
            // 
            this.startupTxt.BorderColorFocused = System.Drawing.Color.CornflowerBlue;
            this.startupTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startupTxt.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this.startupTxt.BorderThickness = 3;
            this.startupTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.startupTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startupTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startupTxt.isPassword = false;
            this.startupTxt.Location = new System.Drawing.Point(104, 87);
            this.startupTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.startupTxt.Name = "startupTxt";
            this.startupTxt.Size = new System.Drawing.Size(328, 54);
            this.startupTxt.TabIndex = 2;
            this.startupTxt.Text = "sys64.exe";
            this.startupTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // startupLbl
            // 
            this.startupLbl.AutoSize = true;
            this.startupLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startupLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startupLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startupLbl.Location = new System.Drawing.Point(127, 55);
            this.startupLbl.Name = "startupLbl";
            this.startupLbl.Size = new System.Drawing.Size(198, 22);
            this.startupLbl.TabIndex = 1;
            this.startupLbl.Text = "Add to start and run";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this._groupBox);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(649, 387);
            this._groupBox.ResumeLayout(false);
            this._groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCheckbox startupCB;
        private System.Windows.Forms.GroupBox _groupBox;
        private ns1.BunifuMetroTextbox startupTxt;
        private ns1.BunifuCustomLabel startupLbl;
        private ns1.BunifuMetroTextbox errTxt;
        private ns1.BunifuCustomLabel errLbl;
        private ns1.BunifuCheckbox errCB;
        private ns1.BunifuThinButton2 _saveSettingsBtn;
    }
}

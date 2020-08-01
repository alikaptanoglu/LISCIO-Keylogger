namespace LISCIO
{
    partial class testMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testMail));
            this._mailLbl = new ns1.BunifuCustomLabel();
            this._mailTxt = new ns1.BunifuMetroTextbox();
            this._passTxt = new ns1.BunifuMetroTextbox();
            this._passwordLbl = new ns1.BunifuCustomLabel();
            this._testBtn = new ns1.BunifuTileButton();
            this.SuspendLayout();
            // 
            // _mailLbl
            // 
            this._mailLbl.AutoSize = true;
            this._mailLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._mailLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._mailLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._mailLbl.Location = new System.Drawing.Point(46, 54);
            this._mailLbl.Name = "_mailLbl";
            this._mailLbl.Size = new System.Drawing.Size(51, 22);
            this._mailLbl.TabIndex = 0;
            this._mailLbl.Text = "Mail:";
            // 
            // _mailTxt
            // 
            this._mailTxt.BorderColorFocused = System.Drawing.Color.CornflowerBlue;
            this._mailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._mailTxt.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this._mailTxt.BorderThickness = 3;
            this._mailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._mailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this._mailTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._mailTxt.isPassword = false;
            this._mailTxt.Location = new System.Drawing.Point(153, 45);
            this._mailTxt.Margin = new System.Windows.Forms.Padding(4);
            this._mailTxt.Name = "_mailTxt";
            this._mailTxt.Size = new System.Drawing.Size(370, 44);
            this._mailTxt.TabIndex = 3;
            this._mailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // _passTxt
            // 
            this._passTxt.BorderColorFocused = System.Drawing.Color.CornflowerBlue;
            this._passTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._passTxt.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue;
            this._passTxt.BorderThickness = 3;
            this._passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._passTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this._passTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._passTxt.isPassword = true;
            this._passTxt.Location = new System.Drawing.Point(153, 133);
            this._passTxt.Margin = new System.Windows.Forms.Padding(4);
            this._passTxt.Name = "_passTxt";
            this._passTxt.Size = new System.Drawing.Size(370, 44);
            this._passTxt.TabIndex = 4;
            this._passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // _passwordLbl
            // 
            this._passwordLbl.AutoSize = true;
            this._passwordLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._passwordLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this._passwordLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._passwordLbl.Location = new System.Drawing.Point(46, 145);
            this._passwordLbl.Name = "_passwordLbl";
            this._passwordLbl.Size = new System.Drawing.Size(100, 22);
            this._passwordLbl.TabIndex = 5;
            this._passwordLbl.Text = "Password:";
            // 
            // _testBtn
            // 
            this._testBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this._testBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this._testBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(110)))));
            this._testBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this._testBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this._testBtn.ForeColor = System.Drawing.Color.White;
            this._testBtn.Image = ((System.Drawing.Image)(resources.GetObject("_testBtn.Image")));
            this._testBtn.ImagePosition = 20;
            this._testBtn.ImageZoom = 50;
            this._testBtn.LabelPosition = 41;
            this._testBtn.LabelText = "Mail Send";
            this._testBtn.Location = new System.Drawing.Point(243, 214);
            this._testBtn.Margin = new System.Windows.Forms.Padding(6);
            this._testBtn.Name = "_testBtn";
            this._testBtn.Size = new System.Drawing.Size(128, 129);
            this._testBtn.TabIndex = 6;
            this._testBtn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // testMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this._testBtn);
            this.Controls.Add(this._passwordLbl);
            this.Controls.Add(this._passTxt);
            this.Controls.Add(this._mailTxt);
            this.Controls.Add(this._mailLbl);
            this.Name = "testMail";
            this.Size = new System.Drawing.Size(595, 359);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel _mailLbl;
        private ns1.BunifuMetroTextbox _mailTxt;
        private ns1.BunifuMetroTextbox _passTxt;
        private ns1.BunifuCustomLabel _passwordLbl;
        private ns1.BunifuTileButton _testBtn;
    }
}

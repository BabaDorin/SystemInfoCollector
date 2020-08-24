namespace InfoCollector
{
    partial class Form1
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
            this.btGetInfo = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.lbFeedback = new System.Windows.Forms.Label();
            this.tbPCTempName = new System.Windows.Forms.TextBox();
            this.tbUnderline = new System.Windows.Forms.Label();
            this.btContinue = new System.Windows.Forms.Button();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.panelExport = new System.Windows.Forms.Panel();
            this.lbExport = new System.Windows.Forms.Label();
            this.rbTestAndJSON = new System.Windows.Forms.RadioButton();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGetInfo
            // 
            this.btGetInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGetInfo.BackgroundImage = global::InfoCollector.Properties.Resources.scan_DarkTheme;
            this.btGetInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGetInfo.FlatAppearance.BorderSize = 0;
            this.btGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetInfo.Location = new System.Drawing.Point(333, 156);
            this.btGetInfo.Name = "btGetInfo";
            this.btGetInfo.Size = new System.Drawing.Size(90, 90);
            this.btGetInfo.TabIndex = 1;
            this.btGetInfo.UseVisualStyleBackColor = true;
            this.btGetInfo.Click += new System.EventHandler(this.btGetInfo_Click);
            // 
            // btSettings
            // 
            this.btSettings.BackgroundImage = global::InfoCollector.Properties.Resources.settings;
            this.btSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.Location = new System.Drawing.Point(12, 12);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(43, 43);
            this.btSettings.TabIndex = 0;
            this.btSettings.UseVisualStyleBackColor = true;
            // 
            // lbFeedback
            // 
            this.lbFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFeedback.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.Location = new System.Drawing.Point(-1, 267);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(758, 26);
            this.lbFeedback.TabIndex = 2;
            this.lbFeedback.Text = "Get the info";
            this.lbFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPCTempName
            // 
            this.tbPCTempName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tbPCTempName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPCTempName.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.tbPCTempName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbPCTempName.Location = new System.Drawing.Point(230, 3);
            this.tbPCTempName.Name = "tbPCTempName";
            this.tbPCTempName.Size = new System.Drawing.Size(294, 19);
            this.tbPCTempName.TabIndex = 3;
            this.tbPCTempName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPCTempName.TextChanged += new System.EventHandler(this.tbPCTempName_TextChanged);
            // 
            // tbUnderline
            // 
            this.tbUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbUnderline.Location = new System.Drawing.Point(230, 25);
            this.tbUnderline.Name = "tbUnderline";
            this.tbUnderline.Size = new System.Drawing.Size(294, 1);
            this.tbUnderline.TabIndex = 4;
            this.tbUnderline.Text = "label1";
            // 
            // btContinue
            // 
            this.btContinue.FlatAppearance.BorderSize = 0;
            this.btContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContinue.Location = new System.Drawing.Point(323, 131);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(98, 38);
            this.btContinue.TabIndex = 5;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = true;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(204, 82);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(54, 21);
            this.rbText.TabIndex = 6;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            this.rbText.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.lbExport);
            this.panelExport.Controls.Add(this.rbTestAndJSON);
            this.panelExport.Controls.Add(this.rbJSON);
            this.panelExport.Controls.Add(this.tbPCTempName);
            this.panelExport.Controls.Add(this.rbText);
            this.panelExport.Controls.Add(this.tbUnderline);
            this.panelExport.Controls.Add(this.btContinue);
            this.panelExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExport.Location = new System.Drawing.Point(0, 292);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(757, 185);
            this.panelExport.TabIndex = 7;
            // 
            // lbExport
            // 
            this.lbExport.AutoSize = true;
            this.lbExport.Location = new System.Drawing.Point(310, 49);
            this.lbExport.Name = "lbExport";
            this.lbExport.Size = new System.Drawing.Size(125, 17);
            this.lbExport.TabIndex = 9;
            this.lbExport.Text = "Export preferences";
            // 
            // rbTestAndJSON
            // 
            this.rbTestAndJSON.AutoSize = true;
            this.rbTestAndJSON.Checked = true;
            this.rbTestAndJSON.Location = new System.Drawing.Point(475, 82);
            this.rbTestAndJSON.Name = "rbTestAndJSON";
            this.rbTestAndJSON.Size = new System.Drawing.Size(122, 21);
            this.rbTestAndJSON.TabIndex = 8;
            this.rbTestAndJSON.TabStop = true;
            this.rbTestAndJSON.Text = "Text and JSON ";
            this.rbTestAndJSON.UseVisualStyleBackColor = true;
            this.rbTestAndJSON.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbJSON
            // 
            this.rbJSON.AutoSize = true;
            this.rbJSON.Location = new System.Drawing.Point(345, 82);
            this.rbJSON.Name = "rbJSON";
            this.rbJSON.Size = new System.Drawing.Size(59, 21);
            this.rbJSON.TabIndex = 7;
            this.rbJSON.Text = "JSON";
            this.rbJSON.UseVisualStyleBackColor = true;
            this.rbJSON.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(757, 477);
            this.Controls.Add(this.panelExport);
            this.Controls.Add(this.lbFeedback);
            this.Controls.Add(this.btGetInfo);
            this.Controls.Add(this.btSettings);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoCollector";
            this.panelExport.ResumeLayout(false);
            this.panelExport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btGetInfo;
        private System.Windows.Forms.Label lbFeedback;
        private System.Windows.Forms.TextBox tbPCTempName;
        private System.Windows.Forms.Label tbUnderline;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.Panel panelExport;
        private System.Windows.Forms.Label lbExport;
        private System.Windows.Forms.RadioButton rbTestAndJSON;
        private System.Windows.Forms.RadioButton rbJSON;
    }
}


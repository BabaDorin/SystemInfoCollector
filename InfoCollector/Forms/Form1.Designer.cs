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
            this.lbFeedback = new System.Windows.Forms.Label();
            this.tbPCTempName = new System.Windows.Forms.TextBox();
            this.tbUnderline = new System.Windows.Forms.Label();
            this.btContinue = new System.Windows.Forms.Button();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.panelExport = new System.Windows.Forms.Panel();
            this.btSeeModifyData = new System.Windows.Forms.Button();
            this.lbExport = new System.Windows.Forms.Label();
            this.rbTestAndJSON = new System.Windows.Forms.RadioButton();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btIntroduceData = new System.Windows.Forms.Button();
            this.btGetInfo = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.panelIntroduceData = new System.Windows.Forms.Panel();
            this.btIntroduce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbDisks = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGPUs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRAMChips = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panelExport.SuspendLayout();
            this.panelIntroduceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFeedback
            // 
            this.lbFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFeedback.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFeedback.Location = new System.Drawing.Point(-1, 267);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(758, 26);
            this.lbFeedback.TabIndex = 2;
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
            this.btContinue.Location = new System.Drawing.Point(388, 135);
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
            this.panelExport.Controls.Add(this.btSeeModifyData);
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
            // btSeeModifyData
            // 
            this.btSeeModifyData.FlatAppearance.BorderSize = 0;
            this.btSeeModifyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeeModifyData.Location = new System.Drawing.Point(230, 135);
            this.btSeeModifyData.Name = "btSeeModifyData";
            this.btSeeModifyData.Size = new System.Drawing.Size(130, 38);
            this.btSeeModifyData.TabIndex = 10;
            this.btSeeModifyData.Text = "See/Modify data";
            this.btSeeModifyData.UseVisualStyleBackColor = true;
            this.btSeeModifyData.Click += new System.EventHandler(this.btSeeModifyData_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Introduce data manually";
            // 
            // btIntroduceData
            // 
            this.btIntroduceData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btIntroduceData.BackgroundImage = global::InfoCollector.Properties.Resources.manually;
            this.btIntroduceData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btIntroduceData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIntroduceData.FlatAppearance.BorderSize = 0;
            this.btIntroduceData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIntroduceData.Location = new System.Drawing.Point(420, 156);
            this.btIntroduceData.Name = "btIntroduceData";
            this.btIntroduceData.Size = new System.Drawing.Size(90, 90);
            this.btIntroduceData.TabIndex = 9;
            this.btIntroduceData.UseVisualStyleBackColor = true;
            this.btIntroduceData.Click += new System.EventHandler(this.btIntroduceData_Click);
            // 
            // btGetInfo
            // 
            this.btGetInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGetInfo.BackgroundImage = global::InfoCollector.Properties.Resources.scan_DarkTheme;
            this.btGetInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGetInfo.FlatAppearance.BorderSize = 0;
            this.btGetInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetInfo.Location = new System.Drawing.Point(270, 156);
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
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // panelIntroduceData
            // 
            this.panelIntroduceData.Controls.Add(this.label9);
            this.panelIntroduceData.Controls.Add(this.tbRAMChips);
            this.panelIntroduceData.Controls.Add(this.label10);
            this.panelIntroduceData.Controls.Add(this.label7);
            this.panelIntroduceData.Controls.Add(this.tbGPUs);
            this.panelIntroduceData.Controls.Add(this.label8);
            this.panelIntroduceData.Controls.Add(this.label6);
            this.panelIntroduceData.Controls.Add(this.label5);
            this.panelIntroduceData.Controls.Add(this.btIntroduce);
            this.panelIntroduceData.Controls.Add(this.label3);
            this.panelIntroduceData.Controls.Add(this.radioButton1);
            this.panelIntroduceData.Controls.Add(this.radioButton2);
            this.panelIntroduceData.Controls.Add(this.tbDisks);
            this.panelIntroduceData.Controls.Add(this.radioButton3);
            this.panelIntroduceData.Controls.Add(this.label4);
            this.panelIntroduceData.Controls.Add(this.button2);
            this.panelIntroduceData.Location = new System.Drawing.Point(2, 289);
            this.panelIntroduceData.Name = "panelIntroduceData";
            this.panelIntroduceData.Size = new System.Drawing.Size(757, 185);
            this.panelIntroduceData.TabIndex = 11;
            this.panelIntroduceData.Visible = false;
            // 
            // btIntroduce
            // 
            this.btIntroduce.Enabled = false;
            this.btIntroduce.FlatAppearance.BorderSize = 0;
            this.btIntroduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIntroduce.Location = new System.Drawing.Point(313, 38);
            this.btIntroduce.Name = "btIntroduce";
            this.btIntroduce.Size = new System.Drawing.Size(130, 38);
            this.btIntroduce.TabIndex = 10;
            this.btIntroduce.Text = "Introduce data";
            this.btIntroduce.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Export preferences";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(475, 139);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Text and JSON ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(345, 139);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 21);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "JSON";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbDisks
            // 
            this.tbDisks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tbDisks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisks.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.tbDisks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbDisks.Location = new System.Drawing.Point(268, 4);
            this.tbDisks.Name = "tbDisks";
            this.tbDisks.Size = new System.Drawing.Size(68, 19);
            this.tbDisks.TabIndex = 3;
            this.tbDisks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDisks.TextChanged += new System.EventHandler(this.tbDisks_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(204, 139);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "Text";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(266, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 1);
            this.label4.TabIndex = 4;
            this.label4.Text = "label1";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(647, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "disks:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "GPUs:";
            // 
            // tbGPUs
            // 
            this.tbGPUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tbGPUs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGPUs.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.tbGPUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbGPUs.Location = new System.Drawing.Point(414, 4);
            this.tbGPUs.Name = "tbGPUs";
            this.tbGPUs.Size = new System.Drawing.Size(68, 19);
            this.tbGPUs.TabIndex = 13;
            this.tbGPUs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGPUs.TextChanged += new System.EventHandler(this.tbGPUs_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(412, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 1);
            this.label8.TabIndex = 14;
            this.label8.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "RAM Chips:";
            // 
            // tbRAMChips
            // 
            this.tbRAMChips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tbRAMChips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRAMChips.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.tbRAMChips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbRAMChips.Location = new System.Drawing.Point(580, 6);
            this.tbRAMChips.Name = "tbRAMChips";
            this.tbRAMChips.Size = new System.Drawing.Size(68, 19);
            this.tbRAMChips.TabIndex = 16;
            this.tbRAMChips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRAMChips.TextChanged += new System.EventHandler(this.tbRAMChips_TextChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.label10.Location = new System.Drawing.Point(578, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 1);
            this.label10.TabIndex = 17;
            this.label10.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(757, 477);
            this.Controls.Add(this.panelIntroduceData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btIntroduceData);
            this.Controls.Add(this.label1);
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
            this.panelIntroduceData.ResumeLayout(false);
            this.panelIntroduceData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btSeeModifyData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btIntroduceData;
        private System.Windows.Forms.Panel panelIntroduceData;
        private System.Windows.Forms.Button btIntroduce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbDisks;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRAMChips;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGPUs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}


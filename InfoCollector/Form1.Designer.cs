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
            this.lbFeedback.Size = new System.Drawing.Size(758, 201);
            this.lbFeedback.TabIndex = 2;
            this.lbFeedback.Text = "Get the info";
            this.lbFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(757, 477);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btGetInfo;
        private System.Windows.Forms.Label lbFeedback;
    }
}


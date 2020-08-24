namespace InfoCollector
{
    partial class Settings
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
            this.lbOutputPath = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbUnderline = new System.Windows.Forms.Label();
            this.btBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOutputPath
            // 
            this.lbOutputPath.AutoSize = true;
            this.lbOutputPath.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lbOutputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.lbOutputPath.Location = new System.Drawing.Point(97, 66);
            this.lbOutputPath.Name = "lbOutputPath";
            this.lbOutputPath.Size = new System.Drawing.Size(94, 19);
            this.lbOutputPath.TabIndex = 0;
            this.lbOutputPath.Text = "Output Path";
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.tbPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPath.Enabled = false;
            this.tbPath.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbPath.Location = new System.Drawing.Point(208, 66);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(250, 20);
            this.tbPath.TabIndex = 1;
            // 
            // tbUnderline
            // 
            this.tbUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.tbUnderline.Location = new System.Drawing.Point(208, 89);
            this.tbUnderline.Name = "tbUnderline";
            this.tbUnderline.Size = new System.Drawing.Size(250, 1);
            this.tbUnderline.TabIndex = 5;
            this.tbUnderline.Text = "label1";
            // 
            // btBrowser
            // 
            this.btBrowser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.btBrowser.Location = new System.Drawing.Point(475, 67);
            this.btBrowser.Name = "btBrowser";
            this.btBrowser.Size = new System.Drawing.Size(48, 23);
            this.btBrowser.TabIndex = 6;
            this.btBrowser.Text = "...";
            this.btBrowser.UseVisualStyleBackColor = true;
            this.btBrowser.Click += new System.EventHandler(this.btBrowser_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(565, 431);
            this.Controls.Add(this.btBrowser);
            this.Controls.Add(this.tbUnderline);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbOutputPath);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOutputPath;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label tbUnderline;
        private System.Windows.Forms.Button btBrowser;
    }
}
namespace InfoCollector.Forms
{
    partial class SeeModifyForm
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
            this.btGoBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.paddingLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExitSavingChanges = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGoBack
            // 
            this.btGoBack.BackgroundImage = global::InfoCollector.Properties.Resources.back;
            this.btGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btGoBack.FlatAppearance.BorderSize = 0;
            this.btGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGoBack.Location = new System.Drawing.Point(3, -3);
            this.btGoBack.Name = "btGoBack";
            this.btGoBack.Size = new System.Drawing.Size(77, 74);
            this.btGoBack.TabIndex = 0;
            this.btGoBack.UseVisualStyleBackColor = true;
            this.btGoBack.Click += new System.EventHandler(this.btGoBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btGoBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 74);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(315, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "System information";
            // 
            // panelData
            // 
            this.panelData.AutoScroll = true;
            this.panelData.Location = new System.Drawing.Point(122, 80);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(526, 363);
            this.panelData.TabIndex = 2;
            // 
            // paddingLeft
            // 
            this.paddingLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.paddingLeft.Location = new System.Drawing.Point(0, 74);
            this.paddingLeft.Name = "paddingLeft";
            this.paddingLeft.Size = new System.Drawing.Size(116, 403);
            this.paddingLeft.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(654, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 403);
            this.panel2.TabIndex = 4;
            // 
            // btExitSavingChanges
            // 
            this.btExitSavingChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(120)))));
            this.btExitSavingChanges.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btExitSavingChanges.FlatAppearance.BorderSize = 0;
            this.btExitSavingChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitSavingChanges.Location = new System.Drawing.Point(116, 445);
            this.btExitSavingChanges.Name = "btExitSavingChanges";
            this.btExitSavingChanges.Size = new System.Drawing.Size(538, 32);
            this.btExitSavingChanges.TabIndex = 0;
            this.btExitSavingChanges.Text = "Exit saving changes";
            this.btExitSavingChanges.UseVisualStyleBackColor = false;
            this.btExitSavingChanges.Click += new System.EventHandler(this.btExitSavingChanges_Click);
            // 
            // SeeModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(757, 477);
            this.Controls.Add(this.btExitSavingChanges);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paddingLeft);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(241)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SeeModifyForm";
            this.Text = "SeeModifyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel paddingLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExitSavingChanges;
    }
}
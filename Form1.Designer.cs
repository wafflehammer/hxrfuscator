
namespace nigfuscator
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
            this.SelectProjectButton = new System.Windows.Forms.Button();
            this.SelectOutputFolderButton = new System.Windows.Forms.Button();
            this.NiggersLolButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectProjectButton
            // 
            this.SelectProjectButton.Location = new System.Drawing.Point(47, 163);
            this.SelectProjectButton.Name = "SelectProjectButton";
            this.SelectProjectButton.Size = new System.Drawing.Size(182, 47);
            this.SelectProjectButton.TabIndex = 0;
            this.SelectProjectButton.Text = "Select Project Directory";
            this.SelectProjectButton.UseVisualStyleBackColor = true;
            this.SelectProjectButton.Click += new System.EventHandler(this.SelectProjectButton_Click);
            // 
            // SelectOutputFolderButton
            // 
            this.SelectOutputFolderButton.Enabled = false;
            this.SelectOutputFolderButton.Location = new System.Drawing.Point(572, 163);
            this.SelectOutputFolderButton.Name = "SelectOutputFolderButton";
            this.SelectOutputFolderButton.Size = new System.Drawing.Size(182, 47);
            this.SelectOutputFolderButton.TabIndex = 1;
            this.SelectOutputFolderButton.Text = "Select Output Directory";
            this.SelectOutputFolderButton.UseVisualStyleBackColor = true;
            this.SelectOutputFolderButton.Click += new System.EventHandler(this.SelectOutputFolderButton_Click);
            // 
            // NiggersLolButton
            // 
            this.NiggersLolButton.Enabled = false;
            this.NiggersLolButton.Location = new System.Drawing.Point(292, 391);
            this.NiggersLolButton.Name = "NiggersLolButton";
            this.NiggersLolButton.Size = new System.Drawing.Size(218, 47);
            this.NiggersLolButton.TabIndex = 2;
            this.NiggersLolButton.Text = "Engage \'Hard-R\' Niggafuscation";
            this.NiggersLolButton.UseVisualStyleBackColor = true;
            this.NiggersLolButton.Click += new System.EventHandler(this.NiggersLolButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::nigfuscator.Properties.Resources.symbol_black_power_1_orig;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NiggersLolButton);
            this.Controls.Add(this.SelectOutputFolderButton);
            this.Controls.Add(this.SelectProjectButton);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectProjectButton;
        private System.Windows.Forms.Button SelectOutputFolderButton;
        private System.Windows.Forms.Button NiggersLolButton;
    }
}


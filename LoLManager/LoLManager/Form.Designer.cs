namespace LoLManager
{
    partial class Form
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
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.lcsLabel = new System.Windows.Forms.Label();
            this.lcsPicture = new System.Windows.Forms.PictureBox();
            this.lecLabel = new System.Windows.Forms.Label();
            this.lecPicture = new System.Windows.Forms.PictureBox();
            this.prompter = new System.Windows.Forms.Label();
            this.selectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // selectionPanel
            // 
            this.selectionPanel.Controls.Add(this.lcsLabel);
            this.selectionPanel.Controls.Add(this.lcsPicture);
            this.selectionPanel.Controls.Add(this.lecLabel);
            this.selectionPanel.Controls.Add(this.lecPicture);
            this.selectionPanel.Controls.Add(this.prompter);
            this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectionPanel.Location = new System.Drawing.Point(0, 0);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(1012, 611);
            this.selectionPanel.TabIndex = 0;
            // 
            // lcsLabel
            // 
            this.lcsLabel.AutoSize = true;
            this.lcsLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcsLabel.Location = new System.Drawing.Point(266, 427);
            this.lcsLabel.Name = "lcsLabel";
            this.lcsLabel.Size = new System.Drawing.Size(73, 36);
            this.lcsLabel.TabIndex = 5;
            this.lcsLabel.Text = "LCS";
            // 
            // lcsPicture
            // 
            this.lcsPicture.BackColor = System.Drawing.Color.Transparent;
            this.lcsPicture.BackgroundImage = global::LoLManager.Properties.Resources.lcs_Logo;
            this.lcsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lcsPicture.Location = new System.Drawing.Point(200, 200);
            this.lcsPicture.Name = "lcsPicture";
            this.lcsPicture.Size = new System.Drawing.Size(200, 200);
            this.lcsPicture.TabIndex = 4;
            this.lcsPicture.TabStop = false;
            this.lcsPicture.Click += new System.EventHandler(this.lcsPicture_Click);
            this.lcsPicture.MouseEnter += new System.EventHandler(this.lcs_MouseEnter);
            this.lcsPicture.MouseLeave += new System.EventHandler(this.lcs_MouseLeave);
            // 
            // lecLabel
            // 
            this.lecLabel.AutoSize = true;
            this.lecLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecLabel.Location = new System.Drawing.Point(663, 427);
            this.lecLabel.Name = "lecLabel";
            this.lecLabel.Size = new System.Drawing.Size(83, 36);
            this.lecLabel.TabIndex = 3;
            this.lecLabel.Text = "LEC \n";
            // 
            // lecPicture
            // 
            this.lecPicture.BackColor = System.Drawing.Color.Transparent;
            this.lecPicture.BackgroundImage = global::LoLManager.Properties.Resources.lec_Logo;
            this.lecPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lecPicture.Location = new System.Drawing.Point(600, 200);
            this.lecPicture.Name = "lecPicture";
            this.lecPicture.Size = new System.Drawing.Size(200, 200);
            this.lecPicture.TabIndex = 2;
            this.lecPicture.TabStop = false;
            this.lecPicture.Click += new System.EventHandler(this.lecPicture_Click);
            this.lecPicture.MouseEnter += new System.EventHandler(this.lec_MouseEnter);
            this.lecPicture.MouseLeave += new System.EventHandler(this.lec_MouseLeave);
            // 
            // prompter
            // 
            this.prompter.AutoSize = true;
            this.prompter.BackColor = System.Drawing.Color.Transparent;
            this.prompter.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompter.Location = new System.Drawing.Point(332, 101);
            this.prompter.Name = "prompter";
            this.prompter.Size = new System.Drawing.Size(316, 40);
            this.prompter.TabIndex = 0;
            this.prompter.Text = "Choose your League!";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.Controls.Add(this.selectionPanel);
            this.Name = "Form";
            this.Text = "Form1";
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void lec_MouseEnter(object sender, System.EventArgs e)
        {
            this.lecPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lecLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void lec_MouseLeave(object sender, System.EventArgs e)
        {
            this.lecPicture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecLabel.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lcs_MouseEnter(object sender, System.EventArgs e)
        {
            this.lcsPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lcsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void lcs_MouseLeave(object sender, System.EventArgs e)
        {
            this.lcsPicture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lcsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Label prompter;
        private System.Windows.Forms.PictureBox lecPicture;
        private System.Windows.Forms.Label lecLabel;
        private System.Windows.Forms.PictureBox lcsPicture;
        private System.Windows.Forms.Label lcsLabel;
    }
}


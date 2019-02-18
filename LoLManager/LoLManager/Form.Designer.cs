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
            this.lcsSelectorPanel = new System.Windows.Forms.Panel();
            this.proceedButton = new System.Windows.Forms.Button();
            this.teamInfoPanel = new System.Windows.Forms.Panel();
            this.teamNamesLabel = new System.Windows.Forms.Label();
            this.rollIndicator = new System.Windows.Forms.Label();
            this.infoTeamPicture = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.TSMLogo = new System.Windows.Forms.PictureBox();
            this.TLLogo = new System.Windows.Forms.PictureBox();
            this.OpticLogo = new System.Windows.Forms.PictureBox();
            this.GoldenGLogo = new System.Windows.Forms.PictureBox();
            this.FlyQLogo = new System.Windows.Forms.PictureBox();
            this.EchoFoxLogo = new System.Windows.Forms.PictureBox();
            this.CLGLogo = new System.Windows.Forms.PictureBox();
            this.CGLogo = new System.Windows.Forms.PictureBox();
            this.C9Logo = new System.Windows.Forms.PictureBox();
            this.ThievesLogo = new System.Windows.Forms.PictureBox();
            this.lcsLabel = new System.Windows.Forms.Label();
            this.lcsPicture = new System.Windows.Forms.PictureBox();
            this.lecLabel = new System.Windows.Forms.Label();
            this.lecPicture = new System.Windows.Forms.PictureBox();
            this.prompter = new System.Windows.Forms.Label();
            this.overviewPanel = new System.Windows.Forms.Panel();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.selectionPanel.SuspendLayout();
            this.lcsSelectorPanel.SuspendLayout();
            this.teamInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTeamPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSMLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpticLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldenGLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyQLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EchoFoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLGLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C9Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThievesLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecPicture)).BeginInit();
            this.overviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionPanel
            // 
            this.selectionPanel.Controls.Add(this.lcsSelectorPanel);
            this.selectionPanel.Controls.Add(this.lcsLabel);
            this.selectionPanel.Controls.Add(this.lcsPicture);
            this.selectionPanel.Controls.Add(this.lecLabel);
            this.selectionPanel.Controls.Add(this.lecPicture);
            this.selectionPanel.Controls.Add(this.prompter);
            this.selectionPanel.Location = new System.Drawing.Point(3, 2);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(1012, 611);
            this.selectionPanel.TabIndex = 0;
            // 
            // lcsSelectorPanel
            // 
            this.lcsSelectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.lcsSelectorPanel.Controls.Add(this.proceedButton);
            this.lcsSelectorPanel.Controls.Add(this.teamInfoPanel);
            this.lcsSelectorPanel.Controls.Add(this.backButton);
            this.lcsSelectorPanel.Controls.Add(this.TSMLogo);
            this.lcsSelectorPanel.Controls.Add(this.TLLogo);
            this.lcsSelectorPanel.Controls.Add(this.OpticLogo);
            this.lcsSelectorPanel.Controls.Add(this.GoldenGLogo);
            this.lcsSelectorPanel.Controls.Add(this.FlyQLogo);
            this.lcsSelectorPanel.Controls.Add(this.EchoFoxLogo);
            this.lcsSelectorPanel.Controls.Add(this.CLGLogo);
            this.lcsSelectorPanel.Controls.Add(this.CGLogo);
            this.lcsSelectorPanel.Controls.Add(this.C9Logo);
            this.lcsSelectorPanel.Controls.Add(this.ThievesLogo);
            this.lcsSelectorPanel.Location = new System.Drawing.Point(9, 10);
            this.lcsSelectorPanel.Name = "lcsSelectorPanel";
            this.lcsSelectorPanel.Size = new System.Drawing.Size(1012, 611);
            this.lcsSelectorPanel.TabIndex = 6;
            this.lcsSelectorPanel.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(931, 575);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(75, 23);
            this.proceedButton.TabIndex = 12;
            this.proceedButton.Text = "proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // teamInfoPanel
            // 
            this.teamInfoPanel.BackColor = System.Drawing.Color.White;
            this.teamInfoPanel.Controls.Add(this.teamNamesLabel);
            this.teamInfoPanel.Controls.Add(this.rollIndicator);
            this.teamInfoPanel.Controls.Add(this.infoTeamPicture);
            this.teamInfoPanel.Location = new System.Drawing.Point(499, 49);
            this.teamInfoPanel.Name = "teamInfoPanel";
            this.teamInfoPanel.Size = new System.Drawing.Size(406, 501);
            this.teamInfoPanel.TabIndex = 11;
            this.teamInfoPanel.Visible = false;
            // 
            // teamNamesLabel
            // 
            this.teamNamesLabel.AutoSize = true;
            this.teamNamesLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNamesLabel.Location = new System.Drawing.Point(123, 232);
            this.teamNamesLabel.Name = "teamNamesLabel";
            this.teamNamesLabel.Size = new System.Drawing.Size(115, 189);
            this.teamNamesLabel.TabIndex = 2;
            this.teamNamesLabel.Text = "Ssumday\nAnda\nHuhi\nBang\nAphromoo\n\nProlly";
            // 
            // rollIndicator
            // 
            this.rollIndicator.AutoSize = true;
            this.rollIndicator.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollIndicator.Location = new System.Drawing.Point(15, 232);
            this.rollIndicator.Name = "rollIndicator";
            this.rollIndicator.Size = new System.Drawing.Size(93, 189);
            this.rollIndicator.TabIndex = 1;
            this.rollIndicator.Text = "Top:\nJungle:\nMid:\nADC:\nSupport:\n\nCoach:";
            // 
            // infoTeamPicture
            // 
            this.infoTeamPicture.BackgroundImage = global::LoLManager.Properties.Resources._100T;
            this.infoTeamPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoTeamPicture.Location = new System.Drawing.Point(20, 23);
            this.infoTeamPicture.Name = "infoTeamPicture";
            this.infoTeamPicture.Size = new System.Drawing.Size(237, 206);
            this.infoTeamPicture.TabIndex = 0;
            this.infoTeamPicture.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(830, 575);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TSMLogo
            // 
            this.TSMLogo.BackColor = System.Drawing.Color.Transparent;
            this.TSMLogo.BackgroundImage = global::LoLManager.Properties.Resources.Team_SoloMid;
            this.TSMLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TSMLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.TSMLogo.Location = new System.Drawing.Point(250, 490);
            this.TSMLogo.Name = "TSMLogo";
            this.TSMLogo.Size = new System.Drawing.Size(80, 80);
            this.TSMLogo.TabIndex = 9;
            this.TSMLogo.TabStop = false;
            this.TSMLogo.Click += new System.EventHandler(this.TSMLogo_Click);
            // 
            // TLLogo
            // 
            this.TLLogo.BackColor = System.Drawing.Color.Transparent;
            this.TLLogo.BackgroundImage = global::LoLManager.Properties.Resources.Team_Liquid;
            this.TLLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TLLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.TLLogo.Location = new System.Drawing.Point(250, 369);
            this.TLLogo.Name = "TLLogo";
            this.TLLogo.Size = new System.Drawing.Size(80, 80);
            this.TLLogo.TabIndex = 8;
            this.TLLogo.TabStop = false;
            this.TLLogo.Click += new System.EventHandler(this.TLLogo_Click);
            // 
            // OpticLogo
            // 
            this.OpticLogo.BackColor = System.Drawing.Color.Transparent;
            this.OpticLogo.BackgroundImage = global::LoLManager.Properties.Resources.OpTic_Gaming;
            this.OpticLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpticLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.OpticLogo.Location = new System.Drawing.Point(250, 269);
            this.OpticLogo.Name = "OpticLogo";
            this.OpticLogo.Size = new System.Drawing.Size(95, 80);
            this.OpticLogo.TabIndex = 7;
            this.OpticLogo.TabStop = false;
            this.OpticLogo.Click += new System.EventHandler(this.OpticLogo_Click);
            // 
            // GoldenGLogo
            // 
            this.GoldenGLogo.BackColor = System.Drawing.Color.Transparent;
            this.GoldenGLogo.BackgroundImage = global::LoLManager.Properties.Resources.Golden_Guardians;
            this.GoldenGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoldenGLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.GoldenGLogo.Location = new System.Drawing.Point(250, 157);
            this.GoldenGLogo.Name = "GoldenGLogo";
            this.GoldenGLogo.Size = new System.Drawing.Size(80, 80);
            this.GoldenGLogo.TabIndex = 6;
            this.GoldenGLogo.TabStop = false;
            this.GoldenGLogo.Click += new System.EventHandler(this.GoldenGLogo_Click);
            // 
            // FlyQLogo
            // 
            this.FlyQLogo.BackColor = System.Drawing.Color.Transparent;
            this.FlyQLogo.BackgroundImage = global::LoLManager.Properties.Resources.FlyQuest;
            this.FlyQLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlyQLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.FlyQLogo.Location = new System.Drawing.Point(250, 40);
            this.FlyQLogo.Name = "FlyQLogo";
            this.FlyQLogo.Size = new System.Drawing.Size(80, 80);
            this.FlyQLogo.TabIndex = 5;
            this.FlyQLogo.TabStop = false;
            this.FlyQLogo.Click += new System.EventHandler(this.FlyQLogo_Click);
            // 
            // EchoFoxLogo
            // 
            this.EchoFoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.EchoFoxLogo.BackgroundImage = global::LoLManager.Properties.Resources.Echo_Fox;
            this.EchoFoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EchoFoxLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.EchoFoxLogo.Location = new System.Drawing.Point(30, 490);
            this.EchoFoxLogo.Name = "EchoFoxLogo";
            this.EchoFoxLogo.Size = new System.Drawing.Size(95, 80);
            this.EchoFoxLogo.TabIndex = 4;
            this.EchoFoxLogo.TabStop = false;
            this.EchoFoxLogo.Click += new System.EventHandler(this.EchoFoxLogo_Click);
            // 
            // CLGLogo
            // 
            this.CLGLogo.BackColor = System.Drawing.Color.Transparent;
            this.CLGLogo.BackgroundImage = global::LoLManager.Properties.Resources.CLG;
            this.CLGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CLGLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.CLGLogo.Location = new System.Drawing.Point(30, 373);
            this.CLGLogo.Name = "CLGLogo";
            this.CLGLogo.Size = new System.Drawing.Size(100, 80);
            this.CLGLogo.TabIndex = 3;
            this.CLGLogo.TabStop = false;
            this.CLGLogo.Click += new System.EventHandler(this.CLGLogo_Click);
            // 
            // CGLogo
            // 
            this.CGLogo.BackColor = System.Drawing.Color.Transparent;
            this.CGLogo.BackgroundImage = global::LoLManager.Properties.Resources.Clutch_Gaming;
            this.CGLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CGLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.CGLogo.Location = new System.Drawing.Point(30, 269);
            this.CGLogo.Name = "CGLogo";
            this.CGLogo.Size = new System.Drawing.Size(80, 80);
            this.CGLogo.TabIndex = 2;
            this.CGLogo.TabStop = false;
            this.CGLogo.Click += new System.EventHandler(this.CGLogo_Click);
            // 
            // C9Logo
            // 
            this.C9Logo.BackColor = System.Drawing.Color.Transparent;
            this.C9Logo.BackgroundImage = global::LoLManager.Properties.Resources.C9;
            this.C9Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.C9Logo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.C9Logo.Location = new System.Drawing.Point(30, 157);
            this.C9Logo.Name = "C9Logo";
            this.C9Logo.Size = new System.Drawing.Size(100, 80);
            this.C9Logo.TabIndex = 1;
            this.C9Logo.TabStop = false;
            this.C9Logo.Click += new System.EventHandler(this.C9Logo_Click);
            // 
            // ThievesLogo
            // 
            this.ThievesLogo.BackColor = System.Drawing.Color.Transparent;
            this.ThievesLogo.BackgroundImage = global::LoLManager.Properties.Resources._100T;
            this.ThievesLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThievesLogo.InitialImage = global::LoLManager.Properties.Resources._100T;
            this.ThievesLogo.Location = new System.Drawing.Point(30, 40);
            this.ThievesLogo.Name = "ThievesLogo";
            this.ThievesLogo.Size = new System.Drawing.Size(95, 80);
            this.ThievesLogo.TabIndex = 0;
            this.ThievesLogo.TabStop = false;
            this.ThievesLogo.Click += new System.EventHandler(this.ThievesLogo_Click);
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
            // overviewPanel
            // 
            this.overviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.overviewPanel.Controls.Add(this.teamNameLabel);
            this.overviewPanel.Controls.Add(this.button2);
            this.overviewPanel.Location = new System.Drawing.Point(23, 656);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(1012, 611);
            this.overviewPanel.TabIndex = 1;
            this.overviewPanel.Visible = false;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(23, 20);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(141, 36);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "teamname";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(911, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 1061);
            this.Controls.Add(this.overviewPanel);
            this.Controls.Add(this.selectionPanel);
            this.Name = "Form";
            this.Text = "Form1";
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.lcsSelectorPanel.ResumeLayout(false);
            this.teamInfoPanel.ResumeLayout(false);
            this.teamInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTeamPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TSMLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpticLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoldenGLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlyQLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EchoFoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLGLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C9Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThievesLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecPicture)).EndInit();
            this.overviewPanel.ResumeLayout(false);
            this.overviewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void lec_MouseEnter(object sender, System.EventArgs e)
        {
            this.lecLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void lec_MouseLeave(object sender, System.EventArgs e)
        {
            this.lecLabel.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void lcs_MouseEnter(object sender, System.EventArgs e)
        {
            this.lcsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        }

        private void lcs_MouseLeave(object sender, System.EventArgs e)
        {
            this.lcsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Label prompter;
        private System.Windows.Forms.PictureBox lecPicture;
        private System.Windows.Forms.Label lecLabel;
        private System.Windows.Forms.PictureBox lcsPicture;
        private System.Windows.Forms.Label lcsLabel;
        private System.Windows.Forms.Panel lcsSelectorPanel;
        private System.Windows.Forms.PictureBox ThievesLogo;
        private System.Windows.Forms.PictureBox TSMLogo;
        private System.Windows.Forms.PictureBox TLLogo;
        private System.Windows.Forms.PictureBox OpticLogo;
        private System.Windows.Forms.PictureBox GoldenGLogo;
        private System.Windows.Forms.PictureBox FlyQLogo;
        private System.Windows.Forms.PictureBox EchoFoxLogo;
        private System.Windows.Forms.PictureBox CLGLogo;
        private System.Windows.Forms.PictureBox CGLogo;
        private System.Windows.Forms.PictureBox C9Logo;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Panel teamInfoPanel;
        private System.Windows.Forms.Label rollIndicator;
        private System.Windows.Forms.PictureBox infoTeamPicture;
        private System.Windows.Forms.Label teamNamesLabel;
        private System.Windows.Forms.Button proceedButton;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLManager
{
    public partial class Form : System.Windows.Forms.Form
    {
        Data data = new Data();

        public Form()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void initOverview()
        {
            teamNameLabel.Text = data.teamName;
        }

        private void lcsPicture_Click(object sender, EventArgs e)
        {
            data.leagueName = "lcs";
            this.lcsSelectorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcsSelectorPanel.Visible = true;
        }

        private void lecPicture_Click(object sender, EventArgs e)
        {
            data.leagueName = "lec";
            this.selectionPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lcsSelectorPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.overviewPanel.Visible = false;
        }

        private void ThievesLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "100 Thieves";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void C9Logo_Click(object sender, EventArgs e)
        {
            data.teamName = "Cloud 9";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void CGLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Clutch Gaming";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void CLGLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Counter Logic Gaming";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void EchoFoxLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Echo Fox";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void FlyQLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "FlyQuest";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void GoldenGLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Golden Guardians";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void OpticLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Optic Gaming";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void TLLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Team Liquid";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }

        private void TSMLogo_Click(object sender, EventArgs e)
        {
            data.teamName = "Team SoloMid";
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }
    }
}

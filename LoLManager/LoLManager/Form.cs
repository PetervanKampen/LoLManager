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
            teamNameLabel.Text = data.selectedTeam.teamName;
        }

        public void updateTeamSelectInfo()
        {
            if (!this.teamInfoPanel.Visible)
            {
                this.teamInfoPanel.Visible = true;
            }
            else
            {
                this.teamInfoPanel.Visible = false;
            }
            this.infoTeamPicture.BackgroundImage = data.selectedTeam.logo;
            this.teamNamesLabel.Text = data.selectedTeam.topLane.name + "\n" + data.selectedTeam.jungle.name + "\n" + data.selectedTeam.mid.name + "\n"
                + data.selectedTeam.adc.name + "\n" + data.selectedTeam.support.name + "\n\n" + data.selectedTeam.coach.name + "";
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
            data.selectedTeam = data.NATeams.thieves;
            updateTeamSelectInfo();
        }

        private void C9Logo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.c9;
            updateTeamSelectInfo();     
        }

        private void CGLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.cg;
            updateTeamSelectInfo();
        }

        private void CLGLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.clg;
            updateTeamSelectInfo();
        }

        private void EchoFoxLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.efx;
            updateTeamSelectInfo();
        }

        private void FlyQLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.fly;
            updateTeamSelectInfo();
        }

        private void GoldenGLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.ggs;
            updateTeamSelectInfo();
        }

        private void OpticLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.opt;
            updateTeamSelectInfo();
        }

        private void TLLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.tl;
            updateTeamSelectInfo();
        }

        private void TSMLogo_Click(object sender, EventArgs e)
        {
            data.selectedTeam = data.NATeams.tsm;
            updateTeamSelectInfo();

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            initOverview();
            this.overviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewPanel.Visible = true;
        }
    }
}

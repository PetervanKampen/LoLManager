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
        }

        private void lcsPicture_Click(object sender, EventArgs e)
        {
            data.leagueName = "lcs";
            this.selectionPanel.Visible = false;
        }

        private void lecPicture_Click(object sender, EventArgs e)
        {
            data.leagueName = "lec";
            this.selectionPanel.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSPROEKT
{
    public partial class LoserWinner : Form
    {
        public LoserWinner(string status)
        {
            InitializeComponent();
            this.status = status;
        }

        string status;

        private void Loser_Load(object sender, EventArgs e)
        {
            if(status == "loser")
            pbLoserWinner.Image = Properties.Resources.gameOver;
            if (status == "winner")
                pbLoserWinner.Image = Properties.Resources.money;
        }

    }
}

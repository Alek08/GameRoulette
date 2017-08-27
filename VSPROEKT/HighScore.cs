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
    
    public partial class HighScore : Form
    {
        public HighScore(ListOfPlayers ListOfplayers)
        {
            InitializeComponent();
            this.ListOfplayers = ListOfplayers;
        }

        ListOfPlayers ListOfplayers;

        public void fillList() {
            lbPlayers.Items.Clear();
            foreach (Player p in ListOfplayers.players) 
                lbPlayers.Items.Add(p);
        }

        private void HighScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ListOfplayers.players.Clear();
            lbPlayers.Items.Clear();
        }
    }
}

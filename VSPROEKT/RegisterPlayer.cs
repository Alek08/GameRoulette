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
    public partial class RegisterPlayer : Form
    {
        public RegisterPlayer()
        {
            InitializeComponent();
        }


        public Player player;
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkName(tbPlayerName.Text)){
                player = new Player(tbPlayerName.Text);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else DialogResult = System.Windows.Forms.DialogResult.None;
        }

        public bool checkName(string name)
        {
            if (name.Length == 0) {
                errorProvider1.SetError(tbPlayerName, "Enter a name");
                return false;
            }
            else {
                errorProvider1.SetError(tbPlayerName, null);
                return true;
            }
        }


    }
}

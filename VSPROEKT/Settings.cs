﻿using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
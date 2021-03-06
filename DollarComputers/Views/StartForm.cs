﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers.Views
{

    public partial class StartForm : Form
    {
        
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartANewOrder_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void LoadASavedOrder_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Program.productInfoForm.openToolStripMenuItem_Click(sender, e);
            this.Hide();
        }

        private void ExitTheProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

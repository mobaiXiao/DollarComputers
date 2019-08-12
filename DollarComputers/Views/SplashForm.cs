using System;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }
    }
}

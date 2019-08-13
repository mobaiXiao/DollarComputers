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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        

        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }
    }
}

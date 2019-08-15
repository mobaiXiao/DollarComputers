using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            PlatformDataLabel.Text = Program.product.platform;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;

            GroupDataLabel.Text =Program.product.screensize + "\n\n" + 
                Program.product.RAM_size + "\n\n" + Program.product.CPU_brand + "\n\n" +
                Program.product.CPU_type + "\n\n" + Program.product.CPU_number + "\n\n" +
                Program.product.CPU_speed + "\n\n" + Program.product.HDD_size + "\n\n" +
                Program.product.GPU_Type + "\n\n" + Program.product.webcam + "\n\n" + 
                Program.product.OS;



            LogoDataLabel.Text = Program.product.manufacturer;

            double firstCost = Convert.ToDouble(String.Format("{0:C}",Program.product.cost.ToString()));
            PriceDataLabel.Text = firstCost.ToString();
            SalesTaxDataLabel.Text = (Math.Round(firstCost * 0.13, 2)).ToString();
            TotalDataLabel.Text = (Math.Round(firstCost * 1.13, 2)).ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! \n\nYour order finished.", "Thank you!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            CancelButton_Click_1(sender, e);
        }
    }
}

using DollarComputers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var cells = rows[rowIndex].Cells;


            rows[rowIndex].Selected = true;


            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.CPU_speed = cells[13].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.webcam = cells[30].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.GPU_Type = cells[19].Value.ToString();
            Program.product.CPU_number = cells[12].Value.ToString();

            ShowSelectedTextBox.Text = cells[2].Value.ToString() + " " + cells[3].Value.ToString() + " Priced at: $" + cells[1].Value.ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}

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

            string outputString = string.Empty;
            outputString = cells[2].Value.ToString() + " " + cells[3].Value.ToString() + " Priced at: $" + cells[1].Value.ToString();
            ShowSelectedTextBox.Text = outputString;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
    }
}

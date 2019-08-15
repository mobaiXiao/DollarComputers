using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            SaveFileDialog.FileName = "Product.txt";
            SaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            var _dialogResult = SaveFileDialog.ShowDialog();
            if (_dialogResult != DialogResult.Cancel)
            {
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(SaveFileDialog.FileName, FileMode.Create)))
                {
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.webcam);

                    outputStream.Flush();
                    outputStream.Close();
                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved", "Saving File..",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.FileName = "Product.txt";
            OpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            var _dialogResult = OpenFileDialog.ShowDialog();
            if (_dialogResult != DialogResult.Cancel)
            {

                try
                {
                    NextButton.Enabled = true;

                    using (StreamReader inputStream = new StreamReader(
                        File.Open(OpenFileDialog.FileName, FileMode.Open)))
                    {
                        Program.product.productID = short.Parse(inputStream.ReadLine()); ;
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                        
                        inputStream.Close();
                        inputStream.Dispose();

                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            MemoryDataLabel.Text = Program.product.RAM_size;
            LCDSizeDataLabel.Text = Program.product.screensize;
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;
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
            Program.selectForm.Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            double firstCost = Convert.ToDouble(String.Format("{0:C}", Program.product.cost.ToString()));
            CostDataLabel.Text = firstCost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;
            MemoryDataLabel.Text = Program.product.RAM_size;
            LCDSizeDataLabel.Text = Program.product.screensize;
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;

            NextButton.Enabled = (ModelDataLabel.Text != string.Empty) ? true : false;
        }
    }
}

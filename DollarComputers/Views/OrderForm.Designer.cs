namespace DollarComputers.Views
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SysComponentGroupBox = new System.Windows.Forms.GroupBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.GroupDataLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.ComputerLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LogoDataLabel = new System.Windows.Forms.Label();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SysComponentGroupBox.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "OrderFormMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fileToolStripMenuItem.Text = "&File         ";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 3;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 14;
            this.TotalLine.X2 = 344;
            this.TotalLine.Y1 = 110;
            this.TotalLine.Y2 = 110;
            // 
            // SysComponentGroupBox
            // 
            this.SysComponentGroupBox.Controls.Add(this.GroupDataLabel);
            this.SysComponentGroupBox.Controls.Add(this.OSLabel);
            this.SysComponentGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SysComponentGroupBox.Controls.Add(this.WebCamLabel);
            this.SysComponentGroupBox.Controls.Add(this.HDDLabel);
            this.SysComponentGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SysComponentGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SysComponentGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SysComponentGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SysComponentGroupBox.Controls.Add(this.MemoryLabel);
            this.SysComponentGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SysComponentGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.SysComponentGroupBox.Controls.Add(this.ConditionDataLabel);
            this.SysComponentGroupBox.Controls.Add(this.PlatformDataLabel);
            this.SysComponentGroupBox.Controls.Add(this.PlatformLabel);
            this.SysComponentGroupBox.Controls.Add(this.ConditionLabel);
            this.SysComponentGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SysComponentGroupBox.Controls.Add(this.shapeContainer2);
            this.SysComponentGroupBox.Location = new System.Drawing.Point(12, 27);
            this.SysComponentGroupBox.Name = "SysComponentGroupBox";
            this.SysComponentGroupBox.Size = new System.Drawing.Size(421, 522);
            this.SysComponentGroupBox.TabIndex = 6;
            this.SysComponentGroupBox.TabStop = false;
            this.SysComponentGroupBox.Text = "System Components";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -1;
            this.lineShape1.X2 = 382;
            this.lineShape1.Y1 = 112;
            this.lineShape1.Y2 = 112;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(415, 497);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(29, 34);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(82, 35);
            this.ConditionLabel.TabIndex = 6;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer3);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(439, 293);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(333, 201);
            this.YourPriceGroupBox.TabIndex = 7;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.Location = new System.Drawing.Point(690, 511);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(79, 35);
            this.FinishButton.TabIndex = 14;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Location = new System.Drawing.Point(594, 511);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(79, 35);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Location = new System.Drawing.Point(497, 511);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 35);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(3, 22);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer3.Size = new System.Drawing.Size(327, 176);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(1, 84);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(110, 35);
            this.ManufacturerLabel.TabIndex = 8;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlatformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformDataLabel.Location = new System.Drawing.Point(302, 34);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(102, 35);
            this.PlatformDataLabel.TabIndex = 11;
            this.PlatformDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(223, 34);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(73, 35);
            this.PlatformLabel.TabIndex = 10;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConditionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionDataLabel.Location = new System.Drawing.Point(117, 34);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(102, 35);
            this.ConditionDataLabel.TabIndex = 12;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManufacturerDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(117, 84);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(102, 35);
            this.ManufacturerDataLabel.TabIndex = 13;
            this.ManufacturerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelDataLabel.Location = new System.Drawing.Point(314, 111);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(102, 35);
            this.ModelDataLabel.TabIndex = 15;
            this.ModelDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(247, 111);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(61, 35);
            this.ModelLabel.TabIndex = 14;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(26, 152);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(85, 35);
            this.LCDSizeLabel.TabIndex = 14;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(26, 187);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(85, 35);
            this.MemoryLabel.TabIndex = 15;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(11, 222);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(100, 35);
            this.CPUBrandLabel.TabIndex = 16;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(26, 397);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(85, 35);
            this.GPUTypeLabel.TabIndex = 19;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(26, 257);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(85, 35);
            this.CPUTypeLabel.TabIndex = 20;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(-5, 292);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(116, 35);
            this.CPUNumberLabel.TabIndex = 21;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(26, 362);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(85, 35);
            this.HDDLabel.TabIndex = 22;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Location = new System.Drawing.Point(26, 432);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(85, 35);
            this.WebCamLabel.TabIndex = 23;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(-1, 327);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(112, 35);
            this.CPUSpeedLabel.TabIndex = 24;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Location = new System.Drawing.Point(68, 467);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(43, 35);
            this.OSLabel.TabIndex = 25;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupDataLabel
            // 
            this.GroupDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupDataLabel.Location = new System.Drawing.Point(117, 152);
            this.GroupDataLabel.Name = "GroupDataLabel";
            this.GroupDataLabel.Size = new System.Drawing.Size(287, 350);
            this.GroupDataLabel.TabIndex = 26;
            this.GroupDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PriceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceDataLabel.Location = new System.Drawing.Point(225, 44);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(102, 35);
            this.PriceDataLabel.TabIndex = 9;
            this.PriceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(13, 44);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(50, 35);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Location = new System.Drawing.Point(13, 87);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 35);
            this.SalesTaxLabel.TabIndex = 10;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            this.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SalesTaxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(225, 87);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(102, 35);
            this.SalesTaxDataLabel.TabIndex = 11;
            this.SalesTaxDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Location = new System.Drawing.Point(13, 143);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(50, 35);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDataLabel.Location = new System.Drawing.Point(225, 143);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(102, 35);
            this.TotalDataLabel.TabIndex = 13;
            this.TotalDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComputerLogoPictureBox
            // 
            this.ComputerLogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComputerLogoPictureBox.BackgroundImage")));
            this.ComputerLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerLogoPictureBox.Location = new System.Drawing.Point(478, 74);
            this.ComputerLogoPictureBox.Name = "ComputerLogoPictureBox";
            this.ComputerLogoPictureBox.Size = new System.Drawing.Size(264, 188);
            this.ComputerLogoPictureBox.TabIndex = 16;
            this.ComputerLogoPictureBox.TabStop = false;
            // 
            // LogoDataLabel
            // 
            this.LogoDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoDataLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LogoDataLabel.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoDataLabel.Location = new System.Drawing.Point(514, 111);
            this.LogoDataLabel.Name = "LogoDataLabel";
            this.LogoDataLabel.Size = new System.Drawing.Size(194, 63);
            this.LogoDataLabel.TabIndex = 17;
            this.LogoDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.LogoDataLabel);
            this.Controls.Add(this.ComputerLogoPictureBox);
            this.Controls.Add(this.ModelDataLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.SysComponentGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SysComponentGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.GroupBox SysComponentGroupBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label GroupDataLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.PictureBox ComputerLogoPictureBox;
        private System.Windows.Forms.Label LogoDataLabel;
    }
}
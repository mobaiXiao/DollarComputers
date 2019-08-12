namespace DollarComputers.Views
{
    partial class StartForm
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
            this.StartANewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartANewOrder
            // 
            this.StartANewOrder.Location = new System.Drawing.Point(49, 269);
            this.StartANewOrder.Name = "StartANewOrder";
            this.StartANewOrder.Size = new System.Drawing.Size(183, 52);
            this.StartANewOrder.TabIndex = 0;
            this.StartANewOrder.Text = "start a new order";
            this.StartANewOrder.UseVisualStyleBackColor = true;
            this.StartANewOrder.Click += new System.EventHandler(this.StartANewOrder_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.ControlBox = false;
            this.Controls.Add(this.StartANewOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.Text = "Welcome to Dollar Computer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartANewOrder;
    }
}


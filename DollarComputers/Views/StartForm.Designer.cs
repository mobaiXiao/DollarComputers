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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartANewOrder = new System.Windows.Forms.Button();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadASavedOrder = new System.Windows.Forms.Button();
            this.ExitTheProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartANewOrder
            // 
            this.StartANewOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartANewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartANewOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartANewOrder.Location = new System.Drawing.Point(59, 297);
            this.StartANewOrder.Name = "StartANewOrder";
            this.StartANewOrder.Size = new System.Drawing.Size(154, 37);
            this.StartANewOrder.TabIndex = 0;
            this.StartANewOrder.Text = "Start a new order";
            this.StartANewOrder.UseVisualStyleBackColor = false;
            this.StartANewOrder.Click += new System.EventHandler(this.StartANewOrder_Click);
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartFormPictureBox.BackgroundImage")));
            this.StartFormPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartFormPictureBox.Location = new System.Drawing.Point(12, 63);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(256, 202);
            this.StartFormPictureBox.TabIndex = 1;
            this.StartFormPictureBox.TabStop = false;
            // 
            // LoadASavedOrder
            // 
            this.LoadASavedOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadASavedOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadASavedOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadASavedOrder.Location = new System.Drawing.Point(59, 340);
            this.LoadASavedOrder.Name = "LoadASavedOrder";
            this.LoadASavedOrder.Size = new System.Drawing.Size(154, 37);
            this.LoadASavedOrder.TabIndex = 2;
            this.LoadASavedOrder.Text = "Load a saved order";
            this.LoadASavedOrder.UseVisualStyleBackColor = false;
            this.LoadASavedOrder.Click += new System.EventHandler(this.LoadASavedOrder_Click);
            // 
            // ExitTheProgram
            // 
            this.ExitTheProgram.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ExitTheProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitTheProgram.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitTheProgram.Location = new System.Drawing.Point(59, 383);
            this.ExitTheProgram.Name = "ExitTheProgram";
            this.ExitTheProgram.Size = new System.Drawing.Size(154, 37);
            this.ExitTheProgram.TabIndex = 3;
            this.ExitTheProgram.Text = "Exit the program";
            this.ExitTheProgram.UseVisualStyleBackColor = false;
            this.ExitTheProgram.Click += new System.EventHandler(this.ExitTheProgram_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 457);
            this.ControlBox = false;
            this.Controls.Add(this.ExitTheProgram);
            this.Controls.Add(this.LoadASavedOrder);
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.StartANewOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartANewOrder;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
        private System.Windows.Forms.Button LoadASavedOrder;
        private System.Windows.Forms.Button ExitTheProgram;
    }
}


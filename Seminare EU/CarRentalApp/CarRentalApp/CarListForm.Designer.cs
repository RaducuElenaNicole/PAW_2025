namespace CarRentalApp {
    partial class CarListForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.carListMenuStrip = new System.Windows.Forms.MenuStrip();
            this.masiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.carListMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Location = new System.Drawing.Point(18, 85);
            this.carsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.RowHeadersWidth = 62;
            this.carsDataGridView.Size = new System.Drawing.Size(1164, 589);
            this.carsDataGridView.TabIndex = 0;
            this.carsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataGridView_CellContentClick);
            // 
            // carListMenuStrip
            // 
            this.carListMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.carListMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.carListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masiniToolStripMenuItem});
            this.carListMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.carListMenuStrip.Name = "carListMenuStrip";
            this.carListMenuStrip.Size = new System.Drawing.Size(1376, 33);
            this.carListMenuStrip.TabIndex = 1;
            this.carListMenuStrip.Text = "menuStrip1";
            // 
            // masiniToolStripMenuItem
            // 
            this.masiniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.masiniToolStripMenuItem.Name = "masiniToolStripMenuItem";
            this.masiniToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.masiniToolStripMenuItem.Text = "Masini";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.addCarToolStripMenuItem.Text = "Adauga";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // CarListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 692);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.carListMenuStrip);
            this.MainMenuStrip = this.carListMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarListForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.carListMenuStrip.ResumeLayout(false);
            this.carListMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.MenuStrip carListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem masiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
    }
}


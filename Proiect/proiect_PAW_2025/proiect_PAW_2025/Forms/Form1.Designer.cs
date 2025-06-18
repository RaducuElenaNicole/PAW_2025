namespace proiect_PAW_2025
{
    partial class Form1
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
            this.insertButton = new System.Windows.Forms.Button();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.gestiuneStoc_DataGridView = new System.Windows.Forms.DataGridView();
            this.productie_DataGridView = new System.Windows.Forms.DataGridView();
            this.addProductie_button = new System.Windows.Forms.Button();
            this.addGestiuneStoc_Button = new System.Windows.Forms.Button();
            this.editProdus_Button = new System.Windows.Forms.Button();
            this.deleteProdus_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneStoc_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productie_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(29, 29);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(152, 38);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Adauga produs ";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(29, 105);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowHeadersWidth = 62;
            this.productsDataGridView.RowTemplate.Height = 28;
            this.productsDataGridView.Size = new System.Drawing.Size(678, 311);
            this.productsDataGridView.TabIndex = 1;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // gestiuneStoc_DataGridView
            // 
            this.gestiuneStoc_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestiuneStoc_DataGridView.Location = new System.Drawing.Point(29, 458);
            this.gestiuneStoc_DataGridView.Name = "gestiuneStoc_DataGridView";
            this.gestiuneStoc_DataGridView.RowHeadersWidth = 62;
            this.gestiuneStoc_DataGridView.RowTemplate.Height = 28;
            this.gestiuneStoc_DataGridView.Size = new System.Drawing.Size(678, 204);
            this.gestiuneStoc_DataGridView.TabIndex = 2;
            // 
            // productie_DataGridView
            // 
            this.productie_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productie_DataGridView.Location = new System.Drawing.Point(29, 695);
            this.productie_DataGridView.Name = "productie_DataGridView";
            this.productie_DataGridView.RowHeadersWidth = 62;
            this.productie_DataGridView.RowTemplate.Height = 28;
            this.productie_DataGridView.Size = new System.Drawing.Size(678, 185);
            this.productie_DataGridView.TabIndex = 3;
            // 
            // addProductie_button
            // 
            this.addProductie_button.Location = new System.Drawing.Point(759, 105);
            this.addProductie_button.Name = "addProductie_button";
            this.addProductie_button.Size = new System.Drawing.Size(189, 79);
            this.addProductie_button.TabIndex = 4;
            this.addProductie_button.Text = "Adauga detalii despre productie pentru produsul selectat";
            this.addProductie_button.UseVisualStyleBackColor = true;
            this.addProductie_button.Click += new System.EventHandler(this.addProductie_button_Click);
            // 
            // addGestiuneStoc_Button
            // 
            this.addGestiuneStoc_Button.Location = new System.Drawing.Point(998, 105);
            this.addGestiuneStoc_Button.Name = "addGestiuneStoc_Button";
            this.addGestiuneStoc_Button.Size = new System.Drawing.Size(189, 79);
            this.addGestiuneStoc_Button.TabIndex = 5;
            this.addGestiuneStoc_Button.Text = "Adauga detalii despre gestionarea stocului \r\npentru produsul selectat";
            this.addGestiuneStoc_Button.UseVisualStyleBackColor = true;
            this.addGestiuneStoc_Button.Click += new System.EventHandler(this.addGestiuneStoc_Button_Click);
            // 
            // editProdus_Button
            // 
            this.editProdus_Button.Location = new System.Drawing.Point(227, 29);
            this.editProdus_Button.Name = "editProdus_Button";
            this.editProdus_Button.Size = new System.Drawing.Size(152, 38);
            this.editProdus_Button.TabIndex = 6;
            this.editProdus_Button.Text = "Editeaza produs ";
            this.editProdus_Button.UseVisualStyleBackColor = true;
            this.editProdus_Button.Click += new System.EventHandler(this.editProdus_Button_Click);
            // 
            // deleteProdus_button
            // 
            this.deleteProdus_button.Location = new System.Drawing.Point(453, 29);
            this.deleteProdus_button.Name = "deleteProdus_button";
            this.deleteProdus_button.Size = new System.Drawing.Size(152, 38);
            this.deleteProdus_button.TabIndex = 7;
            this.deleteProdus_button.Text = "Sterge produs ";
            this.deleteProdus_button.UseVisualStyleBackColor = true;
            this.deleteProdus_button.Click += new System.EventHandler(this.deleteProdus_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 926);
            this.Controls.Add(this.deleteProdus_button);
            this.Controls.Add(this.editProdus_Button);
            this.Controls.Add(this.addGestiuneStoc_Button);
            this.Controls.Add(this.addProductie_button);
            this.Controls.Add(this.productie_DataGridView);
            this.Controls.Add(this.gestiuneStoc_DataGridView);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.insertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestiuneStoc_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productie_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridView gestiuneStoc_DataGridView;
        private System.Windows.Forms.DataGridView productie_DataGridView;
        private System.Windows.Forms.Button addProductie_button;
        private System.Windows.Forms.Button addGestiuneStoc_Button;
        private System.Windows.Forms.Button editProdus_Button;
        private System.Windows.Forms.Button deleteProdus_button;
    }
}


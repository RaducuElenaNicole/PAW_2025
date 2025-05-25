namespace PAW_seminar5_24_03_2025
{
    partial class AddCarForm
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
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.seatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.licenseNumberLabel = new System.Windows.Forms.Label();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.hasInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.saveCarButton = new System.Windows.Forms.Button();
            this.cancelCarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(28, 30);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(53, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Marca";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(216, 30);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(323, 26);
            this.makeTextBox.TabIndex = 1;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(32, 79);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(52, 20);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(216, 79);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(323, 26);
            this.modelTextBox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(32, 131);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(98, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "An fabricatie";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(216, 129);
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(323, 26);
            this.yearNumericUpDown.TabIndex = 5;
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Location = new System.Drawing.Point(32, 186);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(97, 20);
            this.seatsLabel.TabIndex = 6;
            this.seatsLabel.Text = "Numar locuri";
            // 
            // seatsNumericUpDown
            // 
            this.seatsNumericUpDown.Location = new System.Drawing.Point(216, 186);
            this.seatsNumericUpDown.Name = "seatsNumericUpDown";
            this.seatsNumericUpDown.Size = new System.Drawing.Size(323, 26);
            this.seatsNumericUpDown.TabIndex = 7;
            // 
            // licenseNumberLabel
            // 
            this.licenseNumberLabel.AutoSize = true;
            this.licenseNumberLabel.Location = new System.Drawing.Point(33, 238);
            this.licenseNumberLabel.Name = "licenseNumberLabel";
            this.licenseNumberLabel.Size = new System.Drawing.Size(150, 20);
            this.licenseNumberLabel.TabIndex = 8;
            this.licenseNumberLabel.Text = "Numar inmatriculare";
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Location = new System.Drawing.Point(216, 238);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(323, 26);
            this.licenseNumberTextBox.TabIndex = 9;
            // 
            // hasInsuranceCheckBox
            // 
            this.hasInsuranceCheckBox.AutoSize = true;
            this.hasInsuranceCheckBox.Location = new System.Drawing.Point(44, 318);
            this.hasInsuranceCheckBox.Name = "hasInsuranceCheckBox";
            this.hasInsuranceCheckBox.Size = new System.Drawing.Size(139, 24);
            this.hasInsuranceCheckBox.TabIndex = 10;
            this.hasInsuranceCheckBox.Text = "Are asigurare?";
            this.hasInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveCarButton
            // 
            this.saveCarButton.Location = new System.Drawing.Point(363, 352);
            this.saveCarButton.Name = "saveCarButton";
            this.saveCarButton.Size = new System.Drawing.Size(154, 30);
            this.saveCarButton.TabIndex = 11;
            this.saveCarButton.Text = "Salveaza ";
            this.saveCarButton.UseVisualStyleBackColor = true;
            this.saveCarButton.Click += new System.EventHandler(this.saveCarButton_Click);
            // 
            // cancelCarButton
            // 
            this.cancelCarButton.Location = new System.Drawing.Point(550, 352);
            this.cancelCarButton.Name = "cancelCarButton";
            this.cancelCarButton.Size = new System.Drawing.Size(154, 30);
            this.cancelCarButton.TabIndex = 12;
            this.cancelCarButton.Text = "Anuleaza";
            this.cancelCarButton.UseVisualStyleBackColor = true;
            this.cancelCarButton.Click += new System.EventHandler(this.cancelCarButton_Click);
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelCarButton);
            this.Controls.Add(this.saveCarButton);
            this.Controls.Add(this.hasInsuranceCheckBox);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.licenseNumberLabel);
            this.Controls.Add(this.seatsNumericUpDown);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.makeLabel);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.NumericUpDown seatsNumericUpDown;
        private System.Windows.Forms.Label licenseNumberLabel;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.CheckBox hasInsuranceCheckBox;
        private System.Windows.Forms.Button saveCarButton;
        private System.Windows.Forms.Button cancelCarButton;
    }
}
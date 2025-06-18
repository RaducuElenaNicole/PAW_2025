namespace proiect_PAW_2025.Forms
{
    partial class FormGestiuneStoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.categorieNume_TextBox = new System.Windows.Forms.TextBox();
            this.categorieID_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.afisareDetaliiGestiuneStoc_button = new System.Windows.Forms.Button();
            this.stare_ComboBox = new System.Windows.Forms.ComboBox();
            this.validariGestiuneStoc_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validariGestiuneStoc_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume categorie";
            // 
            // categorieNume_TextBox
            // 
            this.categorieNume_TextBox.Location = new System.Drawing.Point(230, 52);
            this.categorieNume_TextBox.Name = "categorieNume_TextBox";
            this.categorieNume_TextBox.Size = new System.Drawing.Size(194, 26);
            this.categorieNume_TextBox.TabIndex = 1;
            // 
            // categorieID_textBox
            // 
            this.categorieID_textBox.Location = new System.Drawing.Point(230, 114);
            this.categorieID_textBox.Name = "categorieID_textBox";
            this.categorieID_textBox.Size = new System.Drawing.Size(194, 26);
            this.categorieID_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categorie ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stare";
            // 
            // afisareDetaliiGestiuneStoc_button
            // 
            this.afisareDetaliiGestiuneStoc_button.Location = new System.Drawing.Point(538, 54);
            this.afisareDetaliiGestiuneStoc_button.Name = "afisareDetaliiGestiuneStoc_button";
            this.afisareDetaliiGestiuneStoc_button.Size = new System.Drawing.Size(209, 34);
            this.afisareDetaliiGestiuneStoc_button.TabIndex = 6;
            this.afisareDetaliiGestiuneStoc_button.Text = "Afiseaza detaliile introduse";
            this.afisareDetaliiGestiuneStoc_button.UseVisualStyleBackColor = true;
            this.afisareDetaliiGestiuneStoc_button.Click += new System.EventHandler(this.afisareDetaliiGestiuneStoc_button_Click);
            // 
            // stare_ComboBox
            // 
            this.stare_ComboBox.FormattingEnabled = true;
            this.stare_ComboBox.Items.AddRange(new object[] {
            "Nou",
            "Defect",
            "Reambalat",
            "Returnat"});
            this.stare_ComboBox.Location = new System.Drawing.Point(230, 169);
            this.stare_ComboBox.Name = "stare_ComboBox";
            this.stare_ComboBox.Size = new System.Drawing.Size(194, 28);
            this.stare_ComboBox.TabIndex = 7;
            // 
            // validariGestiuneStoc_ErrorProvider
            // 
            this.validariGestiuneStoc_ErrorProvider.ContainerControl = this;
            // 
            // FormGestiuneStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stare_ComboBox);
            this.Controls.Add(this.afisareDetaliiGestiuneStoc_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorieID_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorieNume_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormGestiuneStoc";
            this.Text = "FormGestiuneStoc";
            ((System.ComponentModel.ISupportInitialize)(this.validariGestiuneStoc_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categorieNume_TextBox;
        private System.Windows.Forms.TextBox categorieID_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button afisareDetaliiGestiuneStoc_button;
        private System.Windows.Forms.ComboBox stare_ComboBox;
        private System.Windows.Forms.ErrorProvider validariGestiuneStoc_ErrorProvider;
    }
}
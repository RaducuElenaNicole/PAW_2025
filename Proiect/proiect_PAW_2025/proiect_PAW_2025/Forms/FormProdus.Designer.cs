namespace proiect_PAW_2025.Forms
{
    partial class FormProdus
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
            this.cod_TextBox = new System.Windows.Forms.TextBox();
            this.denumire_TextBox = new System.Windows.Forms.TextBox();
            this.Denumire = new System.Windows.Forms.Label();
            this.pret_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantitate_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detaliiButton = new System.Windows.Forms.Button();
            this.validareIntroducereDetalii_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.validareIntroducereDetalii_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // cod_TextBox
            // 
            this.cod_TextBox.Location = new System.Drawing.Point(187, 38);
            this.cod_TextBox.Name = "cod_TextBox";
            this.cod_TextBox.Size = new System.Drawing.Size(100, 26);
            this.cod_TextBox.TabIndex = 1;
            // 
            // denumire_TextBox
            // 
            this.denumire_TextBox.Location = new System.Drawing.Point(187, 82);
            this.denumire_TextBox.Name = "denumire_TextBox";
            this.denumire_TextBox.Size = new System.Drawing.Size(100, 26);
            this.denumire_TextBox.TabIndex = 3;
            // 
            // Denumire
            // 
            this.Denumire.AutoSize = true;
            this.Denumire.Location = new System.Drawing.Point(62, 82);
            this.Denumire.Name = "Denumire";
            this.Denumire.Size = new System.Drawing.Size(78, 20);
            this.Denumire.TabIndex = 2;
            this.Denumire.Text = "Denumire";
            // 
            // pret_TextBox
            // 
            this.pret_TextBox.Location = new System.Drawing.Point(187, 132);
            this.pret_TextBox.Name = "pret_TextBox";
            this.pret_TextBox.Size = new System.Drawing.Size(100, 26);
            this.pret_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pret";
            // 
            // cantitate_TextBox
            // 
            this.cantitate_TextBox.Location = new System.Drawing.Point(187, 180);
            this.cantitate_TextBox.Name = "cantitate_TextBox";
            this.cantitate_TextBox.Size = new System.Drawing.Size(100, 26);
            this.cantitate_TextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantitate";
            // 
            // detaliiButton
            // 
            this.detaliiButton.Location = new System.Drawing.Point(408, 38);
            this.detaliiButton.Name = "detaliiButton";
            this.detaliiButton.Size = new System.Drawing.Size(230, 37);
            this.detaliiButton.TabIndex = 8;
            this.detaliiButton.Text = "Afiseaza detaliile introduse";
            this.detaliiButton.UseVisualStyleBackColor = true;
            this.detaliiButton.Click += new System.EventHandler(this.detaliiButton_Click);
            // 
            // validareIntroducereDetalii_ErrorProvider
            // 
            this.validareIntroducereDetalii_ErrorProvider.ContainerControl = this;
            // 
            // FormProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detaliiButton);
            this.Controls.Add(this.cantitate_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pret_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.denumire_TextBox);
            this.Controls.Add(this.Denumire);
            this.Controls.Add(this.cod_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormProdus";
            this.Text = "FormProdus";
            ((System.ComponentModel.ISupportInitialize)(this.validareIntroducereDetalii_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cod_TextBox;
        private System.Windows.Forms.TextBox denumire_TextBox;
        private System.Windows.Forms.Label Denumire;
        private System.Windows.Forms.TextBox pret_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantitate_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button detaliiButton;
        private System.Windows.Forms.ErrorProvider validareIntroducereDetalii_ErrorProvider;
    }
}
namespace preg1
{
    partial class FormPrincipal
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
            this.adaugaProdus_btn = new System.Windows.Forms.Button();
            this.dataGridView_produseCosCumparaturi = new System.Windows.Forms.DataGridView();
            this.afiseazaCosCumparaturi_btn = new System.Windows.Forms.Button();
            this.afiseazaDetalii_btn = new System.Windows.Forms.Button();
            this.textBox_valoareTotala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_numarProduse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produseCosCumparaturi)).BeginInit();
            this.SuspendLayout();
            // 
            // adaugaProdus_btn
            // 
            this.adaugaProdus_btn.Location = new System.Drawing.Point(46, 29);
            this.adaugaProdus_btn.Name = "adaugaProdus_btn";
            this.adaugaProdus_btn.Size = new System.Drawing.Size(135, 38);
            this.adaugaProdus_btn.TabIndex = 0;
            this.adaugaProdus_btn.Text = "Adauga produs";
            this.adaugaProdus_btn.UseVisualStyleBackColor = true;
            this.adaugaProdus_btn.Click += new System.EventHandler(this.adaugaProdus_btn_Click);
            // 
            // dataGridView_produseCosCumparaturi
            // 
            this.dataGridView_produseCosCumparaturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_produseCosCumparaturi.Location = new System.Drawing.Point(46, 87);
            this.dataGridView_produseCosCumparaturi.Name = "dataGridView_produseCosCumparaturi";
            this.dataGridView_produseCosCumparaturi.RowHeadersWidth = 62;
            this.dataGridView_produseCosCumparaturi.RowTemplate.Height = 28;
            this.dataGridView_produseCosCumparaturi.Size = new System.Drawing.Size(677, 250);
            this.dataGridView_produseCosCumparaturi.TabIndex = 1;
            // 
            // afiseazaCosCumparaturi_btn
            // 
            this.afiseazaCosCumparaturi_btn.Location = new System.Drawing.Point(223, 29);
            this.afiseazaCosCumparaturi_btn.Name = "afiseazaCosCumparaturi_btn";
            this.afiseazaCosCumparaturi_btn.Size = new System.Drawing.Size(239, 38);
            this.afiseazaCosCumparaturi_btn.TabIndex = 2;
            this.afiseazaCosCumparaturi_btn.Text = "Afiseaza produsele din cos";
            this.afiseazaCosCumparaturi_btn.UseVisualStyleBackColor = true;
            this.afiseazaCosCumparaturi_btn.Click += new System.EventHandler(this.afiseazaCosCumparaturi_btn_Click);
            // 
            // afiseazaDetalii_btn
            // 
            this.afiseazaDetalii_btn.Location = new System.Drawing.Point(46, 365);
            this.afiseazaDetalii_btn.Name = "afiseazaDetalii_btn";
            this.afiseazaDetalii_btn.Size = new System.Drawing.Size(223, 38);
            this.afiseazaDetalii_btn.TabIndex = 3;
            this.afiseazaDetalii_btn.Text = "Afiseaza detalii cumparaturi";
            this.afiseazaDetalii_btn.UseVisualStyleBackColor = true;
            this.afiseazaDetalii_btn.Click += new System.EventHandler(this.afiseazaDetalii_btn_Click);
            // 
            // textBox_valoareTotala
            // 
            this.textBox_valoareTotala.Location = new System.Drawing.Point(247, 434);
            this.textBox_valoareTotala.Name = "textBox_valoareTotala";
            this.textBox_valoareTotala.ReadOnly = true;
            this.textBox_valoareTotala.Size = new System.Drawing.Size(239, 26);
            this.textBox_valoareTotala.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valoare totala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numar produse din cos";
            // 
            // textBox_numarProduse
            // 
            this.textBox_numarProduse.Location = new System.Drawing.Point(247, 482);
            this.textBox_numarProduse.Name = "textBox_numarProduse";
            this.textBox_numarProduse.ReadOnly = true;
            this.textBox_numarProduse.Size = new System.Drawing.Size(239, 26);
            this.textBox_numarProduse.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_numarProduse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_valoareTotala);
            this.Controls.Add(this.afiseazaDetalii_btn);
            this.Controls.Add(this.afiseazaCosCumparaturi_btn);
            this.Controls.Add(this.dataGridView_produseCosCumparaturi);
            this.Controls.Add(this.adaugaProdus_btn);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produseCosCumparaturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adaugaProdus_btn;
        private System.Windows.Forms.DataGridView dataGridView_produseCosCumparaturi;
        private System.Windows.Forms.Button afiseazaCosCumparaturi_btn;
        private System.Windows.Forms.Button afiseazaDetalii_btn;
        private System.Windows.Forms.TextBox textBox_valoareTotala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_numarProduse;
    }
}


namespace preg1.formulare
{
    partial class FormAdaugareProdus
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
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_denumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cantitate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salveazaProdus_btn = new System.Windows.Forms.Button();
            this.errorProvider_validitateaDatelor = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_validitateaDatelor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(147, 57);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(181, 26);
            this.textBox_id.TabIndex = 1;
            // 
            // textBox_denumire
            // 
            this.textBox_denumire.Location = new System.Drawing.Point(147, 107);
            this.textBox_denumire.Name = "textBox_denumire";
            this.textBox_denumire.Size = new System.Drawing.Size(181, 26);
            this.textBox_denumire.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Denumire";
            // 
            // textBox_pret
            // 
            this.textBox_pret.Location = new System.Drawing.Point(147, 159);
            this.textBox_pret.Name = "textBox_pret";
            this.textBox_pret.Size = new System.Drawing.Size(181, 26);
            this.textBox_pret.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pret";
            // 
            // textBox_cantitate
            // 
            this.textBox_cantitate.Location = new System.Drawing.Point(147, 214);
            this.textBox_cantitate.Name = "textBox_cantitate";
            this.textBox_cantitate.Size = new System.Drawing.Size(181, 26);
            this.textBox_cantitate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantitate";
            // 
            // salveazaProdus_btn
            // 
            this.salveazaProdus_btn.Location = new System.Drawing.Point(147, 289);
            this.salveazaProdus_btn.Name = "salveazaProdus_btn";
            this.salveazaProdus_btn.Size = new System.Drawing.Size(181, 62);
            this.salveazaProdus_btn.TabIndex = 8;
            this.salveazaProdus_btn.Text = "Salveaza detaliile introduse";
            this.salveazaProdus_btn.UseVisualStyleBackColor = true;
            this.salveazaProdus_btn.Click += new System.EventHandler(this.salveazaProdus_btn_Click);
            // 
            // errorProvider_validitateaDatelor
            // 
            this.errorProvider_validitateaDatelor.ContainerControl = this;
            // 
            // FormAdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salveazaProdus_btn);
            this.Controls.Add(this.textBox_cantitate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_denumire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Name = "FormAdaugareProdus";
            this.Text = "FormAdaugareProdus";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_validitateaDatelor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_denumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_pret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cantitate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salveazaProdus_btn;
        private System.Windows.Forms.ErrorProvider errorProvider_validitateaDatelor;
    }
}
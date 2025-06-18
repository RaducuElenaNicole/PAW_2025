namespace Pregatire_test_1.WindowsForms
{
    partial class FormEditDoctor
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
            this.button_ActualizareDetaliiDoctor = new System.Windows.Forms.Button();
            this.textBox_Specializare = new System.Windows.Forms.TextBox();
            this.label_Specializare = new System.Windows.Forms.Label();
            this.textBox_Salariu = new System.Windows.Forms.TextBox();
            this.label_Salariu = new System.Windows.Forms.Label();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.label_Nume = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.errorProvider_ValidareIntroducereDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ValidareIntroducereDate)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ActualizareDetaliiDoctor
            // 
            this.button_ActualizareDetaliiDoctor.Location = new System.Drawing.Point(84, 238);
            this.button_ActualizareDetaliiDoctor.Name = "button_ActualizareDetaliiDoctor";
            this.button_ActualizareDetaliiDoctor.Size = new System.Drawing.Size(188, 32);
            this.button_ActualizareDetaliiDoctor.TabIndex = 17;
            this.button_ActualizareDetaliiDoctor.Text = "Salveaza detaliile actualizate";
            this.button_ActualizareDetaliiDoctor.UseVisualStyleBackColor = true;
            this.button_ActualizareDetaliiDoctor.Click += new System.EventHandler(this.button_ActualizareDetaliiDoctor_Click);
            // 
            // textBox_Specializare
            // 
            this.textBox_Specializare.Location = new System.Drawing.Point(163, 182);
            this.textBox_Specializare.Name = "textBox_Specializare";
            this.textBox_Specializare.Size = new System.Drawing.Size(139, 26);
            this.textBox_Specializare.TabIndex = 16;
            // 
            // label_Specializare
            // 
            this.label_Specializare.AutoSize = true;
            this.label_Specializare.Location = new System.Drawing.Point(62, 182);
            this.label_Specializare.Name = "label_Specializare";
            this.label_Specializare.Size = new System.Drawing.Size(95, 20);
            this.label_Specializare.TabIndex = 15;
            this.label_Specializare.Text = "Specializare";
            // 
            // textBox_Salariu
            // 
            this.textBox_Salariu.Location = new System.Drawing.Point(163, 134);
            this.textBox_Salariu.Name = "textBox_Salariu";
            this.textBox_Salariu.Size = new System.Drawing.Size(139, 26);
            this.textBox_Salariu.TabIndex = 14;
            // 
            // label_Salariu
            // 
            this.label_Salariu.AutoSize = true;
            this.label_Salariu.Location = new System.Drawing.Point(62, 134);
            this.label_Salariu.Name = "label_Salariu";
            this.label_Salariu.Size = new System.Drawing.Size(58, 20);
            this.label_Salariu.TabIndex = 13;
            this.label_Salariu.Text = "Salariu";
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(163, 80);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(139, 26);
            this.textBox_Nume.TabIndex = 12;
            // 
            // label_Nume
            // 
            this.label_Nume.AutoSize = true;
            this.label_Nume.Location = new System.Drawing.Point(62, 83);
            this.label_Nume.Name = "label_Nume";
            this.label_Nume.Size = new System.Drawing.Size(51, 20);
            this.label_Nume.TabIndex = 11;
            this.label_Nume.Text = "Nume";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(163, 30);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(139, 26);
            this.textBox_Id.TabIndex = 10;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(62, 33);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(26, 20);
            this.label_Id.TabIndex = 9;
            this.label_Id.Text = "ID";
            // 
            // errorProvider_ValidareIntroducereDate
            // 
            this.errorProvider_ValidareIntroducereDate.ContainerControl = this;
            // 
            // FormEditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ActualizareDetaliiDoctor);
            this.Controls.Add(this.textBox_Specializare);
            this.Controls.Add(this.label_Specializare);
            this.Controls.Add(this.textBox_Salariu);
            this.Controls.Add(this.label_Salariu);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.label_Nume);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Id);
            this.Name = "FormEditDoctor";
            this.Text = "FormEditDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ValidareIntroducereDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ActualizareDetaliiDoctor;
        private System.Windows.Forms.TextBox textBox_Specializare;
        private System.Windows.Forms.Label label_Specializare;
        private System.Windows.Forms.TextBox textBox_Salariu;
        private System.Windows.Forms.Label label_Salariu;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.Label label_Nume;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ErrorProvider errorProvider_ValidareIntroducereDate;
    }
}
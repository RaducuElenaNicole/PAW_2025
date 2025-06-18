namespace Pregatire_test_1.WindowsForms
{
    partial class FormAddDoctor
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
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Nume = new System.Windows.Forms.TextBox();
            this.label_Nume = new System.Windows.Forms.Label();
            this.textBox_Salariu = new System.Windows.Forms.TextBox();
            this.label_Salariu = new System.Windows.Forms.Label();
            this.textBox_Specializare = new System.Windows.Forms.TextBox();
            this.label_Specializare = new System.Windows.Forms.Label();
            this.button_AdaugaDetaliiDoctor = new System.Windows.Forms.Button();
            this.errorProvider_ValidareIntroducereDate = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ValidareIntroducereDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(43, 53);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(26, 20);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "ID";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(144, 50);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(139, 26);
            this.textBox_Id.TabIndex = 1;
            // 
            // textBox_Nume
            // 
            this.textBox_Nume.Location = new System.Drawing.Point(144, 100);
            this.textBox_Nume.Name = "textBox_Nume";
            this.textBox_Nume.Size = new System.Drawing.Size(139, 26);
            this.textBox_Nume.TabIndex = 3;
            // 
            // label_Nume
            // 
            this.label_Nume.AutoSize = true;
            this.label_Nume.Location = new System.Drawing.Point(43, 103);
            this.label_Nume.Name = "label_Nume";
            this.label_Nume.Size = new System.Drawing.Size(51, 20);
            this.label_Nume.TabIndex = 2;
            this.label_Nume.Text = "Nume";
            // 
            // textBox_Salariu
            // 
            this.textBox_Salariu.Location = new System.Drawing.Point(144, 154);
            this.textBox_Salariu.Name = "textBox_Salariu";
            this.textBox_Salariu.Size = new System.Drawing.Size(139, 26);
            this.textBox_Salariu.TabIndex = 5;
            // 
            // label_Salariu
            // 
            this.label_Salariu.AutoSize = true;
            this.label_Salariu.Location = new System.Drawing.Point(43, 154);
            this.label_Salariu.Name = "label_Salariu";
            this.label_Salariu.Size = new System.Drawing.Size(58, 20);
            this.label_Salariu.TabIndex = 4;
            this.label_Salariu.Text = "Salariu";
            // 
            // textBox_Specializare
            // 
            this.textBox_Specializare.Location = new System.Drawing.Point(144, 202);
            this.textBox_Specializare.Name = "textBox_Specializare";
            this.textBox_Specializare.Size = new System.Drawing.Size(139, 26);
            this.textBox_Specializare.TabIndex = 7;
            // 
            // label_Specializare
            // 
            this.label_Specializare.AutoSize = true;
            this.label_Specializare.Location = new System.Drawing.Point(43, 202);
            this.label_Specializare.Name = "label_Specializare";
            this.label_Specializare.Size = new System.Drawing.Size(95, 20);
            this.label_Specializare.TabIndex = 6;
            this.label_Specializare.Text = "Specializare";
            // 
            // button_AdaugaDetaliiDoctor
            // 
            this.button_AdaugaDetaliiDoctor.Location = new System.Drawing.Point(65, 258);
            this.button_AdaugaDetaliiDoctor.Name = "button_AdaugaDetaliiDoctor";
            this.button_AdaugaDetaliiDoctor.Size = new System.Drawing.Size(188, 32);
            this.button_AdaugaDetaliiDoctor.TabIndex = 8;
            this.button_AdaugaDetaliiDoctor.Text = "Salveaza detalii doctor";
            this.button_AdaugaDetaliiDoctor.UseVisualStyleBackColor = true;
            this.button_AdaugaDetaliiDoctor.Click += new System.EventHandler(this.button_AdaugaDetaliiDoctor_Click);
            // 
            // errorProvider_ValidareIntroducereDate
            // 
            this.errorProvider_ValidareIntroducereDate.ContainerControl = this;
            // 
            // FormAddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_AdaugaDetaliiDoctor);
            this.Controls.Add(this.textBox_Specializare);
            this.Controls.Add(this.label_Specializare);
            this.Controls.Add(this.textBox_Salariu);
            this.Controls.Add(this.label_Salariu);
            this.Controls.Add(this.textBox_Nume);
            this.Controls.Add(this.label_Nume);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label_Id);
            this.Name = "FormAddDoctor";
            this.Text = "FormAddDoctor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ValidareIntroducereDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Nume;
        private System.Windows.Forms.Label label_Nume;
        private System.Windows.Forms.TextBox textBox_Salariu;
        private System.Windows.Forms.Label label_Salariu;
        private System.Windows.Forms.TextBox textBox_Specializare;
        private System.Windows.Forms.Label label_Specializare;
        private System.Windows.Forms.Button button_AdaugaDetaliiDoctor;
        private System.Windows.Forms.ErrorProvider errorProvider_ValidareIntroducereDate;
    }
}
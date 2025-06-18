namespace Pregatire_test_1
{
    partial class PrincipalForm
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
            this.button_AddDoctor = new System.Windows.Forms.Button();
            this.dataGridView_Doctors = new System.Windows.Forms.DataGridView();
            this.button_AfisareMedici = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctors)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddDoctor
            // 
            this.button_AddDoctor.Location = new System.Drawing.Point(52, 32);
            this.button_AddDoctor.Name = "button_AddDoctor";
            this.button_AddDoctor.Size = new System.Drawing.Size(130, 34);
            this.button_AddDoctor.TabIndex = 0;
            this.button_AddDoctor.Text = "Adauga medic";
            this.button_AddDoctor.UseVisualStyleBackColor = true;
            this.button_AddDoctor.Click += new System.EventHandler(this.button_AddDoctor_Click);
            // 
            // dataGridView_Doctors
            // 
            this.dataGridView_Doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doctors.Location = new System.Drawing.Point(32, 84);
            this.dataGridView_Doctors.Name = "dataGridView_Doctors";
            this.dataGridView_Doctors.RowHeadersWidth = 62;
            this.dataGridView_Doctors.RowTemplate.Height = 28;
            this.dataGridView_Doctors.Size = new System.Drawing.Size(736, 354);
            this.dataGridView_Doctors.TabIndex = 1;
            this.dataGridView_Doctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Doctors_CellContentClick);
            // 
            // button_AfisareMedici
            // 
            this.button_AfisareMedici.Location = new System.Drawing.Point(248, 32);
            this.button_AfisareMedici.Name = "button_AfisareMedici";
            this.button_AfisareMedici.Size = new System.Drawing.Size(131, 34);
            this.button_AfisareMedici.TabIndex = 2;
            this.button_AfisareMedici.Text = "Afiseaza medicii ";
            this.button_AfisareMedici.UseVisualStyleBackColor = true;
            this.button_AfisareMedici.Click += new System.EventHandler(this.button_AfisareMedici_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.button_AfisareMedici);
            this.Controls.Add(this.dataGridView_Doctors);
            this.Controls.Add(this.button_AddDoctor);
            this.Name = "PrincipalForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddDoctor;
        private System.Windows.Forms.DataGridView dataGridView_Doctors;
        private System.Windows.Forms.Button button_AfisareMedici;
    }
}


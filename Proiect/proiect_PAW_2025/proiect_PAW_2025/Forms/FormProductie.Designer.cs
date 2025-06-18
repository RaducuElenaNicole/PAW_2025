namespace proiect_PAW_2025.Forms
{
    partial class FormProductie
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
            this.label2 = new System.Windows.Forms.Label();
            this.costProductie_TextBox = new System.Windows.Forms.TextBox();
            this.timpProductie_TextBox = new System.Windows.Forms.TextBox();
            this.validareDetaliiProductie_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.afiseazaDetaliiProductie_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.validareDetaliiProductie_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost productie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timp productie";
            // 
            // costProductie_TextBox
            // 
            this.costProductie_TextBox.Location = new System.Drawing.Point(244, 52);
            this.costProductie_TextBox.Name = "costProductie_TextBox";
            this.costProductie_TextBox.Size = new System.Drawing.Size(176, 26);
            this.costProductie_TextBox.TabIndex = 2;
            // 
            // timpProductie_TextBox
            // 
            this.timpProductie_TextBox.Location = new System.Drawing.Point(244, 101);
            this.timpProductie_TextBox.Name = "timpProductie_TextBox";
            this.timpProductie_TextBox.Size = new System.Drawing.Size(176, 26);
            this.timpProductie_TextBox.TabIndex = 3;
            // 
            // validareDetaliiProductie_ErrorProvider
            // 
            this.validareDetaliiProductie_ErrorProvider.ContainerControl = this;
            // 
            // afiseazaDetaliiProductie_button
            // 
            this.afiseazaDetaliiProductie_button.Location = new System.Drawing.Point(541, 55);
            this.afiseazaDetaliiProductie_button.Name = "afiseazaDetaliiProductie_button";
            this.afiseazaDetaliiProductie_button.Size = new System.Drawing.Size(189, 50);
            this.afiseazaDetaliiProductie_button.TabIndex = 4;
            this.afiseazaDetaliiProductie_button.Text = "Afiseaza detaliile introduse";
            this.afiseazaDetaliiProductie_button.UseVisualStyleBackColor = true;
            this.afiseazaDetaliiProductie_button.Click += new System.EventHandler(this.afiseazaDetaliiProductie_button_Click);
            // 
            // FormProductie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.afiseazaDetaliiProductie_button);
            this.Controls.Add(this.timpProductie_TextBox);
            this.Controls.Add(this.costProductie_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductie";
            this.Text = "FormProductie";
            ((System.ComponentModel.ISupportInitialize)(this.validareDetaliiProductie_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costProductie_TextBox;
        private System.Windows.Forms.TextBox timpProductie_TextBox;
        private System.Windows.Forms.ErrorProvider validareDetaliiProductie_ErrorProvider;
        private System.Windows.Forms.Button afiseazaDetaliiProductie_button;
    }
}
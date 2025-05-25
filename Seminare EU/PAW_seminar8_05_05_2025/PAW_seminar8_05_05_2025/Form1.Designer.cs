namespace PAW_seminar8_05_05_2025
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
            this.filesListView = new System.Windows.Forms.ListView();
            this.serializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesListView
            // 
            this.filesListView.HideSelection = false;
            this.filesListView.Location = new System.Drawing.Point(-5, 76);
            this.filesListView.Name = "filesListView";
            this.filesListView.Size = new System.Drawing.Size(1159, 488);
            this.filesListView.TabIndex = 0;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            // 
            // serializeButton
            // 
            this.serializeButton.Location = new System.Drawing.Point(12, 21);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(97, 28);
            this.serializeButton.TabIndex = 1;
            this.serializeButton.Text = "Serialize";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 576);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.filesListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.Button serializeButton;
    }
}


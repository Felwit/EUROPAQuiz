namespace Europaquiz
{
    partial class Vorzeitig_verlassen_bestätigen
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
            this.Ja = new System.Windows.Forms.Button();
            this.Nein = new System.Windows.Forms.Button();
            this.Kontrollfrage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ja
            // 
            this.Ja.Location = new System.Drawing.Point(42, 85);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(75, 23);
            this.Ja.TabIndex = 5;
            this.Ja.Text = "Ja";
            this.Ja.UseVisualStyleBackColor = true;
            this.Ja.Click += new System.EventHandler(this.Ja_Click);
            // 
            // Nein
            // 
            this.Nein.Location = new System.Drawing.Point(183, 85);
            this.Nein.Name = "Nein";
            this.Nein.Size = new System.Drawing.Size(75, 23);
            this.Nein.TabIndex = 4;
            this.Nein.Text = "Nein";
            this.Nein.UseVisualStyleBackColor = true;
            this.Nein.Click += new System.EventHandler(this.Nein_Click);
            // 
            // Kontrollfrage
            // 
            this.Kontrollfrage.AutoSize = true;
            this.Kontrollfrage.Location = new System.Drawing.Point(12, 40);
            this.Kontrollfrage.Name = "Kontrollfrage";
            this.Kontrollfrage.Size = new System.Drawing.Size(286, 13);
            this.Kontrollfrage.TabIndex = 3;
            this.Kontrollfrage.Text = "Wirklich Beenden? Es kann keine Urkunde erstellt werden!";
            this.Kontrollfrage.Click += new System.EventHandler(this.Kontrollfrage_Click);
            // 
            // Vorzeitig_verlassen_bestätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 158);
            this.Controls.Add(this.Ja);
            this.Controls.Add(this.Nein);
            this.Controls.Add(this.Kontrollfrage);
            this.Name = "Vorzeitig_verlassen_bestätigen";
            this.Text = "Vorzeitig_verlassen_bestätigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ja;
        private System.Windows.Forms.Button Nein;
        private System.Windows.Forms.Label Kontrollfrage;
    }
}
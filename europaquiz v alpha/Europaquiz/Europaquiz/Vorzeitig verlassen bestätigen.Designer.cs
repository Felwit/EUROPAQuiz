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
            this.mitSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ja
            // 
            this.Ja.Location = new System.Drawing.Point(15, 72);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(75, 74);
            this.Ja.TabIndex = 5;
            this.Ja.Text = "Ja, ohne Urkunde beenden.";
            this.Ja.UseVisualStyleBackColor = true;
            this.Ja.Click += new System.EventHandler(this.Ja_Click);
            // 
            // Nein
            // 
            this.Nein.Location = new System.Drawing.Point(199, 72);
            this.Nein.Name = "Nein";
            this.Nein.Size = new System.Drawing.Size(75, 74);
            this.Nein.TabIndex = 4;
            this.Nein.Text = "Nein. Nicht verlassen";
            this.Nein.UseVisualStyleBackColor = true;
            this.Nein.Click += new System.EventHandler(this.Nein_Click);
            // 
            // Kontrollfrage
            // 
            this.Kontrollfrage.AutoSize = true;
            this.Kontrollfrage.Location = new System.Drawing.Point(95, 28);
            this.Kontrollfrage.Name = "Kontrollfrage";
            this.Kontrollfrage.Size = new System.Drawing.Size(97, 13);
            this.Kontrollfrage.TabIndex = 3;
            this.Kontrollfrage.Text = "Wirklich Beenden?";
            this.Kontrollfrage.Click += new System.EventHandler(this.Kontrollfrage_Click);
            // 
            // mitSpeichern
            // 
            this.mitSpeichern.Location = new System.Drawing.Point(107, 72);
            this.mitSpeichern.Name = "mitSpeichern";
            this.mitSpeichern.Size = new System.Drawing.Size(75, 74);
            this.mitSpeichern.TabIndex = 6;
            this.mitSpeichern.Text = "Ja, beenden und Urkunde erstellen.";
            this.mitSpeichern.UseVisualStyleBackColor = true;
            this.mitSpeichern.Click += new System.EventHandler(this.mitSpeichern_Click);
            // 
            // Vorzeitig_verlassen_bestätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 158);
            this.Controls.Add(this.mitSpeichern);
            this.Controls.Add(this.Ja);
            this.Controls.Add(this.Nein);
            this.Controls.Add(this.Kontrollfrage);
            this.Name = "Vorzeitig_verlassen_bestätigen";
            this.Text = "Verlassen bestätigen.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ja;
        private System.Windows.Forms.Button Nein;
        private System.Windows.Forms.Label Kontrollfrage;
        private System.Windows.Forms.Button mitSpeichern;
    }
}
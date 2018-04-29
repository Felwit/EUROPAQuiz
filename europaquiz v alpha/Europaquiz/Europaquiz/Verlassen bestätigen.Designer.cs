namespace Europaquiz
{
    partial class Verlassen_bestätigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verlassen_bestätigen));
            this.Kontrollfrage = new System.Windows.Forms.Label();
            this.Nein = new System.Windows.Forms.Button();
            this.Ja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kontrollfrage
            // 
            this.Kontrollfrage.AutoSize = true;
            this.Kontrollfrage.Location = new System.Drawing.Point(92, 9);
            this.Kontrollfrage.Name = "Kontrollfrage";
            this.Kontrollfrage.Size = new System.Drawing.Size(99, 13);
            this.Kontrollfrage.TabIndex = 0;
            this.Kontrollfrage.Text = "Wirklich verlassen?";
            this.Kontrollfrage.Click += new System.EventHandler(this.Kontrollfrage_Click);
            // 
            // Nein
            // 
            this.Nein.Location = new System.Drawing.Point(175, 43);
            this.Nein.Name = "Nein";
            this.Nein.Size = new System.Drawing.Size(75, 23);
            this.Nein.TabIndex = 1;
            this.Nein.Text = "Nein";
            this.Nein.UseVisualStyleBackColor = true;
            this.Nein.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ja
            // 
            this.Ja.Location = new System.Drawing.Point(34, 43);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(75, 23);
            this.Ja.TabIndex = 2;
            this.Ja.Text = "Ja";
            this.Ja.UseVisualStyleBackColor = true;
            this.Ja.Click += new System.EventHandler(this.button2_Click);
            // 
            // Verlassen_bestätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 82);
            this.Controls.Add(this.Ja);
            this.Controls.Add(this.Nein);
            this.Controls.Add(this.Kontrollfrage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Verlassen_bestätigen";
            this.Text = "Verlassen_bestätigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kontrollfrage;
        private System.Windows.Forms.Button Nein;
        private System.Windows.Forms.Button Ja;
    }
}
namespace Europaquiz_Eingabe_und_Eingabeprügfung
{
    partial class Europaquiz
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_prüfe_Land_neu = new System.Windows.Forms.Button();
            this.tb_Land = new System.Windows.Forms.TextBox();
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // Button_prüfe_Land_neu
            // 
            this.Button_prüfe_Land_neu.Location = new System.Drawing.Point(447, 12);
            this.Button_prüfe_Land_neu.Name = "Button_prüfe_Land_neu";
            this.Button_prüfe_Land_neu.Size = new System.Drawing.Size(123, 20);
            this.Button_prüfe_Land_neu.TabIndex = 0;
            this.Button_prüfe_Land_neu.Text = "Nächstes Land";
            this.Button_prüfe_Land_neu.UseVisualStyleBackColor = true;
            this.Button_prüfe_Land_neu.Click += new System.EventHandler(this.Button_prüfe_Land_neu_Click);
            // 
            // tb_Land
            // 
            this.tb_Land.Location = new System.Drawing.Point(12, 12);
            this.tb_Land.Name = "tb_Land";
            this.tb_Land.Size = new System.Drawing.Size(208, 20);
            this.tb_Land.TabIndex = 1;
            this.tb_Land.Text = "Bitte geben sie das Land ein.";
            // 
            // tb_Hauptstadt
            // 
            this.tb_Hauptstadt.Location = new System.Drawing.Point(233, 12);
            this.tb_Hauptstadt.Name = "tb_Hauptstadt";
            this.tb_Hauptstadt.Size = new System.Drawing.Size(208, 20);
            this.tb_Hauptstadt.TabIndex = 2;
            this.tb_Hauptstadt.Text = "Bitte geben sie die Hauptsadt ein.";
            // 
            // Europaquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 454);
            this.Controls.Add(this.tb_Hauptstadt);
            this.Controls.Add(this.tb_Land);
            this.Controls.Add(this.Button_prüfe_Land_neu);
            this.Name = "Europaquiz";
            this.Text = "Europaquiz";
            this.Load += new System.EventHandler(this.Europaquiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_prüfe_Land_neu;
        private System.Windows.Forms.TextBox tb_Land;
        private System.Windows.Forms.TextBox tb_Hauptstadt;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}


﻿namespace Europaquiz
{
    partial class Hauptmenü
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
            this.Neues_Spiel = new System.Windows.Forms.Button();
            this.Tutorial = new System.Windows.Forms.Button();
            this.Einstellungen = new System.Windows.Forms.Button();
            this.Spiel_verlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Neues_Spiel
            // 
            this.Neues_Spiel.Location = new System.Drawing.Point(284, 50);
            this.Neues_Spiel.Name = "Neues_Spiel";
            this.Neues_Spiel.Size = new System.Drawing.Size(200, 50);
            this.Neues_Spiel.TabIndex = 0;
            this.Neues_Spiel.Text = "Spielen";
            this.Neues_Spiel.UseVisualStyleBackColor = true;
            this.Neues_Spiel.Click += new System.EventHandler(this.Neues_Spiel_Click);
            // 
            // Tutorial
            // 
            this.Tutorial.Location = new System.Drawing.Point(284, 150);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(200, 50);
            this.Tutorial.TabIndex = 1;
            this.Tutorial.Text = "Tutorial";
            this.Tutorial.UseVisualStyleBackColor = true;
            this.Tutorial.Click += new System.EventHandler(this.Tutorial_Click);
            // 
            // Einstellungen
            // 
            this.Einstellungen.Location = new System.Drawing.Point(284, 250);
            this.Einstellungen.Name = "Einstellungen";
            this.Einstellungen.Size = new System.Drawing.Size(200, 50);
            this.Einstellungen.TabIndex = 2;
            this.Einstellungen.Text = "Einstellungen";
            this.Einstellungen.UseVisualStyleBackColor = true;
            this.Einstellungen.Click += new System.EventHandler(this.Einstellungen_Click);
            // 
            // Spiel_verlassen
            // 
            this.Spiel_verlassen.Location = new System.Drawing.Point(284, 350);
            this.Spiel_verlassen.Name = "Spiel_verlassen";
            this.Spiel_verlassen.Size = new System.Drawing.Size(200, 50);
            this.Spiel_verlassen.TabIndex = 3;
            this.Spiel_verlassen.Text = "Spiel verlassen";
            this.Spiel_verlassen.UseVisualStyleBackColor = true;
            this.Spiel_verlassen.Click += new System.EventHandler(this.Spiel_verlassen_Click_1);
            // 
            // Hauptmenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.Spiel_verlassen);
            this.Controls.Add(this.Einstellungen);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.Neues_Spiel);
            this.Name = "Hauptmenü";
            this.Text = "Hauptmenü";
            this.Load += new System.EventHandler(this.Hauptmenü_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Neues_Spiel;
        private System.Windows.Forms.Button Tutorial;
        private System.Windows.Forms.Button Einstellungen;
        private System.Windows.Forms.Button Spiel_verlassen;
    }
}


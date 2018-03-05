namespace Europaquiz
{
    partial class Einstellungen
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
            this.Speichern = new System.Windows.Forms.Button();
            this.Schwierigkeit = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.info_Schwierigkeit = new System.Windows.Forms.Button();
            this.Eing_Art = new System.Windows.Forms.Label();
            this.Eingabe_Art = new System.Windows.Forms.ComboBox();
            this.info_Eing_art = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(83, 230);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(75, 27);
            this.Speichern.TabIndex = 0;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            // 
            // Schwierigkeit
            // 
            this.Schwierigkeit.AutoSize = true;
            this.Schwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Schwierigkeit.Location = new System.Drawing.Point(12, 27);
            this.Schwierigkeit.Name = "Schwierigkeit";
            this.Schwierigkeit.Size = new System.Drawing.Size(87, 16);
            this.Schwierigkeit.TabIndex = 1;
            this.Schwierigkeit.Text = "Schwierigkeit";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anfänger",
            "Fortgeschritten",
            "Profi"});
            this.comboBox1.Location = new System.Drawing.Point(111, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // info_Schwierigkeit
            // 
            this.info_Schwierigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_Schwierigkeit.Location = new System.Drawing.Point(244, 23);
            this.info_Schwierigkeit.Name = "info_Schwierigkeit";
            this.info_Schwierigkeit.Size = new System.Drawing.Size(25, 25);
            this.info_Schwierigkeit.TabIndex = 3;
            this.info_Schwierigkeit.Text = "i";
            this.info_Schwierigkeit.UseVisualStyleBackColor = true;
            // 
            // Eing_Art
            // 
            this.Eing_Art.AutoSize = true;
            this.Eing_Art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eing_Art.Location = new System.Drawing.Point(21, 78);
            this.Eing_Art.Name = "Eing_Art";
            this.Eing_Art.Size = new System.Drawing.Size(78, 16);
            this.Eing_Art.TabIndex = 4;
            this.Eing_Art.Text = "Eingabe Art";
            // 
            // Eingabe_Art
            // 
            this.Eingabe_Art.FormattingEnabled = true;
            this.Eingabe_Art.Items.AddRange(new object[] {
            "Microfon",
            "Text"});
            this.Eingabe_Art.Location = new System.Drawing.Point(111, 73);
            this.Eingabe_Art.Name = "Eingabe_Art";
            this.Eingabe_Art.Size = new System.Drawing.Size(121, 21);
            this.Eingabe_Art.TabIndex = 5;
            // 
            // info_Eing_art
            // 
            this.info_Eing_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_Eing_art.Location = new System.Drawing.Point(244, 70);
            this.info_Eing_art.Name = "info_Eing_art";
            this.info_Eing_art.Size = new System.Drawing.Size(25, 25);
            this.info_Eing_art.TabIndex = 6;
            this.info_Eing_art.Text = "i";
            this.info_Eing_art.UseVisualStyleBackColor = true;
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 269);
            this.Controls.Add(this.info_Eing_art);
            this.Controls.Add(this.Eingabe_Art);
            this.Controls.Add(this.Eing_Art);
            this.Controls.Add(this.info_Schwierigkeit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Schwierigkeit);
            this.Controls.Add(this.Speichern);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.Label Schwierigkeit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button info_Schwierigkeit;
        private System.Windows.Forms.Label Eing_Art;
        private System.Windows.Forms.ComboBox Eingabe_Art;
        private System.Windows.Forms.Button info_Eing_art;
    }
}
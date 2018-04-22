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
            this.Schwierigkeitsbox = new System.Windows.Forms.ComboBox();
            this.info_Schwierigkeit = new System.Windows.Forms.Button();
            this.Eing_Art = new System.Windows.Forms.Label();
            this.Eingabe_Artbox = new System.Windows.Forms.ComboBox();
            this.info_Eing_art = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speichern
            // 
            this.Speichern.Location = new System.Drawing.Point(111, 117);
            this.Speichern.Name = "Speichern";
            this.Speichern.Size = new System.Drawing.Size(75, 27);
            this.Speichern.TabIndex = 0;
            this.Speichern.Text = "Speichern";
            this.Speichern.UseVisualStyleBackColor = true;
            this.Speichern.Click += new System.EventHandler(this.Speichern_Click_1);
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
            // Schwierigkeitsbox
            // 
            this.Schwierigkeitsbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Schwierigkeitsbox.FormattingEnabled = true;
            this.Schwierigkeitsbox.Items.AddRange(new object[] {
            "Anfänger(1)",
            "Fortgeschritten(2)",
            "Profi(3)"});
            this.Schwierigkeitsbox.Location = new System.Drawing.Point(111, 27);
            this.Schwierigkeitsbox.Name = "Schwierigkeitsbox";
            this.Schwierigkeitsbox.Size = new System.Drawing.Size(121, 21);
            this.Schwierigkeitsbox.TabIndex = 2;
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
            this.info_Schwierigkeit.Click += new System.EventHandler(this.info_Schwierigkeit_Click);
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
            // Eingabe_Artbox
            // 
            this.Eingabe_Artbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Eingabe_Artbox.FormattingEnabled = true;
            this.Eingabe_Artbox.Items.AddRange(new object[] {
            "Microfon",
            "Text"});
            this.Eingabe_Artbox.Location = new System.Drawing.Point(111, 73);
            this.Eingabe_Artbox.Name = "Eingabe_Artbox";
            this.Eingabe_Artbox.Size = new System.Drawing.Size(121, 21);
            this.Eingabe_Artbox.TabIndex = 5;
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
            this.info_Eing_art.Click += new System.EventHandler(this.info_Eing_art_Click);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 156);
            this.Controls.Add(this.info_Eing_art);
            this.Controls.Add(this.Eingabe_Artbox);
            this.Controls.Add(this.Eing_Art);
            this.Controls.Add(this.info_Schwierigkeit);
            this.Controls.Add(this.Schwierigkeitsbox);
            this.Controls.Add(this.Schwierigkeit);
            this.Controls.Add(this.Speichern);
            this.Name = "Einstellungen";
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Einstellungen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speichern;
        private System.Windows.Forms.Label Schwierigkeit;
        private System.Windows.Forms.ComboBox Schwierigkeitsbox;
        private System.Windows.Forms.Button info_Schwierigkeit;
        private System.Windows.Forms.Label Eing_Art;
        private System.Windows.Forms.ComboBox Eingabe_Artbox;
        private System.Windows.Forms.Button info_Eing_art;
    }
}
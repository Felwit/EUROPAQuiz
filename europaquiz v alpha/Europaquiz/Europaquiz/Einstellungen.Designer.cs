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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            this.Speichern = new System.Windows.Forms.Button();
            this.Schwierigkeit = new System.Windows.Forms.Label();
            this.Schwierigkeitsbox = new System.Windows.Forms.ComboBox();
            this.Eing_Art = new System.Windows.Forms.Label();
            this.Eingabe_Artbox = new System.Windows.Forms.ComboBox();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
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
            "Einfach",
            "Normal",
            "Schwehr"});
            this.Schwierigkeitsbox.Location = new System.Drawing.Point(111, 27);
            this.Schwierigkeitsbox.Name = "Schwierigkeitsbox";
            this.Schwierigkeitsbox.Size = new System.Drawing.Size(121, 21);
            this.Schwierigkeitsbox.TabIndex = 2;
            this.Info.SetToolTip(this.Schwierigkeitsbox, "Wählen Sie ihre Schwiegigkeitsstufe.");
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
            this.Eingabe_Artbox.AccessibleDescription = "";
            this.Eingabe_Artbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Eingabe_Artbox.FormattingEnabled = true;
            this.Eingabe_Artbox.Items.AddRange(new object[] {
            "Microfon",
            "Text"});
            this.Eingabe_Artbox.Location = new System.Drawing.Point(111, 73);
            this.Eingabe_Artbox.Name = "Eingabe_Artbox";
            this.Eingabe_Artbox.Size = new System.Drawing.Size(121, 21);
            this.Eingabe_Artbox.TabIndex = 5;
            this.Info.SetToolTip(this.Eingabe_Artbox, "Wählen Sie ihre Eingabemethode. Wenn Sie kein Mikrofon besitzen oder kein Mikrofo" +
        "n angeschlossen haben wählen Sie \'Text\'.");
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 156);
            this.Controls.Add(this.Eingabe_Artbox);
            this.Controls.Add(this.Eing_Art);
            this.Controls.Add(this.Schwierigkeitsbox);
            this.Controls.Add(this.Schwierigkeit);
            this.Controls.Add(this.Speichern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label Eing_Art;
        private System.Windows.Forms.ComboBox Eingabe_Artbox;
        private System.Windows.Forms.ToolTip Info;
    }
}
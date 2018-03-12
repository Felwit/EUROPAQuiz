namespace Europaquiz
{
    partial class Europaquiz
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
            this.Button_starte_prüfe_Land = new System.Windows.Forms.Button();
            this.tb_Land = new System.Windows.Forms.TextBox();
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.TimerZumAntworten = new System.Windows.Forms.Timer(this.components);
            this.TimerAnzeige = new System.Windows.Forms.Label();
            this.LandAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_starte_prüfe_Land
            // 
            this.Button_starte_prüfe_Land.Location = new System.Drawing.Point(598, 12);
            this.Button_starte_prüfe_Land.Name = "Button_starte_prüfe_Land";
            this.Button_starte_prüfe_Land.Size = new System.Drawing.Size(180, 20);
            this.Button_starte_prüfe_Land.TabIndex = 0;
            this.Button_starte_prüfe_Land.Text = "Starten";
            this.Button_starte_prüfe_Land.UseVisualStyleBackColor = true;
            this.Button_starte_prüfe_Land.Click += new System.EventHandler(this.Button_starte_prüfe_Land_Click);
            // 
            // tb_Land
            // 
            this.tb_Land.Location = new System.Drawing.Point(12, 12);
            this.tb_Land.Name = "tb_Land";
            this.tb_Land.Size = new System.Drawing.Size(280, 20);
            this.tb_Land.TabIndex = 1;
            this.tb_Land.Text = "Bitte Land eingeben";
            // 
            // tb_Hauptstadt
            // 
            this.tb_Hauptstadt.Location = new System.Drawing.Point(301, 12);
            this.tb_Hauptstadt.Name = "tb_Hauptstadt";
            this.tb_Hauptstadt.Size = new System.Drawing.Size(280, 20);
            this.tb_Hauptstadt.TabIndex = 2;
            this.tb_Hauptstadt.Text = "Bitte Hauptstadt eingeben";
            // 
            // TimerZumAntworten
            // 
            this.TimerZumAntworten.Interval = 1000;
            this.TimerZumAntworten.Tick += new System.EventHandler(this.TimerZumAntworten_Tick);
            // 
            // TimerAnzeige
            // 
            this.TimerAnzeige.AutoSize = true;
            this.TimerAnzeige.Location = new System.Drawing.Point(679, 16);
            this.TimerAnzeige.Name = "TimerAnzeige";
            this.TimerAnzeige.Size = new System.Drawing.Size(19, 13);
            this.TimerAnzeige.TabIndex = 4;
            this.TimerAnzeige.Text = "10";
            this.TimerAnzeige.Visible = false;
            this.TimerAnzeige.Click += new System.EventHandler(this.TimerAnzeige_Click);
            // 
            // LandAnzeige
            // 
            this.LandAnzeige.AutoSize = true;
            this.LandAnzeige.Location = new System.Drawing.Point(545, 161);
            this.LandAnzeige.Name = "LandAnzeige";
            this.LandAnzeige.Size = new System.Drawing.Size(35, 13);
            this.LandAnzeige.TabIndex = 5;
            this.LandAnzeige.Text = "label1";
            // 
            // Europaquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 611);
            this.Controls.Add(this.LandAnzeige);
            this.Controls.Add(this.TimerAnzeige);
            this.Controls.Add(this.tb_Hauptstadt);
            this.Controls.Add(this.tb_Land);
            this.Controls.Add(this.Button_starte_prüfe_Land);
            this.Name = "Europaquiz";
            this.Text = "Europaquiz";
            this.Load += new System.EventHandler(this.Europaquiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_starte_prüfe_Land;
        private System.Windows.Forms.TextBox tb_Land;
        private System.Windows.Forms.TextBox tb_Hauptstadt;
        private System.Windows.Forms.Timer TimerZumAntworten;
        private System.Windows.Forms.Label TimerAnzeige;
        private System.Windows.Forms.Label LandAnzeige;
    }
}
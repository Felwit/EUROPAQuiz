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
            this.Button_prüfe_Land_neu = new System.Windows.Forms.Button();
            this.tb_Land = new System.Windows.Forms.TextBox();
            this.Punkte = new System.Windows.Forms.Label();
            this.LEingaben = new System.Windows.Forms.Label();
            this.LLösung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Zoom = new System.Windows.Forms.PictureBox();
            this.Vorzeitig_beenden = new System.Windows.Forms.Button();
            this.LösungsAnzeige = new System.Windows.Forms.Label();
            this.CountdownText = new System.Windows.Forms.Label();
            this.CountdownZaehler = new System.Windows.Forms.Label();
            this.PunkteZahlAnzeige = new System.Windows.Forms.Label();
            this.Ergebnis_speichern = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Ohne_Speichern = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_prüfe_Land_neu
            // 
            this.Button_prüfe_Land_neu.Location = new System.Drawing.Point(3, 77);
            this.Button_prüfe_Land_neu.Name = "Button_prüfe_Land_neu";
            this.Button_prüfe_Land_neu.Size = new System.Drawing.Size(79, 52);
            this.Button_prüfe_Land_neu.TabIndex = 0;
            this.Button_prüfe_Land_neu.Text = "Nächstes Land";
            this.Button_prüfe_Land_neu.UseVisualStyleBackColor = true;
            this.Button_prüfe_Land_neu.Click += new System.EventHandler(this.Button_prüfe_Land_neu_Click);
            // 
            // tb_Land
            // 
            this.tb_Land.Location = new System.Drawing.Point(91, 77);
            this.tb_Land.Name = "tb_Land";
            this.tb_Land.Size = new System.Drawing.Size(117, 20);
            this.tb_Land.TabIndex = 1;
            this.tb_Land.Text = "Bitte Land eingeben";
            this.tb_Land.Visible = false;
            this.tb_Land.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Land_KeyDown);
            // 
            // Punkte
            // 
            this.Punkte.AutoSize = true;
            this.Punkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punkte.Location = new System.Drawing.Point(3, 194);
            this.Punkte.Name = "Punkte";
            this.Punkte.Size = new System.Drawing.Size(52, 16);
            this.Punkte.TabIndex = 3;
            this.Punkte.Text = "Punkte:";
            // 
            // LEingaben
            // 
            this.LEingaben.AutoSize = true;
            this.LEingaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEingaben.Location = new System.Drawing.Point(3, 266);
            this.LEingaben.Name = "LEingaben";
            this.LEingaben.Size = new System.Drawing.Size(69, 32);
            this.LEingaben.TabIndex = 4;
            this.LEingaben.Text = "Letzte Eingaben:";
            // 
            // LLösung
            // 
            this.LLösung.AutoSize = true;
            this.LLösung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLösung.Location = new System.Drawing.Point(3, 335);
            this.LLösung.Name = "LLösung";
            this.LLösung.Size = new System.Drawing.Size(70, 16);
            this.LLösung.TabIndex = 5;
            this.LLösung.Text = "Lösungen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hauptstadt";
            // 
            // tb_Hauptstadt
            // 
            this.tb_Hauptstadt.Location = new System.Drawing.Point(313, 77);
            this.tb_Hauptstadt.Name = "tb_Hauptstadt";
            this.tb_Hauptstadt.Size = new System.Drawing.Size(131, 20);
            this.tb_Hauptstadt.TabIndex = 2;
            this.tb_Hauptstadt.Text = "Bitte Hauptstadt eingeben";
            this.tb_Hauptstadt.Visible = false;
            this.tb_Hauptstadt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Hauptstadt_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6868F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66443F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.42506F));
            this.tableLayoutPanel3.Controls.Add(this.LLösung, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.LEingaben, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Punkte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Hauptstadt, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Zoom, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.Vorzeitig_beenden, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.LösungsAnzeige, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.Button_prüfe_Land_neu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Land, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.CountdownText, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CountdownZaehler, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.PunkteZahlAnzeige, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(923, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92793F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.04504F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.14007F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(447, 749);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Zoom
            // 
            this.Zoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zoom.Location = new System.Drawing.Point(91, 387);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(216, 359);
            this.Zoom.TabIndex = 8;
            this.Zoom.TabStop = false;
            // 
            // Vorzeitig_beenden
            // 
            this.Vorzeitig_beenden.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vorzeitig_beenden.Location = new System.Drawing.Point(313, 387);
            this.Vorzeitig_beenden.Name = "Vorzeitig_beenden";
            this.Vorzeitig_beenden.Size = new System.Drawing.Size(131, 23);
            this.Vorzeitig_beenden.TabIndex = 9;
            this.Vorzeitig_beenden.Text = "Vorzeitig beenden";
            this.Vorzeitig_beenden.UseVisualStyleBackColor = true;
            this.Vorzeitig_beenden.Click += new System.EventHandler(this.Vorzeitig_beenden_Click);
            // 
            // LösungsAnzeige
            // 
            this.LösungsAnzeige.AutoSize = true;
            this.LösungsAnzeige.Location = new System.Drawing.Point(91, 335);
            this.LösungsAnzeige.Name = "LösungsAnzeige";
            this.LösungsAnzeige.Size = new System.Drawing.Size(38, 13);
            this.LösungsAnzeige.TabIndex = 10;
            this.LösungsAnzeige.Text = "lösung";
            // 
            // CountdownText
            // 
            this.CountdownText.AutoSize = true;
            this.CountdownText.Location = new System.Drawing.Point(3, 0);
            this.CountdownText.Name = "CountdownText";
            this.CountdownText.Size = new System.Drawing.Size(64, 13);
            this.CountdownText.TabIndex = 11;
            this.CountdownText.Text = "Countdown:";
            // 
            // CountdownZaehler
            // 
            this.CountdownZaehler.AutoSize = true;
            this.CountdownZaehler.Location = new System.Drawing.Point(91, 0);
            this.CountdownZaehler.Name = "CountdownZaehler";
            this.CountdownZaehler.Size = new System.Drawing.Size(19, 13);
            this.CountdownZaehler.TabIndex = 12;
            this.CountdownZaehler.Text = "10";
            // 
            // PunkteZahlAnzeige
            // 
            this.PunkteZahlAnzeige.AutoSize = true;
            this.PunkteZahlAnzeige.Location = new System.Drawing.Point(91, 194);
            this.PunkteZahlAnzeige.Name = "PunkteZahlAnzeige";
            this.PunkteZahlAnzeige.Size = new System.Drawing.Size(13, 13);
            this.PunkteZahlAnzeige.TabIndex = 13;
            this.PunkteZahlAnzeige.Text = "0";
            // 
            // Ergebnis_speichern
            // 
            this.Ergebnis_speichern.Location = new System.Drawing.Point(122, 196);
            this.Ergebnis_speichern.Name = "Ergebnis_speichern";
            this.Ergebnis_speichern.Size = new System.Drawing.Size(245, 110);
            this.Ergebnis_speichern.TabIndex = 12;
            this.Ergebnis_speichern.Text = "Ergebnis speichern";
            this.Ergebnis_speichern.UseVisualStyleBackColor = true;
            this.Ergebnis_speichern.Visible = false;
            this.Ergebnis_speichern.Click += new System.EventHandler(this.Ergebnis_speichern_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1370, 749);
            this.webBrowser1.TabIndex = 13;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Ohne_Speichern
            // 
            this.Ohne_Speichern.Location = new System.Drawing.Point(525, 196);
            this.Ohne_Speichern.Name = "Ohne_Speichern";
            this.Ohne_Speichern.Size = new System.Drawing.Size(245, 110);
            this.Ohne_Speichern.TabIndex = 15;
            this.Ohne_Speichern.Text = "Ohne Speichern beenden";
            this.Ohne_Speichern.UseVisualStyleBackColor = true;
            this.Ohne_Speichern.Visible = false;
            this.Ohne_Speichern.Click += new System.EventHandler(this.Ohne_Speichern_Click_1);
            // 
            // Europaquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.Ohne_Speichern);
            this.Controls.Add(this.Ergebnis_speichern);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Europaquiz";
            this.Text = "Europaquiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Europaquiz_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_prüfe_Land_neu;
        private System.Windows.Forms.TextBox tb_Land;
        private System.Windows.Forms.Label Punkte;
        private System.Windows.Forms.Label LEingaben;
        private System.Windows.Forms.Label LLösung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Hauptstadt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Ergebnis_speichern;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox Zoom;
        private System.Windows.Forms.Button Vorzeitig_beenden;
        private System.Windows.Forms.Label LösungsAnzeige;
        private System.Windows.Forms.Label CountdownText;
        private System.Windows.Forms.Label CountdownZaehler;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Ohne_Speichern;
        private System.Windows.Forms.Label PunkteZahlAnzeige;
    }
}
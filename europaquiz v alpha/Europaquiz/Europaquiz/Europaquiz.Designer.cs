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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Europaquiz));
            this.Button_prüfe_Land_neu = new System.Windows.Forms.Button();
            this.tb_Land = new System.Windows.Forms.TextBox();
            this.Punkte = new System.Windows.Forms.Label();
            this.LEingaben = new System.Windows.Forms.Label();
            this.LLösung = new System.Windows.Forms.Label();
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Zoom = new System.Windows.Forms.PictureBox();
            this.Vorzeitig_beenden = new System.Windows.Forms.Button();
            this.LösungLand = new System.Windows.Forms.Label();
            this.LösungHS = new System.Windows.Forms.Label();
            this.LetzteEingabeLand = new System.Windows.Forms.Label();
            this.LetzteEIngabeHS = new System.Windows.Forms.Label();
            this.PunkteZahlAnzeige = new System.Windows.Forms.Label();
            this.BitteLandEingebenTitel = new System.Windows.Forms.Label();
            this.BitteHaupstadteingebenTitel = new System.Windows.Forms.Label();
            this.CountdownText = new System.Windows.Forms.Label();
            this.CountdownZaehler = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ergebnis_speichern = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Ohne_Speichern = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_prüfe_Land_neu
            // 
            this.Button_prüfe_Land_neu.Location = new System.Drawing.Point(3, 217);
            this.Button_prüfe_Land_neu.Name = "Button_prüfe_Land_neu";
            this.Button_prüfe_Land_neu.Size = new System.Drawing.Size(79, 52);
            this.Button_prüfe_Land_neu.TabIndex = 0;
            this.Button_prüfe_Land_neu.Text = "Start";
            this.Button_prüfe_Land_neu.UseVisualStyleBackColor = true;
            this.Button_prüfe_Land_neu.Click += new System.EventHandler(this.Button_prüfe_Land_neu_Click);
            // 
            // tb_Land
            // 
            this.tb_Land.Location = new System.Drawing.Point(91, 217);
            this.tb_Land.Name = "tb_Land";
            this.tb_Land.Size = new System.Drawing.Size(117, 20);
            this.tb_Land.TabIndex = 1;
            this.tb_Land.Visible = false;
            this.tb_Land.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Land_KeyDown);
            // 
            // Punkte
            // 
            this.Punkte.AutoSize = true;
            this.Punkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punkte.Location = new System.Drawing.Point(3, 344);
            this.Punkte.Name = "Punkte";
            this.Punkte.Size = new System.Drawing.Size(52, 16);
            this.Punkte.TabIndex = 3;
            this.Punkte.Text = "Punkte:";
            // 
            // LEingaben
            // 
            this.LEingaben.AutoSize = true;
            this.LEingaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEingaben.Location = new System.Drawing.Point(3, 387);
            this.LEingaben.Name = "LEingaben";
            this.LEingaben.Size = new System.Drawing.Size(69, 32);
            this.LEingaben.TabIndex = 4;
            this.LEingaben.Text = "Letzte Eingaben:";
            // 
            // LLösung
            // 
            this.LLösung.AutoSize = true;
            this.LLösung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLösung.Location = new System.Drawing.Point(3, 453);
            this.LLösung.Name = "LLösung";
            this.LLösung.Size = new System.Drawing.Size(70, 16);
            this.LLösung.TabIndex = 5;
            this.LLösung.Text = "Lösungen:";
            // 
            // tb_Hauptstadt
            // 
            this.tb_Hauptstadt.Location = new System.Drawing.Point(302, 217);
            this.tb_Hauptstadt.Name = "tb_Hauptstadt";
            this.tb_Hauptstadt.Size = new System.Drawing.Size(131, 20);
            this.tb_Hauptstadt.TabIndex = 2;
            this.tb_Hauptstadt.Visible = false;
            this.tb_Hauptstadt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Hauptstadt_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.6868F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.20358F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.88591F));
            this.tableLayoutPanel3.Controls.Add(this.Zoom, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.Vorzeitig_beenden, 2, 8);
            this.tableLayoutPanel3.Controls.Add(this.LLösung, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.LösungLand, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.LösungHS, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.LEingaben, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.LetzteEingabeLand, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.LetzteEIngabeHS, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.Punkte, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.PunkteZahlAnzeige, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Button_prüfe_Land_neu, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Land, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.CountdownZaehler, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.BitteLandEingebenTitel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.CountdownText, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tb_Hauptstadt, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.BitteHaupstadteingebenTitel, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(923, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17391F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.3815F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65318F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(447, 749);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Zoom
            // 
            this.Zoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zoom.Location = new System.Drawing.Point(91, 482);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(205, 264);
            this.Zoom.TabIndex = 8;
            this.Zoom.TabStop = false;
            // 
            // Vorzeitig_beenden
            // 
            this.Vorzeitig_beenden.Location = new System.Drawing.Point(302, 482);
            this.Vorzeitig_beenden.Name = "Vorzeitig_beenden";
            this.Vorzeitig_beenden.Size = new System.Drawing.Size(131, 23);
            this.Vorzeitig_beenden.TabIndex = 9;
            this.Vorzeitig_beenden.Text = "Vorzeitig beenden";
            this.Vorzeitig_beenden.UseVisualStyleBackColor = true;
            this.Vorzeitig_beenden.Click += new System.EventHandler(this.Vorzeitig_beenden_Click);
            // 
            // LösungLand
            // 
            this.LösungLand.AutoSize = true;
            this.LösungLand.Location = new System.Drawing.Point(91, 453);
            this.LösungLand.Name = "LösungLand";
            this.LösungLand.Size = new System.Drawing.Size(19, 13);
            this.LösungLand.TabIndex = 10;
            this.LösungLand.Text = "    ";
            // 
            // LösungHS
            // 
            this.LösungHS.AutoSize = true;
            this.LösungHS.Location = new System.Drawing.Point(302, 453);
            this.LösungHS.Name = "LösungHS";
            this.LösungHS.Size = new System.Drawing.Size(16, 13);
            this.LösungHS.TabIndex = 14;
            this.LösungHS.Text = "   ";
            // 
            // LetzteEingabeLand
            // 
            this.LetzteEingabeLand.AutoSize = true;
            this.LetzteEingabeLand.Location = new System.Drawing.Point(91, 387);
            this.LetzteEingabeLand.Name = "LetzteEingabeLand";
            this.LetzteEingabeLand.Size = new System.Drawing.Size(19, 13);
            this.LetzteEingabeLand.TabIndex = 15;
            this.LetzteEingabeLand.Text = "    ";
            // 
            // LetzteEIngabeHS
            // 
            this.LetzteEIngabeHS.AutoSize = true;
            this.LetzteEIngabeHS.Location = new System.Drawing.Point(302, 387);
            this.LetzteEIngabeHS.Name = "LetzteEIngabeHS";
            this.LetzteEIngabeHS.Size = new System.Drawing.Size(19, 13);
            this.LetzteEIngabeHS.TabIndex = 16;
            this.LetzteEIngabeHS.Text = "    ";
            // 
            // PunkteZahlAnzeige
            // 
            this.PunkteZahlAnzeige.AutoSize = true;
            this.PunkteZahlAnzeige.Location = new System.Drawing.Point(91, 344);
            this.PunkteZahlAnzeige.Name = "PunkteZahlAnzeige";
            this.PunkteZahlAnzeige.Size = new System.Drawing.Size(13, 13);
            this.PunkteZahlAnzeige.TabIndex = 13;
            this.PunkteZahlAnzeige.Text = "0";
            // 
            // BitteLandEingebenTitel
            // 
            this.BitteLandEingebenTitel.AutoSize = true;
            this.BitteLandEingebenTitel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BitteLandEingebenTitel.Location = new System.Drawing.Point(91, 201);
            this.BitteLandEingebenTitel.Name = "BitteLandEingebenTitel";
            this.BitteLandEingebenTitel.Size = new System.Drawing.Size(205, 13);
            this.BitteLandEingebenTitel.TabIndex = 17;
            this.BitteLandEingebenTitel.Text = "Bitte Land eingeben:";
            this.BitteLandEingebenTitel.Visible = false;
            // 
            // BitteHaupstadteingebenTitel
            // 
            this.BitteHaupstadteingebenTitel.AutoSize = true;
            this.BitteHaupstadteingebenTitel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BitteHaupstadteingebenTitel.Location = new System.Drawing.Point(302, 201);
            this.BitteHaupstadteingebenTitel.Name = "BitteHaupstadteingebenTitel";
            this.BitteHaupstadteingebenTitel.Size = new System.Drawing.Size(142, 13);
            this.BitteHaupstadteingebenTitel.TabIndex = 18;
            this.BitteHaupstadteingebenTitel.Text = "Bitte Hauptstadt eingeben:";
            this.BitteHaupstadteingebenTitel.Visible = false;
            // 
            // CountdownText
            // 
            this.CountdownText.AutoSize = true;
            this.CountdownText.Location = new System.Drawing.Point(3, 307);
            this.CountdownText.Name = "CountdownText";
            this.CountdownText.Size = new System.Drawing.Size(64, 13);
            this.CountdownText.TabIndex = 11;
            this.CountdownText.Text = "Countdown:";
            // 
            // CountdownZaehler
            // 
            this.CountdownZaehler.AutoSize = true;
            this.CountdownZaehler.Dock = System.Windows.Forms.DockStyle.Top;
            this.CountdownZaehler.Location = new System.Drawing.Point(91, 307);
            this.CountdownZaehler.Name = "CountdownZaehler";
            this.CountdownZaehler.Size = new System.Drawing.Size(205, 13);
            this.CountdownZaehler.TabIndex = 12;
            this.CountdownZaehler.Text = "15";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Europaquiz.Properties.Resources.Logo3;
            this.pictureBox1.Location = new System.Drawing.Point(91, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Ergebnis_speichern
            // 
            this.Ergebnis_speichern.Location = new System.Drawing.Point(124, 266);
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
            this.Ohne_Speichern.Location = new System.Drawing.Point(534, 269);
            this.Ohne_Speichern.Name = "Ohne_Speichern";
            this.Ohne_Speichern.Size = new System.Drawing.Size(245, 110);
            this.Ohne_Speichern.TabIndex = 15;
            this.Ohne_Speichern.Text = "Ohne Speichern beenden";
            this.Ohne_Speichern.UseVisualStyleBackColor = true;
            this.Ohne_Speichern.Visible = false;
            this.Ohne_Speichern.Click += new System.EventHandler(this.Ohne_Speichern_Click_1);
            // 
            // LogoBox
            // 
            this.LogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.InitialImage")));
            this.LogoBox.Location = new System.Drawing.Point(601, 424);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(257, 171);
            this.LogoBox.TabIndex = 17;
            this.LogoBox.TabStop = false;
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
            this.Controls.Add(this.LogoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Europaquiz";
            this.Text = "Europaquiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Europaquiz_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_prüfe_Land_neu;
        private System.Windows.Forms.TextBox tb_Land;
        private System.Windows.Forms.Label Punkte;
        private System.Windows.Forms.Label LEingaben;
        private System.Windows.Forms.Label LLösung;
        private System.Windows.Forms.TextBox tb_Hauptstadt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Ergebnis_speichern;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox Zoom;
        private System.Windows.Forms.Button Vorzeitig_beenden;
        private System.Windows.Forms.Label LösungLand;
        private System.Windows.Forms.Label CountdownText;
        private System.Windows.Forms.Label CountdownZaehler;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Ohne_Speichern;
        private System.Windows.Forms.Label PunkteZahlAnzeige;
        private System.Windows.Forms.Label LösungHS;
        private System.Windows.Forms.Label LetzteEingabeLand;
        private System.Windows.Forms.Label LetzteEIngabeHS;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label BitteLandEingebenTitel;
        private System.Windows.Forms.Label BitteHaupstadteingebenTitel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
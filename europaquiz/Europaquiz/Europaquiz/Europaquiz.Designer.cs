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
            this.Button_prüfe_Land_neu = new System.Windows.Forms.Button();
            this.tb_Land = new System.Windows.Forms.TextBox();
            this.Punkte = new System.Windows.Forms.Label();
            this.LEingaben = new System.Windows.Forms.Label();
            this.LLösung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Zoom = new System.Windows.Forms.PictureBox();
            this.Vorzeitig_beenden = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Ergebnis_speichern = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Ohne_Speichern = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_prüfe_Land_neu
            // 
            this.Button_prüfe_Land_neu.Location = new System.Drawing.Point(3, 136);
            this.Button_prüfe_Land_neu.Name = "Button_prüfe_Land_neu";
            this.Button_prüfe_Land_neu.Size = new System.Drawing.Size(79, 52);
            this.Button_prüfe_Land_neu.TabIndex = 0;
            this.Button_prüfe_Land_neu.Text = "Nächstes Land";
            this.Button_prüfe_Land_neu.UseVisualStyleBackColor = true;
            this.Button_prüfe_Land_neu.Click += new System.EventHandler(this.Button_prüfe_Land_neu_Click);
            // 
            // tb_Land
            // 
            this.tb_Land.Location = new System.Drawing.Point(88, 136);
            this.tb_Land.Name = "tb_Land";
            this.tb_Land.Size = new System.Drawing.Size(117, 20);
            this.tb_Land.TabIndex = 1;
            this.tb_Land.Text = "Bitte Land eingeben";
            this.tb_Land.Visible = false;
            this.tb_Land.TextChanged += new System.EventHandler(this.tb_Land_TextChanged);
            this.tb_Land.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Land_KeyDown);
            // 
            // Punkte
            // 
            this.Punkte.AutoSize = true;
            this.Punkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punkte.Location = new System.Drawing.Point(3, 348);
            this.Punkte.Name = "Punkte";
            this.Punkte.Size = new System.Drawing.Size(62, 16);
            this.Punkte.TabIndex = 3;
            this.Punkte.Text = "Punkte: 0";
            // 
            // LEingaben
            // 
            this.LEingaben.AutoSize = true;
            this.LEingaben.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEingaben.Location = new System.Drawing.Point(3, 477);
            this.LEingaben.Name = "LEingaben";
            this.LEingaben.Size = new System.Drawing.Size(69, 32);
            this.LEingaben.TabIndex = 4;
            this.LEingaben.Text = "Letzte Eingaben:";
            // 
            // LLösung
            // 
            this.LLösung.AutoSize = true;
            this.LLösung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLösung.Location = new System.Drawing.Point(3, 546);
            this.LLösung.Name = "LLösung";
            this.LLösung.Size = new System.Drawing.Size(70, 16);
            this.LLösung.TabIndex = 5;
            this.LLösung.Text = "Lösungen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Land";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hauptstadt";
            // 
            // tb_Hauptstadt
            // 
            this.tb_Hauptstadt.Location = new System.Drawing.Point(211, 136);
            this.tb_Hauptstadt.Name = "tb_Hauptstadt";
            this.tb_Hauptstadt.Size = new System.Drawing.Size(134, 20);
            this.tb_Hauptstadt.TabIndex = 2;
            this.tb_Hauptstadt.Text = "Bitte Hauptstadt eingeben";
            this.tb_Hauptstadt.Visible = false;
            this.tb_Hauptstadt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Hauptstadt_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72826F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.63218F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.94253F));
            this.tableLayoutPanel3.Controls.Add(this.LLösung, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.LEingaben, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Punkte, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Hauptstadt, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.Zoom, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.Vorzeitig_beenden, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.Button_prüfe_Land_neu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Land, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1236, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92793F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.04504F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.14007F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(348, 961);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(88, 598);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(117, 122);
            this.Zoom.TabIndex = 8;
            this.Zoom.TabStop = false;
            // 
            // Vorzeitig_beenden
            // 
            this.Vorzeitig_beenden.Dock = System.Windows.Forms.DockStyle.Top;
            this.Vorzeitig_beenden.Location = new System.Drawing.Point(211, 598);
            this.Vorzeitig_beenden.Name = "Vorzeitig_beenden";
            this.Vorzeitig_beenden.Size = new System.Drawing.Size(134, 23);
            this.Vorzeitig_beenden.TabIndex = 9;
            this.Vorzeitig_beenden.Text = "Vorzeitig beenden";
            this.Vorzeitig_beenden.UseVisualStyleBackColor = true;
            this.Vorzeitig_beenden.Click += new System.EventHandler(this.Vorzeitig_beenden_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // Ergebnis_speichern
            // 
            this.Ergebnis_speichern.Location = new System.Drawing.Point(632, 334);
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
            this.webBrowser1.Size = new System.Drawing.Size(1584, 961);
            this.webBrowser1.TabIndex = 13;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Ohne_Speichern
            // 
            this.Ohne_Speichern.Location = new System.Drawing.Point(274, 334);
            this.Ohne_Speichern.Name = "Ohne_Speichern";
            this.Ohne_Speichern.Size = new System.Drawing.Size(245, 110);
            this.Ohne_Speichern.TabIndex = 14;
            this.Ohne_Speichern.Text = "ohne Speichern verlassen";
            this.Ohne_Speichern.UseVisualStyleBackColor = true;
            this.Ohne_Speichern.Visible = false;
            this.Ohne_Speichern.Click += new System.EventHandler(this.Ohne_Speichern_Click);
            // 
            // Europaquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Hauptstadt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Ergebnis_speichern;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox Zoom;
        private System.Windows.Forms.Button Vorzeitig_beenden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ohne_Speichern;
    }
}
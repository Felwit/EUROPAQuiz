namespace Europaquiz
{
    partial class Ergebnis_Speichern
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.VornameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.erstellen = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(161, 64);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(128, 20);
            this.NameTB.TabIndex = 0;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // VornameTB
            // 
            this.VornameTB.Location = new System.Drawing.Point(161, 118);
            this.VornameTB.Name = "VornameTB";
            this.VornameTB.Size = new System.Drawing.Size(128, 20);
            this.VornameTB.TabIndex = 1;
            this.VornameTB.TextChanged += new System.EventHandler(this.VornameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vorname";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(41, 24);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(277, 13);
            this.Info.TabIndex = 6;
            this.Info.Text = "Bitte geben  Sie folgendes, zum erstellen der Urkunde ein";
            // 
            // erstellen
            // 
            this.erstellen.Location = new System.Drawing.Point(161, 167);
            this.erstellen.Name = "erstellen";
            this.erstellen.Size = new System.Drawing.Size(75, 23);
            this.erstellen.TabIndex = 7;
            this.erstellen.Text = "erstellen";
            this.erstellen.UseVisualStyleBackColor = true;
            this.erstellen.Visible = false;
            this.erstellen.Click += new System.EventHandler(this.erstellen_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Ergebnis_Speichern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 215);
            this.Controls.Add(this.erstellen);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VornameTB);
            this.Controls.Add(this.NameTB);
            this.Name = "Ergebnis_Speichern";
            this.Text = "Ergebnis_Speichern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox VornameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button erstellen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
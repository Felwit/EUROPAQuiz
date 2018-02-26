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
            this.tb_Hauptstadt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_prüfe_Land_neu
            // 
            this.Button_prüfe_Land_neu.Location = new System.Drawing.Point(598, 12);
            this.Button_prüfe_Land_neu.Name = "Button_prüfe_Land_neu";
            this.Button_prüfe_Land_neu.Size = new System.Drawing.Size(180, 20);
            this.Button_prüfe_Land_neu.TabIndex = 0;
            this.Button_prüfe_Land_neu.Text = "Nächstes Land";
            this.Button_prüfe_Land_neu.UseVisualStyleBackColor = true;
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
            // Europaquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 611);
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
    }
}
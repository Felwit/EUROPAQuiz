namespace Europaquiz
{
    partial class VerlassenBestätigen
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nichtverlassen = new System.Windows.Forms.Button();
            this.verlassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wollen Sie das Spiel wirklich verlassen?";
            // 
            // Nichtverlassen
            // 
            this.Nichtverlassen.Location = new System.Drawing.Point(198, 45);
            this.Nichtverlassen.Name = "Nichtverlassen";
            this.Nichtverlassen.Size = new System.Drawing.Size(113, 25);
            this.Nichtverlassen.TabIndex = 1;
            this.Nichtverlassen.Text = "Nein";
            this.Nichtverlassen.UseVisualStyleBackColor = true;
            // 
            // verlassen
            // 
            this.verlassen.Location = new System.Drawing.Point(18, 45);
            this.verlassen.Name = "verlassen";
            this.verlassen.Size = new System.Drawing.Size(125, 25);
            this.verlassen.TabIndex = 2;
            this.verlassen.Text = "Ja";
            this.verlassen.UseVisualStyleBackColor = true;
            // 
            // VerlassenBestätigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 84);
            this.Controls.Add(this.verlassen);
            this.Controls.Add(this.Nichtverlassen);
            this.Controls.Add(this.label1);
            this.Name = "VerlassenBestätigen";
            this.Text = "Verlassen Bestätigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nichtverlassen;
        private System.Windows.Forms.Button verlassen;
    }
}
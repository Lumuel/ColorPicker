namespace ColorPicker
{
    partial class frmFarbauswahl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.frmFarbauswahl_btnStart = new System.Windows.Forms.Button();
            this.frmFarbauswahl_lblIntroText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmFarbauswahl_btnStart
            // 
            this.frmFarbauswahl_btnStart.Location = new System.Drawing.Point(101, 110);
            this.frmFarbauswahl_btnStart.Name = "frmFarbauswahl_btnStart";
            this.frmFarbauswahl_btnStart.Size = new System.Drawing.Size(126, 23);
            this.frmFarbauswahl_btnStart.TabIndex = 0;
            this.frmFarbauswahl_btnStart.Text = "Start";
            this.frmFarbauswahl_btnStart.UseVisualStyleBackColor = true;
            this.frmFarbauswahl_btnStart.Click += new System.EventHandler(this.frmFarbauswahl_btnStart_Click);
            // 
            // frmFarbauswahl_lblIntroText
            // 
            this.frmFarbauswahl_lblIntroText.AutoSize = true;
            this.frmFarbauswahl_lblIntroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.frmFarbauswahl_lblIntroText.Location = new System.Drawing.Point(6, 50);
            this.frmFarbauswahl_lblIntroText.Name = "frmFarbauswahl_lblIntroText";
            this.frmFarbauswahl_lblIntroText.Size = new System.Drawing.Size(315, 18);
            this.frmFarbauswahl_lblIntroText.TabIndex = 1;
            this.frmFarbauswahl_lblIntroText.Text = "\"Start\" drücken, um die Farbauswahl zu starten";
            // 
            // frmFarbauswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 161);
            this.Controls.Add(this.frmFarbauswahl_lblIntroText);
            this.Controls.Add(this.frmFarbauswahl_btnStart);
            this.Name = "frmFarbauswahl";
            this.Text = "Farbauswahl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button frmFarbauswahl_btnStart;
        private System.Windows.Forms.Label frmFarbauswahl_lblIntroText;
    }
}

